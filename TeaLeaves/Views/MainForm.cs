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
    public partial class MainForm : Form
    {
        private Users user;
        public MainForm(Users verifiedUser)
        {
            this.user = verifiedUser;
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void manageContactsButton_Click(object sender, EventArgs e)
        {
            ManageContactForm manageContactForm = new ManageContactForm(this.user);
            manageContactForm.Show();
            this.Hide();
        }
    }
}
