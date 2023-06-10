
using MassTransit.Logging;
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
            DateTime newAvailableTime = (DateTime.Now);

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
              //  _event.Zipcode = textBoxZip.Text.Trim();
                _event.Description = richTextBoxDescription.Text.Trim();
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
            int selectedMinute = (int)numericUpDownMinute.Value;

            if (selectedMinute != 0 && selectedMinute != 15 && selectedMinute != 30 && selectedMinute != 45)
            {

                if (selectedMinute < 15)
                {
                    numericUpDownMinute.Value = 0;
                }
                else if (selectedMinute < 30)
                {
                    numericUpDownMinute.Value = 15;
                }
                else if (selectedMinute < 45)
                {
                    numericUpDownMinute.Value = 30;
                }
                else if (selectedMinute < 60)
                {
                    numericUpDownMinute.Value = 45;
                }
            }
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
            if (!int.TryParse(textBoxZip.Text.Trim(), out int zipcode))
            {
                labelError.Text = "Invalid ZIP code";
            }
            else
            {
                _event.Zipcode = zipcode;
            }
        }

    }
}
