
using MassTransit.Logging;
using TeaLeaves.Controllers;
using TeaLeaves.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeaLeaves.Views
{
    public partial class EventsForm : Form
    {
        private EventController _eventController;
        private Event _event;
        public EventsForm()
        {
            InitializeComponent();
            _eventController = new EventController();
            _event = new Event();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            DateTime newAvailableTime = CalculateNextAvailableTime(DateTime.Now);
            BindState();

        }

        private DateTime CalculateNextAvailableTime(DateTime baseTime)
        {
            DateTime nextAvailable;

            if (baseTime.Minute == 0)
            {
                nextAvailable = baseTime;
            }
            else if (baseTime.Minute > 0 & baseTime.Minute <= 15)
            {
                nextAvailable = baseTime.AddMinutes(15 - baseTime.Minute);
            }
            else if (baseTime.Minute >= 16 & baseTime.Minute <= 30)
            {
                nextAvailable = baseTime.AddMinutes(30 - baseTime.Minute);
            }
            else if (baseTime.Minute >= 31 & baseTime.Minute <= 45)
            {
                nextAvailable = baseTime.AddMinutes(45 - baseTime.Minute);
            }
            else
            {
                nextAvailable = baseTime.AddMinutes(60 - baseTime.Minute);
            }

            return nextAvailable;
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

            if (eventTime < DateTime.Now)
            {
                labelError.Text = "Please choose a future time";
                return false;
            }
            else if (textBoxEName.Text.Trim().Length == 0)
            {
                labelError.Text = "Please enter the event name";
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;

            if (IsFormValid())
            {
                _event.Name = textBoxEName.Text.Trim();
                _event.StreetNumber = textBoxStreetName.Text.Trim();
                _event.State =comboBoxState.SelectedItem.ToString();
                _event.City = textBoxCity.Text.Trim();
                _event.Description = richTextBoxDescription.Text.Trim();
                _event.DateTime = dateTimePickerEvent.Value.Date + new TimeSpan(Convert.ToInt16(numericUpDownHour.Value), Convert.ToInt16(numericUpDownMinute.Value), 0);
                try
                {
                    if (_eventController.SaveEvent(_event))
                    {
                        labelError.Text = "Event has been saved";
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
    }
}
