using Microsoft.VisualBasic.ApplicationServices;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.UserControls
{
    public partial class ucEventInvites : UserControl
    {
        EventResponseController _eventResponseController;
        List<Event> _events;

        public ucEventInvites()
        {
            InitializeComponent();
            _eventResponseController = new EventResponseController();
            _events = new List<Event>();
        }

        //CurrentUserStore.User

        private void GetUserEvents()
        {
            //try
            //{
            //    _events = _eventResponseController.GetEventResponses(CurrentUserStore.User.UserId)
            //    lblPatientName.Text = $"{_user.FirstName} {_user.LastName}";

            //    dgAppointments.DataSource = _appointments;

            //    if (dgAppointments.Rows.Count > 0)
            //    {
            //        dgAppointments.Rows[0].Selected = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ex.GetType().ToString());
            //}
        }
    }
}
