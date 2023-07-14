using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// Represents a form for managing event invites.
    /// </summary>
    public partial class EventInvitesForm : Form
    {
        ContactsController _contactsController;
        EventResponseController _eventResponseController;
        List<User> _invitedUsers;
        List<User> _uninvitedUsers;
        List<User> _acceptedUsers;
        List<User> _declinedUsers;
        Event _event;

        /// <summary>
        /// Initializes a new instance of the EventInvitesForm
        /// </summary>
        /// <param name="event">The event for which invites are being managed.</param>
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
            dgvAcceptedContacts.AutoGenerateColumns = false;
            dgvDeclinedContacts.AutoGenerateColumns = false;
            GetUserEvents();
        }

        private void GetUserEvents()
        {
            lblEventDetails.Text = _event.EventName + " " + _event.EventDateTime;
            try
            {
                _invitedUsers = _contactsController.GetUsersContactsByEvent(CurrentUserStore.User, _event);

                dgvInvitedContacts.DataSource = _invitedUsers;

                _uninvitedUsers = _contactsController.GetUsersContactsNotInvitedByEvent(CurrentUserStore.User, _event);

                dgvUninvitedContacts.DataSource = _uninvitedUsers;

                _acceptedUsers = _contactsController.GetAcceptedUsersContactsByEvent(CurrentUserStore.User, _event);

                dgvAcceptedContacts.DataSource = _acceptedUsers;

                _declinedUsers = _contactsController.GetDeclinedUsersContactsByEvent(CurrentUserStore.User, _event);

                dgvDeclinedContacts.DataSource = _declinedUsers;

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
            if (dgvUninvitedContacts.Rows.Count > 0)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
