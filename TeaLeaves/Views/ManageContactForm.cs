using System;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// public class creating the form used to manage contacts
    /// </summary>
    public partial class ManageContactForm : Form
    {
        private List<User> _contactList;
        private UsersController _userControl;
        private ContactsController _contactsController;
        private User selectedContact;
        private bool hasBeenSorted;

        /// <summary>
        /// constructor for the ManageContactForm
        /// </summary>
        public ManageContactForm()
        {
            this._contactsController = new ContactsController();
            this._userControl = new UsersController();
            this.hasBeenSorted = false;
            InitializeComponent();
        }

        private void ManageContactForm_Load(object sender, EventArgs e)
        {
            contactDataGridView.AutoGenerateColumns = false;
            this.refreshContactList();
        }

        private void contactDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this._contactList.Any())
            {
                User selectedContact = this._contactList[e.RowIndex];

                this.firstNameText.Text = selectedContact.FirstName;
                this.lastNameText.Text = selectedContact.LastName;
                this.usernameText.Text = selectedContact.Username;
                this.emailText.Text = selectedContact.Email;
                if (selectedContact != null)
                {
                    selectedContact.ProfilePicture = this._userControl.GetUserProfilePicture(selectedContact.UserId);
                    this.userProfilePictureBox.Image = selectedContact.ProfilePicture;
                }
                this.deleteButton.Enabled = true;
                this.viewProfileButton.Enabled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            User contactToBeRemoved = this._contactList.Find(User => User.Email == this.emailText.Text);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this._contactsController.RemoveContact(CurrentUserStore.User, contactToBeRemoved);
                this._contactList = this._contactsController.GetUsersContacts(CurrentUserStore.User);
                this.usersBindingSource.DataSource = this._contactList;
                this.firstNameText.Text = String.Empty;
                this.lastNameText.Text = String.Empty;
                this.usernameText.Text = String.Empty;
                this.emailText.Text = String.Empty;
            }
            this.refreshContactList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddContactForm contactForm = new AddContactForm(this._contactList))
            {
                contactForm.ShowDialog();
                this.refreshContactList();
            }
        }

        private void refreshContactList()
        {
            this._contactList = this._contactsController.GetUsersContacts(CurrentUserStore.User);
            this.usersBindingSource.DataSource = this._contactList;
            if (this._contactList.Any())
            {
                contactDataGridView.DataSource = this._contactList;
                this.selectedContact = this._contactList[0];
            }
            else
            {
                this.deleteButton.Enabled = false;
                this.viewProfileButton.Enabled = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            User contactToBeViewed = this._contactList.Find(User => User.Email == this.emailText.Text);

            using (ProfileForm profileForm = new ProfileForm(contactToBeViewed))
            {
                profileForm.ShowDialog();
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (this._contactList.Any() && this.hasBeenSorted == false)
            {
                IEnumerable<User> orderedByFirstName = this._contactList.OrderBy(user => user.LastName);
                this._contactList = orderedByFirstName.ToList();
                this.contactDataGridView.DataSource = this._contactList;
                this.selectedContact = this._contactList[0];
                this.hasBeenSorted = true;
            }
            else if (this._contactList.Any() && this.hasBeenSorted == true)
            {
                this._contactList.Reverse();
                this.contactDataGridView.DataSource = this._contactList;
                this.selectedContact = this._contactList[0];
                this.contactDataGridView.Refresh();
                this.hasBeenSorted = false;
            }

        }
    }
}
