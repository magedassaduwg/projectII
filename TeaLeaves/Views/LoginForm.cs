using TeaLeaves.Models;
using TeaLeaves.Controllers;
using TeaLeaves.Views;
using TeaLeaves.Helper;

namespace TeaLeaves
{
    public partial class LoginForm : Form
    {
        private UsersController _userController;
        private Users _userLogin;
        public LoginForm()
        {
            InitializeComponent();
            _userController = new UsersController();
            _userLogin = new Users();
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
                _userLogin.Password = EncryptionHelper.EncryptString(_userLogin.Password);

                Users verifiedUser = _userController.VerifyUserCredentials(_userLogin);
                if (verifiedUser != null)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
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