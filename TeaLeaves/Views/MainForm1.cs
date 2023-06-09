using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    public partial class MainForm1 : Form
    {
        private User user;
        public MainForm1(User verifiedUser)
        {
            this.user = verifiedUser;
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void manageContactsButton_Click(object sender, EventArgs e)
        {
            using (ManageContactForm manageContactForm = new ManageContactForm())
            {
                manageContactForm.ShowDialog();
            }
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            using (MessageForm chatForm = new MessageForm())
            {
                chatForm.ShowDialog();
            }
        }
    }
}
