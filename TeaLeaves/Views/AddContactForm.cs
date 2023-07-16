using TeaLeaves.Controllers;
using TeaLeaves.Helper;

namespace TeaLeaves.Views
{
    /// <summary>
    /// class creating a small box to search for and add a contact
    /// </summary>
    public partial class AddContactForm : Form
    {
        private BlockedController _blockedController;
        private ContactsController _contactsController;
        private List<Models.User> _contacts;
        /// <summary>
        /// constructor
        /// </summary>
        public AddContactForm(List<Models.User> listOfContacts)
        {
            this._blockedController = new BlockedController();
            this._contactsController = new ContactsController();
            this._contacts = listOfContacts;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string contactEmail = this.contactTextBox.Text.Trim();
            foreach (Models.User contact in this._contacts)
            {
                if (contact.Email == contactEmail)
                {
                    MessageBox.Show("You already have that user as a contact!", "Duplicate Contact", MessageBoxButtons.OK);
                    return;
                }
            }
            if (this._blockedController.IsUserEmailBlocked(contactEmail))
            {
                MessageBox.Show("We're sorry, but that user is unavailable.", "User Not Found", MessageBoxButtons.OK);
                return;
            }

            if (!this._contactsController.AddContact(CurrentUserStore.User, contactEmail))
            {
                MessageBox.Show("We're sorry, but a user with that email doesn't exist.", "User Not Found", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Contact Added!", "Contact Added!", MessageBoxButtons.OK);
                contactTextBox.Clear();
                Close();
            }
        }
    }
}
