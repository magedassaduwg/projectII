namespace TeaLeaves.Views
{
    partial class SurveyInvitesForm
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
            lblUninvitedContacts = new Label();
            dgvUninvitedContacts = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            lblInvitedContacts = new Label();
            btnInvite = new Button();
            dgvInvitedContacts = new DataGridView();
            firstName1 = new DataGridViewTextBoxColumn();
            lastName2 = new DataGridViewTextBoxColumn();
            username1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUninvitedContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvitedContacts).BeginInit();
            SuspendLayout();
            // 
            // lblUninvitedContacts
            // 
            lblUninvitedContacts.AutoSize = true;
            lblUninvitedContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUninvitedContacts.ForeColor = Color.DarkOrange;
            lblUninvitedContacts.Location = new Point(536, 16);
            lblUninvitedContacts.Name = "lblUninvitedContacts";
            lblUninvitedContacts.Size = new Size(156, 21);
            lblUninvitedContacts.TabIndex = 13;
            lblUninvitedContacts.Text = "Uninvited Contacts";
            // 
            // dgvUninvitedContacts
            // 
            dgvUninvitedContacts.AllowUserToAddRows = false;
            dgvUninvitedContacts.AllowUserToDeleteRows = false;
            dgvUninvitedContacts.AllowUserToResizeColumns = false;
            dgvUninvitedContacts.AllowUserToResizeRows = false;
            dgvUninvitedContacts.BackgroundColor = Color.PapayaWhip;
            dgvUninvitedContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUninvitedContacts.Columns.AddRange(new DataGridViewColumn[] { FirstName, lastName, username });
            dgvUninvitedContacts.Location = new Point(429, 40);
            dgvUninvitedContacts.Name = "dgvUninvitedContacts";
            dgvUninvitedContacts.ReadOnly = true;
            dgvUninvitedContacts.RowTemplate.Height = 40;
            dgvUninvitedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUninvitedContacts.Size = new Size(377, 551);
            dgvUninvitedContacts.TabIndex = 12;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastName.DataPropertyName = "LastName";
            lastName.HeaderText = "Last Name";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.DataPropertyName = "Username";
            username.HeaderText = "Username";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // lblInvitedContacts
            // 
            lblInvitedContacts.AutoSize = true;
            lblInvitedContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvitedContacts.ForeColor = Color.DarkOrange;
            lblInvitedContacts.Location = new Point(147, 16);
            lblInvitedContacts.Name = "lblInvitedContacts";
            lblInvitedContacts.Size = new Size(134, 21);
            lblInvitedContacts.TabIndex = 11;
            lblInvitedContacts.Text = "Invited Contacts";
            // 
            // btnInvite
            // 
            btnInvite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvite.Location = new Point(495, 597);
            btnInvite.Name = "btnInvite";
            btnInvite.Size = new Size(250, 64);
            btnInvite.TabIndex = 10;
            btnInvite.Text = "Invite";
            btnInvite.UseVisualStyleBackColor = true;
            btnInvite.Click += btnInvite_Click;
            // 
            // dgvInvitedContacts
            // 
            dgvInvitedContacts.AllowUserToAddRows = false;
            dgvInvitedContacts.AllowUserToDeleteRows = false;
            dgvInvitedContacts.AllowUserToResizeColumns = false;
            dgvInvitedContacts.AllowUserToResizeRows = false;
            dgvInvitedContacts.BackgroundColor = Color.PapayaWhip;
            dgvInvitedContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvitedContacts.Columns.AddRange(new DataGridViewColumn[] { firstName1, lastName2, username1 });
            dgvInvitedContacts.Location = new Point(23, 40);
            dgvInvitedContacts.Name = "dgvInvitedContacts";
            dgvInvitedContacts.ReadOnly = true;
            dgvInvitedContacts.RowTemplate.Height = 25;
            dgvInvitedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvitedContacts.Size = new Size(378, 551);
            dgvInvitedContacts.TabIndex = 9;
            // 
            // firstName1
            // 
            firstName1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstName1.DataPropertyName = "FirstName";
            firstName1.HeaderText = "First Name";
            firstName1.Name = "firstName1";
            firstName1.ReadOnly = true;
            // 
            // lastName2
            // 
            lastName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            lastName2.DataPropertyName = "LastName";
            lastName2.HeaderText = "Last Name";
            lastName2.Name = "lastName2";
            lastName2.ReadOnly = true;
            lastName2.Width = 88;
            // 
            // username1
            // 
            username1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username1.DataPropertyName = "Username";
            username1.HeaderText = "Username";
            username1.Name = "username1";
            username1.ReadOnly = true;
            // 
            // SurveyInvitesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 709);
            Controls.Add(lblUninvitedContacts);
            Controls.Add(dgvUninvitedContacts);
            Controls.Add(lblInvitedContacts);
            Controls.Add(btnInvite);
            Controls.Add(dgvInvitedContacts);
            Name = "SurveyInvitesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SurveyInvitesForm";
            ((System.ComponentModel.ISupportInitialize)dgvUninvitedContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvitedContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUninvitedContacts;
        private DataGridView dgvUninvitedContacts;
        private Label lblInvitedContacts;
        private Button btnInvite;
        private DataGridView dgvInvitedContacts;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn firstName1;
        private DataGridViewTextBoxColumn lastName2;
        private DataGridViewTextBoxColumn username1;
    }
}