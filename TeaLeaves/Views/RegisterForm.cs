using Microsoft.VisualBasic.Logging;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Views
{
    /// <summary>
    /// The form used for registering as a user
    /// </summary>
    public partial class RegisterForm : Form
    {
        private LoginForm _loginForm;
        private UsersController _usersController;

        /// <summary>
        /// The constructor for the Register user form
        /// </summary>
        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            _usersController = new UsersController();
            _loginForm = loginForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool lastNameValid = true;
            bool firstNameValid = true;
            bool emailValid = true;
            bool usernameValid = true;
            bool passwordValid = true;
            bool passwordConfirmValid = true;

            string lastName = this.tbLastName.Text;
            if (lastName == null || lastName == "")
            {
                lastNameValid = false;
                lblLastNameError.Text = "Please enter a valid last name";
            }

            string firstName = this.tbFirstName.Text;
            if (firstName == null || firstName == "")
            {
                firstNameValid = false;
                lblFirstNameError.Text = "Please enter a valid first name";
            }

            string email = this.tbEmail.Text;
            if (email == null || email == "")
            {
                emailValid = false;
                lblEmailError.Text = "Please enter a valid email";
            }

            string username = this.tbUsername.Text;
            if (username == null || username == "")
            {
                usernameValid = false;
                lblUsernameError.Text = "Please enter a valid username";
            }

            string password = this.tbPassword.Text;
            if (password == null || password == "")
            {
                passwordValid = false;
                lblPasswordError.Text = "Please enter a valid password";
            }

            string passwordConfirm = this.tbPasswordConfirm.Text;
            if (passwordConfirm != password)
            {
                passwordValid = false;
                lblPasswordConfirmError.Text = "Passwords must match";
            }

            if (!lastNameValid || !firstNameValid || !emailValid || !usernameValid || !passwordValid || !passwordConfirmValid)
            {
                return;
            }
            else
            {
                User user = new User();
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Email = email;
                user.Username = username;
                user.Password = EncryptionHelper.EncryptString(password);

                try
                {
                    this._usersController.Add(user);
                    this.lblMessage.ForeColor = Color.Black;
                    Clear();
                    this.lblMessage.Text = "The patient has been registered.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The input is invalid." + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbPasswordConfirm.Text = string.Empty;

            lblFirstNameError.Text = string.Empty;
            lblLastNameError.Text = string.Empty;
            lblEmailError.Text = string.Empty;
            lblUsernameError.Text = string.Empty;
            lblPasswordError.Text = string.Empty;
            lblPasswordConfirmError.Text = string.Empty;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnToLoginForm();
        }

        private void lklblReturnToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnToLoginForm();
        }

        private void ReturnToLoginForm()
        {
            _loginForm.Logout();
            Hide();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFirstNameError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastNameError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsernameError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswordError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void tbPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            lblPasswordConfirmError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            _loginForm.Hide();
        }

        private void tlpRegisterForm_Paint(object sender, PaintEventArgs e)
        {

        }



        private void buttonLoginBack_Click(object sender, EventArgs e)
        {
            ReturnToLoginForm();
        }
    }
}
