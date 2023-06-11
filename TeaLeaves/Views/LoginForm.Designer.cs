namespace TeaLeaves
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelImg = new Panel();
            pictureBoxLogo = new PictureBox();
            panelLogin = new Panel();
            lklblRegister = new LinkLabel();
            lblError = new Label();
            buttonLogin = new Button();
            panelPassword = new Panel();
            pictureBox2 = new PictureBox();
            textBoxPassword = new TextBox();
            panelUser = new Panel();
            pictureBoxUser = new PictureBox();
            textBoxUsername = new TextBox();
            labelLogin = new Label();
            panelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelLogin.SuspendLayout();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // panelImg
            // 
            panelImg.BackColor = Color.Orange;
            panelImg.Controls.Add(pictureBoxLogo);
            panelImg.Dock = DockStyle.Left;
            panelImg.Location = new Point(0, 0);
            panelImg.Name = "panelImg";
            panelImg.Size = new Size(309, 450);
            panelImg.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = Properties.Resources.tealeaves_logo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(309, 450);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(lklblRegister);
            panelLogin.Controls.Add(lblError);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(panelPassword);
            panelLogin.Controls.Add(panelUser);
            panelLogin.Controls.Add(labelLogin);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(309, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(491, 450);
            panelLogin.TabIndex = 1;
            // 
            // lklblRegister
            // 
            lklblRegister.AutoSize = true;
            lklblRegister.Location = new Point(357, 426);
            lklblRegister.Name = "lklblRegister";
            lklblRegister.Size = new Size(120, 15);
            lklblRegister.TabIndex = 3;
            lklblRegister.TabStop = true;
            lklblRegister.Text = "Register new account";
            lklblRegister.LinkClicked += lklblRegister_LinkClicked;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(35, 242);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 8;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Orange;
            buttonLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.OliveDrab;
            buttonLogin.Location = new Point(161, 298);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(111, 47);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panelPassword
            // 
            panelPassword.Controls.Add(pictureBox2);
            panelPassword.Controls.Add(textBoxPassword);
            panelPassword.Location = new Point(0, 165);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(491, 44);
            panelPassword.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(17, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(67, 13);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(279, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(pictureBoxUser);
            panelUser.Controls.Add(textBoxUsername);
            panelUser.Location = new Point(0, 115);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(491, 44);
            panelUser.TabIndex = 5;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = Properties.Resources.user;
            pictureBoxUser.Location = new Point(17, 9);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(30, 30);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 1;
            pictureBoxUser.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(67, 16);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(279, 23);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.DarkOrange;
            labelLogin.Location = new Point(128, 43);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(218, 30);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login to your account";
            labelLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogin);
            Controls.Add(panelImg);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login-TeaLeaves";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            panelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImg;
        private PictureBox pictureBoxLogo;
        private Panel panelLogin;
        private Label labelLogin;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBox2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Panel panelUser;
        private Panel panelPassword;
        private Button buttonLogin;
        private Label lblError;
        private LinkLabel lklblRegister;
    }
}