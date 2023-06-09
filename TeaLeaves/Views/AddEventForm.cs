﻿using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// Represents a form for adding or editing an event.
    /// </summary>
    public partial class AddEventForm : Form
    {
        private EventController _eventController;
        private EventResponsibilityController _eventResponsibilityController;
        private List<EventResponsibility> _eventResponsibilities;
        private List<EventResponsibility> _newEventResponsibilities;
        private Event _event;

        /// <summary>
        /// Initializes a new instance of the AddEventForm class with the specified selected event.
        /// </summary>
        /// <param name="selectedEvent">The event to be edited. If null, a new event will be created.</param>
        public AddEventForm(Event selectedEvent)
        {
            InitializeComponent();
            _eventController = new EventController();
            _eventResponsibilityController = new EventResponsibilityController();
            _eventResponsibilities = new List<EventResponsibility>();
            _newEventResponsibilities = new List<EventResponsibility>();
            _event = selectedEvent ?? new Event();
            BindEventValue();
            dgvResponsibilities.AutoGenerateColumns = false;
        }
        private void BindEventValue()
        {

            textBoxEName.Text = _event.EventName;
            textBoxStreetName.Text = _event.StreetNumber;
            textBoxCity.Text = _event.City;
            comboBoxState.Text = _event.State;
            comboBoxCategory.Text = _event.Category;
            textBoxZip.Text = _event.Zipcode != 0 ? _event.Zipcode.ToString() : string.Empty;
            richTextBoxDescription.Text = _event.Description;
            if (_event.Id > 0)
            {
                dateTimePickerEvent.Value = _event.EventDateTime;
                numericUpDownHour.Value = _event.EventDateTime.Hour;
                numericUpDownMinute.Value = _event.EventDateTime.Minute;

            }
        }
        private void EventsForm_Load(object sender, EventArgs e)
        {
            if (_event.Id == 0)
            {
                dateTimePickerEvent.Value = DateTime.Now;
                numericUpDownHour.Value = DateTime.Now.Hour;
                numericUpDownMinute.Value = DateTime.Now.Minute;
            }

            BindCategory();
            BindState();
            LoadEventResponsibilities();
        }

        private void LoadEventResponsibilities()
        {
            try
            {
                _eventResponsibilities = _eventResponsibilityController.GetEventResponsibilitiesByEventId(_event.Id);

                dgvResponsibilities.DataSource = _eventResponsibilities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void BindState()
        {
            string[] states = {
   "None", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida",
    "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine",
    "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada",
    "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma",
    "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
    "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"
};
            comboBoxState.Items.Clear();
            comboBoxState.Items.AddRange(states);
            comboBoxState.SelectedIndex = 0;

        }

        private bool IsFormValid()
        {
            DateTime eventTime = dateTimePickerEvent.Value.Date + new TimeSpan(Convert.ToInt16(numericUpDownHour.Value), Convert.ToInt16(numericUpDownMinute.Value), 0);
            if (textBoxEName.Text.Trim().Length == 0)
            {
                labelError.Text = "Please enter the event name";
                return false;
            }

            if (eventTime < DateTime.Now)
            {
                labelError.Text = "Please choose a future time";
                return false;
            }


            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;

            if (IsFormValid())
            {
                _event.CreatorId = CurrentUserStore.User.UserId;
                _event.EventName = textBoxEName.Text.Trim();
                _event.StreetNumber = textBoxStreetName.Text.Trim();
                _event.State = comboBoxState.SelectedItem.ToString();
                _event.Category = comboBoxCategory.SelectedItem.ToString();
                _event.City = textBoxCity.Text.Trim();
                _event.Description = richTextBoxDescription.Text.Trim();
                _event.Zipcode = 0;

                if (!string.IsNullOrEmpty(textBoxZip.Text.Trim()) && int.TryParse(textBoxZip.Text.Trim(), out int zipcodeValue))
                {
                    if (zipcodeValue.ToString().Length != 5)
                    {
                        labelError.Text = "Invalid ZIP code. Please enter a 5-digit number.";
                        return;
                    }

                    _event.Zipcode = zipcodeValue;
                }
                _event.EventDateTime = dateTimePickerEvent.Value.Date + new TimeSpan(Convert.ToInt16(numericUpDownHour.Value), Convert.ToInt16(numericUpDownMinute.Value), 0);
                try
                {
                    _eventController.SaveEvent(_event, _newEventResponsibilities);
                    MessageBox.Show("Event has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void numericUpDownHour_ValueChanged(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;
        }

        private void numericUpDownMinute_ValueChanged(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;

        }
        private void buttonClose_click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePickerEvent_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEvent.MinDate = DateTime.Now.Date;
        }

        private void textBoxZip_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;
        }

        private void textBoxEName_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;
        }

        private void textBoxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelError.Text = string.Empty;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void BindCategory()
        {
            string[] category = {
                "Personal", "Friends", "Family", "Office", "Business", "Others"
            };
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(category);
            comboBoxCategory.SelectedIndex = 0;
        }

        private void btnAddResponsibility_Click(object sender, EventArgs e)
        {
            if (tbResponsibilityName.Text != "" && CheckResponsibilityName(tbResponsibilityName.Text))
            {
                EventResponsibility addedResponsibility = new EventResponsibility
                {
                    Name = tbResponsibilityName.Text,
                };
                _newEventResponsibilities.Add(addedResponsibility);

                List<EventResponsibility> allEventResponsibilities = new List<EventResponsibility>();
                allEventResponsibilities.AddRange(_eventResponsibilities);
                allEventResponsibilities.AddRange(_newEventResponsibilities);
                try
                {
                    dgvResponsibilities.DataSource = allEventResponsibilities;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                tbResponsibilityName.Text = "";
            }
            else if (!CheckResponsibilityName(tbResponsibilityName.Text))
            {
                labelError.Text = "A responsibility with that name already exists";
            }
            else
            {
                labelError.Text = "Responsibility name cannot be blank";
            }
        }

        private bool CheckResponsibilityName(string name)
        {
            foreach (EventResponsibility eventResponsibility in _eventResponsibilities)
            {
                if (eventResponsibility.Name == name) { return false; }
            }

            foreach (EventResponsibility eventResponsibility in _newEventResponsibilities)
            {
                if (eventResponsibility.Name == name) { return false; }
            }

            return true;
        }

        private void tbResponsibilityName_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }
    }
}