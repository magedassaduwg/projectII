using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;
using TeaLeaves.Views;

namespace TeaLeaves
{
    /// <summary>
    /// Represents the login form for user authentication.
    /// </summary>
    public partial class LoginForm : Form
    {
        private UsersController _userController;
        private User _userLogin;
        private bool _rememberMe;


        /// <summary>
        /// Initializes a new instance of the LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            _userController = new UsersController();
            _userLogin = new User();
            _rememberMe = false;
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
                if (_rememberMe)
                {
                    LoginHelper.SaveCredentials(_userLogin.Username, _userLogin.Password);
                    _userLogin.Password = EncryptionHelper.EncryptString(_userLogin.Password);

                }
                User verifiedUser = _userController.VerifyUserCredentials(_userLogin);
                if (verifiedUser != null)
                {
              

                    CurrentUserStore.SetCurrentUser(verifiedUser);

                    // MainForm mainForm = new MainForm(verifiedUser);

                    using (MainForm mainForm = new MainForm())
                    {
                        Hide();
                        mainForm.ShowDialog();
                    }

                    textBoxPassword.Text = string.Empty;
                    Show();
                    if (_rememberMe)
                    {
                        (string username, string password) = LoginHelper.LoadCredentials();
                        textBoxUsername.Text = username;
                        textBoxPassword.Text = password;
                    }
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

        /// <summary>
        /// Clears the textbox values
        /// </summary>
        public void Logout()
        {
            Show();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxPassword.Focus();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            using (RegisterForm registerForm = new RegisterForm(this))
            {
                registerForm.ShowDialog();
            }
        }

        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            _rememberMe = rememberMe.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            rememberMe.Checked = _rememberMe;
           
        }
    }
}