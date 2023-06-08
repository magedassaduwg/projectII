namespace TeaLeaves.Views
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpRegisterForm = new TableLayoutPanel();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbPasswordConfirm = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblPasswordConfirm = new Label();
            lblRegisterNewUser = new Label();
            lblFirstNameError = new Label();
            lblLastNameError = new Label();
            lblEmailError = new Label();
            lblUsernameError = new Label();
            lblPasswordError = new Label();
            lblPasswordConfirmError = new Label();
            lblMessage = new Label();
            btnRegister = new Button();
            lklblReturnToLogin = new LinkLabel();
            tlpRegisterForm.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRegisterForm
            // 
            tlpRegisterForm.ColumnCount = 3;
            tlpRegisterForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpRegisterForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpRegisterForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpRegisterForm.Controls.Add(tbFirstName, 1, 1);
            tlpRegisterForm.Controls.Add(tbLastName, 1, 2);
            tlpRegisterForm.Controls.Add(tbEmail, 1, 3);
            tlpRegisterForm.Controls.Add(tbUsername, 1, 4);
            tlpRegisterForm.Controls.Add(tbPassword, 1, 5);
            tlpRegisterForm.Controls.Add(tbPasswordConfirm, 1, 6);
            tlpRegisterForm.Controls.Add(lblFirstName, 0, 1);
            tlpRegisterForm.Controls.Add(lblLastName, 0, 2);
            tlpRegisterForm.Controls.Add(lblEmail, 0, 3);
            tlpRegisterForm.Controls.Add(lblUsername, 0, 4);
            tlpRegisterForm.Controls.Add(lblPassword, 0, 5);
            tlpRegisterForm.Controls.Add(lblPasswordConfirm, 0, 6);
            tlpRegisterForm.Controls.Add(lblRegisterNewUser, 1, 0);
            tlpRegisterForm.Controls.Add(lblFirstNameError, 2, 1);
            tlpRegisterForm.Controls.Add(lblLastNameError, 2, 2);
            tlpRegisterForm.Controls.Add(lblEmailError, 2, 3);
            tlpRegisterForm.Controls.Add(lblUsernameError, 2, 4);
            tlpRegisterForm.Controls.Add(lblPasswordError, 2, 5);
            tlpRegisterForm.Controls.Add(lblPasswordConfirmError, 2, 6);
            tlpRegisterForm.Controls.Add(lblMessage, 2, 7);
            tlpRegisterForm.Controls.Add(btnRegister, 1, 7);
            tlpRegisterForm.Controls.Add(lklblReturnToLogin, 0, 7);
            tlpRegisterForm.Dock = DockStyle.Fill;
            tlpRegisterForm.Location = new Point(0, 0);
            tlpRegisterForm.Name = "tlpRegisterForm";
            tlpRegisterForm.RowCount = 8;
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499176F));
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4991722F));
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5016727F));
            tlpRegisterForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.50328F));
            tlpRegisterForm.Size = new Size(800, 450);
            tlpRegisterForm.TabIndex = 0;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstName.Location = new Point(269, 59);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(260, 32);
            tbFirstName.TabIndex = 0;
            tbFirstName.TextChanged += tbFirstName_TextChanged;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.Location = new Point(269, 115);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(260, 32);
            tbLastName.TabIndex = 1;
            tbLastName.TextChanged += tbLastName_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(269, 171);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(260, 32);
            tbEmail.TabIndex = 2;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(269, 227);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(260, 32);
            tbUsername.TabIndex = 3;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(269, 283);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(260, 32);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbPasswordConfirm
            // 
            tbPasswordConfirm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPasswordConfirm.Location = new Point(269, 339);
            tbPasswordConfirm.Name = "tbPasswordConfirm";
            tbPasswordConfirm.Size = new Size(260, 32);
            tbPasswordConfirm.TabIndex = 5;
            tbPasswordConfirm.TextChanged += tbPasswordConfirm_TextChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(3, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Padding = new Padding(50, 0, 0, 0);
            lblFirstName.Size = new Size(152, 25);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(3, 112);
            lblLastName.Name = "lblLastName";
            lblLastName.Padding = new Padding(50, 0, 0, 0);
            lblLastName.Size = new Size(150, 25);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(3, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Padding = new Padding(50, 0, 0, 0);
            lblEmail.Size = new Size(108, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(3, 224);
            lblUsername.Name = "lblUsername";
            lblUsername.Padding = new Padding(50, 0, 0, 0);
            lblUsername.Size = new Size(147, 25);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(3, 280);
            lblPassword.Name = "lblPassword";
            lblPassword.Padding = new Padding(50, 0, 0, 0);
            lblPassword.Size = new Size(141, 25);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordConfirm.Location = new Point(3, 336);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Padding = new Padding(50, 0, 0, 0);
            lblPasswordConfirm.Size = new Size(214, 25);
            lblPasswordConfirm.TabIndex = 11;
            lblPasswordConfirm.Text = "Confirm Password";
            // 
            // lblRegisterNewUser
            // 
            lblRegisterNewUser.AutoSize = true;
            lblRegisterNewUser.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisterNewUser.ForeColor = Color.DarkOrange;
            lblRegisterNewUser.Location = new Point(269, 0);
            lblRegisterNewUser.Name = "lblRegisterNewUser";
            lblRegisterNewUser.Padding = new Padding(0, 10, 0, 0);
            lblRegisterNewUser.Size = new Size(174, 35);
            lblRegisterNewUser.TabIndex = 12;
            lblRegisterNewUser.Text = "Register New User";
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(535, 56);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(0, 19);
            lblFirstNameError.TabIndex = 13;
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(535, 112);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(0, 19);
            lblLastNameError.TabIndex = 14;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(535, 168);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(0, 19);
            lblEmailError.TabIndex = 15;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(535, 224);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(0, 19);
            lblUsernameError.TabIndex = 16;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(535, 280);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 19);
            lblPasswordError.TabIndex = 17;
            // 
            // lblPasswordConfirmError
            // 
            lblPasswordConfirmError.AutoSize = true;
            lblPasswordConfirmError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordConfirmError.ForeColor = Color.Red;
            lblPasswordConfirmError.Location = new Point(535, 336);
            lblPasswordConfirmError.Name = "lblPasswordConfirmError";
            lblPasswordConfirmError.Size = new Size(0, 19);
            lblPasswordConfirmError.TabIndex = 18;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Location = new Point(535, 392);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 25);
            lblMessage.TabIndex = 19;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Orange;
            btnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.OliveDrab;
            btnRegister.Location = new Point(269, 395);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(260, 43);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lklblReturnToLogin
            // 
            lklblReturnToLogin.AutoSize = true;
            lklblReturnToLogin.Location = new Point(3, 392);
            lklblReturnToLogin.Name = "lklblReturnToLogin";
            lklblReturnToLogin.Padding = new Padding(0, 30, 0, 0);
            lklblReturnToLogin.Size = new Size(86, 45);
            lklblReturnToLogin.TabIndex = 21;
            lklblReturnToLogin.TabStop = true;
            lklblReturnToLogin.Text = "Return to login";
            lklblReturnToLogin.LinkClicked += lklblReturnToLogin_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpRegisterForm);
            Name = "RegisterForm";
            Text = "RegisterForm";
            FormClosing += RegisterForm_FormClosing;
            Load += RegisterForm_Load;
            tlpRegisterForm.ResumeLayout(false);
            tlpRegisterForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRegisterForm;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbPasswordConfirm;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblPasswordConfirm;
        private Label lblRegisterNewUser;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblEmailError;
        private Label lblUsernameError;
        private Label lblPasswordError;
        private Label lblPasswordConfirmError;
        private Label lblMessage;
        private Button btnRegister;
        private LinkLabel lklblReturnToLogin;
    }
}