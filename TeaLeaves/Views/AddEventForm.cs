
using TeaLeaves.Controllers;
using TeaLeaves.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeaLeaves.Views
{
    public partial class AddEventForm : Form
    {
        private EventController _eventController;
        private Event _event;
        private User _user;
        public AddEventForm(User verifiedUser)
        {
            InitializeComponent();
            _eventController = new EventController();
            _event = new Event();
            _user = verifiedUser;
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMinute.Value = DateTime.Now.Minute;

            BindState();

        }


        private void BindState()
        {
            string[] states = {
    "Online", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida",
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
            else if (eventTime < DateTime.Now)
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
                _event.UserId = _user.UserId;
                _event.Name = textBoxEName.Text.Trim();
                _event.StreetNumber = textBoxStreetName.Text.Trim();
                _event.State =comboBoxState.SelectedItem.ToString();
                _event.City = textBoxCity.Text.Trim();
                _event.Description = richTextBoxDescription.Text.Trim();
                //_event.Zipcode = textBoxZip.Text.Trim();
                _event.EventDateTime = dateTimePickerEvent.Value.Date + new TimeSpan(Convert.ToInt16(numericUpDownHour.Value), Convert.ToInt16(numericUpDownMinute.Value), 0);
                try
                {
                    if (_eventController.SaveEvent(_event))
                    {
                        labelError.Text = "Event has been saved";
                        Close();
                    }
                    else
                    {
                        labelError.Text = "Failed to save event, re-open page and try again";
                    }
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
            string zipCode = textBoxZip.Text.Trim();

            if (zipCode.Length != 5)
            {
                labelError.Text = "Invalid ZIP code. Please enter a 5-digit number.";
            }
            else
            {
                labelError.Text = string.Empty;
                _event.Zipcode = int.Parse(zipCode);
            }
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