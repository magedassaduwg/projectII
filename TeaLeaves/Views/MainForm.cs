using TeaLeaves.Helper;

namespace TeaLeaves.Views
{
    public partial class MainForm : Form
    {
        private bool _isManulClose = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MessageForm chatForm = new MessageForm())
            {
                chatForm.ShowDialog();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isManulClose)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = $"Welcome {CurrentUserStore.User.FullName}";
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUserStore.Logout();
            _isManulClose = true;
            Close();
        }
    }
}
