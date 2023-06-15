using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// Form for viewing the details of a given event from the user's event invite list
    /// </summary>
    public partial class ViewEventForm : Form
    {
        Event _event;

        /// <summary>
        /// The constructor for the ViewEventForm class
        /// </summary>
        /// <param name="event"></param>
        public ViewEventForm(Event @event)
        {
            InitializeComponent();
            _event = @event;
        }

        private void ViewEventForm_Load(object sender, EventArgs e)
        {
            tbName.Text = _event.EventName;
            if (_event.City != "" && _event.StreetNumber != "")
            {
                tbAddress.Text = _event.StreetNumber + ", " + _event.City + ", " + _event.State + " " + _event.Zipcode;
            }
            string[] dateAndTimeStrings = _event.EventDateTime.ToString().Split(" ");
            tbDate.Text = dateAndTimeStrings[0];
            tbTime.Text = dateAndTimeStrings[1];
            tbDescription.Text = _event.Description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
