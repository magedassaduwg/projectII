using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves
{
    public partial class LoginForm : Form
    {
        private UsersController _userController;
        private User _userLogin;
        public LoginForm()
        {
            InitializeComponent();
            _userController = new UsersController();
            _userLogin = new User();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            _userLogin.Password = textBoxUsername.Text;
            lblError.Text = string.Empty;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            _userLogin.Password = textBoxPassword.Text;
            lblError.Text = string.Empty;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _userLogin.Username = textBoxUsername.Text.Trim();
                // commented out until password encryption is implemented with user registration
                //_userLogin.Password = EncryptionHelper.EncryptString(_userLogin.Password);
                _userLogin.Password = textBoxPassword.Text.Trim();

                User verifiedUser = _userController.VerifyUserCredentials(_userLogin);
                if (verifiedUser != null)
                {
                    CurrentUserStore.SetCurrentUser(verifiedUser);

                    // MainForm mainForm = new MainForm(verifiedUser);

                    using (MainForm mainForm = new MainForm())
                        mainForm.ShowDialog();
                    //this.Hide();
                }
                else
                {
                    lblError.Text = "Invalid username/password.Please try again!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegisterForm registerForm = new RegisterForm(this))
            {
                registerForm.ShowDialog();
            }
        }

        /// <summary>
        /// Clears the textbox values
        /// </summary>
        public void Logout()
        {
            Show();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}