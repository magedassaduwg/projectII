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

namespace TeaLeaves.Views
{
    /// <summary>
    /// class creating a small box to search for and add a contact
    /// </summary>
    public partial class AddContactForm : Form
    {
        private ContactsController _contactsController;

        /// <summary>
        /// constructor
        /// </summary>
        public AddContactForm()
        {
            this._contactsController = new ContactsController();
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string contactUsername = this.contactTextBox.Text.Trim();
            
            if (!this._contactsController.AddContact(CurrentUserStore.User, contactUsername))
            {
                MessageBox.Show("We're sorry, but a user with that email doesn't exist.", "User Not Found", MessageBoxButtons.OK); 
            } else
            {
                MessageBox.Show("Contact Added!", "Contact Added!", MessageBoxButtons.OK);
            }

        }
    }
}
