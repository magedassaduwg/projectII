using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.UserControls
{
    public partial class ucEventInvites : UserControl
    {
        EventController _eventController;
        List<Event> _events;
        List<Event> _eventsAccepted;

        public ucEventInvites()
        {
            InitializeComponent();
            _eventController = new EventController();
            _events = new List<Event>();
            _eventsAccepted = new List<Event>();
            dgvEventInvites.AutoGenerateColumns = false;
            dgvAcceptedInvites.AutoGenerateColumns = false;
        }

        private void GetUserEvents()
        {
            try
            {
                _events = _eventController.GetEventsReceivedByUserId(CurrentUserStore.User.UserId);

                dgvEventInvites.DataSource = _events;

                _eventsAccepted = _eventController.GetAcceptedEventsReceivedByUserId(CurrentUserStore.User.UserId);

                if (dgvEventInvites.Rows.Count > 0)
                {
                    dgvEventInvites.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetUserEvents();
        }

        private void ucEventInvites_Load(object sender, EventArgs e)
        {
            GetUserEvents();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
