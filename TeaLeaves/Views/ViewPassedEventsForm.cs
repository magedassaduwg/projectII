using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    public partial class ViewPassedEventsForm : Form
    {
        EventController _eventController;
        List<Event> _events;

        /// <summary>
        /// Initializes a new instance of the ucEventInvities
        /// </summary>
        public ViewPassedEventsForm()
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
                _events = _eventController.GetEventsReceivedByUserId(CurrentUserStore.User.UserId);

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
