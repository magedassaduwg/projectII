using System.Data;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;

namespace TeaLeaves.Views
{
    public partial class ProfileContactBookForm : Form
    {
        private Models.User viewedUser;
        private ContactsController _contactsController;
        private UsersController _userController;
        private List<Models.User> _contactList;
        private Models.User selectedContact;
        private bool hasBeenSorted;

        public ProfileContactBookForm(Models.User user)
        {
            this._userController = new UsersController();
            this._contactsController = new ContactsController();
            this.viewedUser = user;
            this.hasBeenSorted = false;
            InitializeComponent();
        }

        private void refreshContactList()
        {
            this._contactList = this._contactsController.GetUsersContacts(this.viewedUser);
            this.usersBindingSource.DataSource = this._contactList;
            if (this._contactList.Any())
            {
                contactDataGridView.DataSource = this._contactList;
                this.selectedContact = this._contactList[0];
            }
            else
            {
                this.viewProfileButton.Enabled = false;
            }
        }

        private void ProfileContactBookForm_Load(object sender, EventArgs e)
        {
            contactDataGridView.AutoGenerateColumns = false;
            this.refreshContactList();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (this._contactList.Any() && this.hasBeenSorted == false)
            {
                IEnumerable<Models.User> orderedByFirstName = this._contactList.OrderBy(user => user.LastName);
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

        private void addContactButton_Click(object sender, EventArgs e)
        {
            List<Models.User> usersContactList = this._contactsController.GetUsersContacts(CurrentUserStore.User);
            string contactEmail = this.emailText.Text;

            foreach (Models.User contact in usersContactList)
            {
                if (contact.Email == contactEmail)
                {
                    MessageBox.Show("You already have that user as a contact!", "Duplicate Contact", MessageBoxButtons.OK);
                    return;
                }
            }

            if (!this._contactsController.AddContact(CurrentUserStore.User, contactEmail))
            {
                MessageBox.Show("We're sorry, but a user with that email doesn't exist.", "User Not Found", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Contact Added!", "Contact Added!", MessageBoxButtons.OK);
            }
        }

        private void contactDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this._contactList.Any())
            {
                Models.User selectedContact = this._contactList[e.RowIndex];

                this.firstNameText.Text = selectedContact.FirstName;
                this.lastNameText.Text = selectedContact.LastName;
                this.usernameText.Text = selectedContact.Username;
                this.emailText.Text = selectedContact.Email;
                if (selectedContact != null)
                {
                    selectedContact.ProfilePicture = this._userController.GetUserProfilePicture(selectedContact.UserId);
                    this.userProfilePictureBox.Image = selectedContact.ProfilePicture;
                }
                this.viewProfileButton.Enabled = true;
            }
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            Models.User contactToBeViewed = this._contactList.Find(User => User.Email == this.emailText.Text);

            using (ProfileForm profileForm = new ProfileForm(contactToBeViewed))
            {
                profileForm.ShowDialog();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// code attempting to make only the rows of contacts that have not been added by the user b

        private void contactDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*List<Models.User> usersContactList = this._contactsController.GetUsersContacts(CurrentUserStore.User);

            foreach (Models.User contact in this._contactList)
            {
                try
                {
                    if (usersContactList.Find(User => User.Email == this.emailText.Text) != null)
                    {

                    }
                    else
                    {
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                }
                catch (Exception)
                {

                }

            }*/
        }
    }
}
