using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form for viewing events with start dates which have passed
    /// </summary>
    public partial class ViewPastEventsForm : Form
    {
        EventController _eventController;
        List<Event> _events;

        /// <summary>
        /// Initializes a new instance of the ucEventInvities
        /// </summary>
        public ViewPastEventsForm()
        {
            InitializeComponent();
            _eventController = new EventController();
            _events = new List<Event>();
            dgvEventInvites.AutoGenerateColumns = false;
            GetUserEvents();
        }

        private void GetUserEvents()
        {
            try
            {
                _events = _eventController.GetPastEventsReceivedByUserId(CurrentUserStore.User.UserId);

                dgvEventInvites.DataSource = _events;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
