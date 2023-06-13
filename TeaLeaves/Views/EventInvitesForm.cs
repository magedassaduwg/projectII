using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    public partial class EventInvitesForm : Form
    {
        ContactsController _contactsController;
        List<User> _invitedUsers;
        List<User> _uninvitedUsers;
        Event _event;

        public EventInvitesForm(Event @event)
        {
            InitializeComponent();
            _contactsController = new ContactsController();
            _invitedUsers = new List<User>();
            _uninvitedUsers = new List<User>();
            _event = @event;
        }

        private void GetUserEvents()
        {
            try
            {
                _invitedUsers = _contactsController.GetUsersContactsByEvent(CurrentUserStore.User, _event);

                dgvInvitedContacts.DataSource = _invitedUsers;

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

        }
    }
}
