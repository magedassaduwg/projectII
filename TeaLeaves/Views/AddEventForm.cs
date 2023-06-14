using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    public partial class AddEventForm : Form
    {
        private EventController _eventController;
        private Event _event;


        public AddEventForm(Event selectedEvent)
        {
            InitializeComponent();
            _eventController = new EventController();
            _event = selectedEvent ?? new Event();
            BindEventValue();

        }
        private void BindEventValue()
        {

            textBoxEName.Text = _event.EventName;
            textBoxStreetName.Text=_event.StreetNumber;
            textBoxCity.Text = _event.City;
            comboBoxState.Text = _event.State;
            textBoxZip.Text = string.Empty;
            richTextBoxDescription.Text = _event.Description;
            if (_event.Id > 0)
            {
                dateTimePickerEvent.Value = _event.EventDateTime;
                numericUpDownHour.Value = _event.EventDateTime.Hour;
                numericUpDownMinute.Value = _event.EventDateTime.Minute;
                textBoxZip.Text = _event.Zipcode.ToString();
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


            BindState();
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
                    _eventController.SaveEvent(_event);
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
                e.Handled = true; // Suppress the non-numeric key press
            }
        }


    }
}