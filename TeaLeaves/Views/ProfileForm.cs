using TeaLeaves.Controllers;
using TeaLeaves.Helper;

namespace TeaLeaves.Views
{
    /// <summary>
    /// Represents a form for viewing and editing user profiles.
    /// </summary>
    public partial class ProfileForm : Form
    {
        private UsersController _userController;
        private Models.User viewedUser;

        public ProfileForm()
        {
            this._userController = new UsersController();
            this.viewedUser = CurrentUserStore.User;
            InitializeComponent();

            this.editButton.Visible = true;
            this.editButton.Enabled = true;

            this.viewedUser.Blurb = this._userController.GetUserBlurb(this.viewedUser.UserId);
            this.viewedUser.ProfilePicture = this._userController.GetUserProfilePicture(this.viewedUser.UserId);

        }
        /// <summary>
        /// Initializes a new instance of the ProfileForm class
        /// </summary>
        /// <param name="selectedUser">The user whose profile is being viewed.</param>
        public ProfileForm(Models.User selectedUser)
        {
            this._userController = new UsersController();

            this.viewedUser = selectedUser;

            this.viewedUser.Blurb = this._userController.GetUserBlurb(this.viewedUser.UserId);
            this.viewedUser.ProfilePicture = this._userController.GetUserProfilePicture(this.viewedUser.UserId);

            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.userBlurbBox.ReadOnly = false;
            this.saveButton.Enabled = true;
            this.saveButton.Visible = true;
            this.uploadButton.Enabled = true;
            this.uploadButton.Visible = true;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            /// add code to load picture from database if it exists
            if (this.viewedUser.ProfilePicture != null)
            {
                this.userProfilePictureBox.Image = this.viewedUser.ProfilePicture;
            }
            this.userBlurbBox.Text = this.viewedUser.Blurb;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.viewedUser.Blurb = this.userBlurbBox.Text;
            this._userController.SetUserBlurb(this.viewedUser);
            this._userController.UploadProfilePicture(this.viewedUser);
            this.saveButton.Enabled = false;
            this.saveButton.Visible = false;
            this.uploadButton.Visible = false;
            this.uploadButton.Enabled = false;
            this.userBlurbBox.ReadOnly = true;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.viewedUser.ProfilePicture = Image.FromFile((open.FileName));
                this.userProfilePictureBox.Image = viewedUser.ProfilePicture;
            }
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            double[] userStats = this._userController.GetUserStats(this.viewedUser.UserId);

            MessageBox.Show("Out of a total of " + userStats[1].ToString() + " invites, this user's contacts, on average accept invites " +
                userStats[0].ToString() +
                "% of the time.", "User Statistics", MessageBoxButtons.OK);
        }

        private void friendListButton_Click(object sender, EventArgs e)
        {
            using (ProfileContactBookForm contactBookForm = new ProfileContactBookForm(this.viewedUser))
            {
                contactBookForm.ShowDialog();
            }
        }
    }
}
