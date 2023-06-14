using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    public partial class EventInvitesForm : Form
    {
        ContactsController _contactsController;
        EventResponseController _eventResponseController;
        List<User> _invitedUsers;
        List<User> _uninvitedUsers;
        Event _event;

        public EventInvitesForm(Event @event)
        {
            InitializeComponent();
            _contactsController = new ContactsController();
            _eventResponseController = new EventResponseController();
            _invitedUsers = new List<User>();
            _uninvitedUsers = new List<User>();
            _event = @event;
            dgvInvitedContacts.AutoGenerateColumns = false;
            dgvUninvitedContacts.AutoGenerateColumns = false;
            GetUserEvents();
        }

        private void GetUserEvents()
        {
            try
            {
                _invitedUsers = _contactsController.GetUsersContactsByEvent(CurrentUserStore.User, _event);

                dgvInvitedContacts.DataSource = _invitedUsers;

                _uninvitedUsers = _contactsController.GetUsersContactsNotInvitedByEvent(CurrentUserStore.User, _event);

                dgvUninvitedContacts.DataSource = _uninvitedUsers;

                if (dgvUninvitedContacts.Rows.Count > 0)
                {
                    dgvUninvitedContacts.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)dgvUninvitedContacts.SelectedRows[0].DataBoundItem;
            EventResponse eventResponse = new EventResponse();
            eventResponse.InviterId = CurrentUserStore.User.UserId;
            eventResponse.ReceiverId = selectedUser.UserId;
            eventResponse.Accepted = false;
            eventResponse.EventId = _event.Id;
            _eventResponseController.AddEventResponse(eventResponse);
            GetUserEvents();
        }
    }
}
