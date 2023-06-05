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
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.Location = new Point(269, 115);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(260, 32);
            tbLastName.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(269, 171);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(260, 32);
            tbEmail.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(269, 227);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(260, 32);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(269, 283);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(260, 32);
            tbPassword.TabIndex = 4;
            // 
            // tbPasswordConfirm
            // 
            tbPasswordConfirm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPasswordConfirm.Location = new Point(269, 339);
            tbPasswordConfirm.Name = "tbPasswordConfirm";
            tbPasswordConfirm.Size = new Size(260, 32);
            tbPasswordConfirm.TabIndex = 5;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(3, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(3, 112);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(3, 224);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(3, 280);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Location = new Point(3, 336);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(104, 15);
            lblPasswordConfirm.TabIndex = 11;
            lblPasswordConfirm.Text = "Confirm Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpRegisterForm);
            Name = "RegisterForm";
            Text = "RegisterForm";
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
    }
}