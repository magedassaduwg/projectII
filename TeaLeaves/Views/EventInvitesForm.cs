﻿using TeaLeaves.Controllers;
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
            GetUserEvents();
        }

        private void GetUserEvents()
        {
            try
            {
                //_invitedUsers = _contactsController.GetUsersContacts(CurrentUserStore.User);
                _invitedUsers = _contactsController.GetUsersContactsByEvent(CurrentUserStore.User, _event);

                dgvInvitedContacts.DataSource = _invitedUsers;

                //_uninvitedUsers = _contactsController.GetUsersContacts(CurrentUserStore.User);
                _uninvitedUsers = _contactsController.GetUsersContactsNotInvitedByEvent(CurrentUserStore.User, _event);

                dgvUninvitedContacts.DataSource = _uninvitedUsers;

                //if (dgvEventInvites.Rows.Count > 0)
                //{
                //    dgvEventInvites.Rows[0].Selected = true;
                //}
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
