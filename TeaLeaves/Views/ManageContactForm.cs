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
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// public class creating the form used to manage contacts
    /// </summary>
    public partial class ManageContactForm : Form
    {
        private List<Users> _ContactList;
        private Users _user;
        private UserControl _userControl;
        private ContactsController _contactsController;

        /// <summary>
        /// constructor for the ManageContactForm
        /// </summary>
        public ManageContactForm(Users user)
        {
            this._user = user;
            this._contactsController = new ContactsController();
            InitializeComponent();
        }

        private void ManageContactForm_Load(object sender, EventArgs e)
        {
            this._ContactList = this._contactsController.getUsersContacts(this._user);
            this.usersBindingSource.DataSource = this._ContactList;
        }

        private void contactDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Users selectedContact = this._ContactList[e.RowIndex];

            this.firstNameText.Text = selectedContact.FirstName;
            this.lastNameText.Text = selectedContact.LastName;
            this.usernameText.Text = selectedContact.Username;
            this.emailText.Text = selectedContact.Email;
        }

    }
}
