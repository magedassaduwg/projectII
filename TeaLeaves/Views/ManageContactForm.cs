using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        /// <summary>
        /// constructor for the ManageContactForm
        /// </summary>
        public ManageContactForm(Users user)
        {
            this._user = user;
            InitializeComponent();
        }

        private void ManageContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
