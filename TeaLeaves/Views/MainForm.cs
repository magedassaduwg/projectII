using TeaLeaves.Helper;

namespace TeaLeaves.Views
{
    /// <summary>
    /// Represents the main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private bool _isManulClose = false;
        /// <summary>
        /// Initializes a new instance of the MainForm.
        /// </summary>
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            CurrentUserStore.Logout();
            _isManulClose = true;
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (ManageContactForm contactForm = new ManageContactForm())
            {
                contactForm.ShowDialog();
            }
        }

        private void yourProfileButton_Click(object sender, EventArgs e)
        {
            using (ProfileForm profileForm = new ProfileForm())
            {
                profileForm.ShowDialog();
            }
        }
    }
}
