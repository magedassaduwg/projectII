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
    public partial class ProfileForm : Form
    {
        private UsersController _userController;
        private Models.User viewedUser;
        public ProfileForm(Models.User selectedUser)
        {
            this._userController = new UsersController();

            if (selectedUser.UserId == CurrentUserStore.User.UserId)
            {
                this.viewedUser = CurrentUserStore.User;
                this.editButton.Visible = true;
                this.editButton.Enabled = true;
            }
            else
            {
                this.viewedUser = selectedUser;
            }

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
    }
}
