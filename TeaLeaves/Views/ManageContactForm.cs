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
        private Users selectedContact;

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
            if (this._ContactList.Any())
            {
                this.selectedContact = this._ContactList[0];
            }
        }

        private void contactDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Users selectedContact = this._ContactList[e.RowIndex];

            this.firstNameText.Text = selectedContact.FirstName;
            this.lastNameText.Text = selectedContact.LastName;
            this.usernameText.Text = selectedContact.Username;
            this.emailText.Text = selectedContact.Email;
            this.deleteButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this._contactsController.removeContact(this._user, this.selectedContact);
                this._ContactList = this._contactsController.getUsersContacts(_user);
                this.usersBindingSource.DataSource = this._ContactList;
                this.firstNameText.Text = String.Empty;
                this.lastNameText.Text = String.Empty;
                this.usernameText.Text = String.Empty;
                this.emailText.Text = String.Empty;
            }

        }
    }
}
