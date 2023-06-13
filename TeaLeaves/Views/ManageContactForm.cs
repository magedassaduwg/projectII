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
        private UserControl _userControl;
        private ContactsController _contactsController;
        private User selectedContact;

        /// <summary>
        /// constructor for the ManageContactForm
        /// </summary>
        public ManageContactForm()
        {
            this._contactsController = new ContactsController();
            InitializeComponent();
        }

        private void ManageContactForm_Load(object sender, EventArgs e)
        {
            this.refreshContactList();
        }

        private void contactDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            User selectedContact = this._contactList[e.RowIndex];

            this.firstNameText.Text = selectedContact.FirstName;
            this.lastNameText.Text = selectedContact.LastName;
            this.usernameText.Text = selectedContact.Username;
            this.emailText.Text = selectedContact.Email;
            this.deleteButton.Enabled = true;
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

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddContactForm contactForm = new AddContactForm())
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
                this.selectedContact = this._contactList[0];
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
    }
}
