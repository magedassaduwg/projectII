namespace TeaLeaves.Views
{
    partial class EventInvitesForm
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
            dgvInvitedContacts = new DataGridView();
            btnInvite = new Button();
            lblInvitedContacts = new Label();
            dgvUninvitedContacts = new DataGridView();
            lblUninvitedContacts = new Label();
            FirstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            firstName1 = new DataGridViewTextBoxColumn();
            lastName2 = new DataGridViewTextBoxColumn();
            username1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInvitedContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUninvitedContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvInvitedContacts
            // 
            dgvInvitedContacts.AllowUserToAddRows = false;
            dgvInvitedContacts.AllowUserToDeleteRows = false;
            dgvInvitedContacts.AllowUserToResizeColumns = false;
            dgvInvitedContacts.AllowUserToResizeRows = false;
            dgvInvitedContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvitedContacts.Columns.AddRange(new DataGridViewColumn[] { firstName1, lastName2, username1 });
            dgvInvitedContacts.Location = new Point(28, 82);
            dgvInvitedContacts.Name = "dgvInvitedContacts";
            dgvInvitedContacts.ReadOnly = true;
            dgvInvitedContacts.RowTemplate.Height = 25;
            dgvInvitedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvitedContacts.Size = new Size(357, 253);
            dgvInvitedContacts.TabIndex = 0;
            // 
            // btnInvite
            // 
            btnInvite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvite.Location = new Point(414, 359);
            btnInvite.Name = "btnInvite";
            btnInvite.Size = new Size(128, 32);
            btnInvite.TabIndex = 1;
            btnInvite.Text = "Invite";
            btnInvite.UseVisualStyleBackColor = true;
            btnInvite.Click += btnInvite_Click;
            // 
            // lblInvitedContacts
            // 
            lblInvitedContacts.AutoSize = true;
            lblInvitedContacts.Location = new Point(28, 49);
            lblInvitedContacts.Name = "lblInvitedContacts";
            lblInvitedContacts.Size = new Size(93, 15);
            lblInvitedContacts.TabIndex = 2;
            lblInvitedContacts.Text = "Invited Contacts";
            // 
            // dgvUninvitedContacts
            // 
            dgvUninvitedContacts.AllowUserToAddRows = false;
            dgvUninvitedContacts.AllowUserToDeleteRows = false;
            dgvUninvitedContacts.AllowUserToResizeColumns = false;
            dgvUninvitedContacts.AllowUserToResizeRows = false;
            dgvUninvitedContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUninvitedContacts.Columns.AddRange(new DataGridViewColumn[] { FirstName, lastName, username });
            dgvUninvitedContacts.Location = new Point(414, 82);
            dgvUninvitedContacts.Name = "dgvUninvitedContacts";
            dgvUninvitedContacts.ReadOnly = true;
            dgvUninvitedContacts.RowTemplate.Height = 25;
            dgvUninvitedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUninvitedContacts.Size = new Size(357, 253);
            dgvUninvitedContacts.TabIndex = 3;
            // 
            // lblUninvitedContacts
            // 
            lblUninvitedContacts.AutoSize = true;
            lblUninvitedContacts.Location = new Point(414, 49);
            lblUninvitedContacts.Name = "lblUninvitedContacts";
            lblUninvitedContacts.Size = new Size(108, 15);
            lblUninvitedContacts.TabIndex = 4;
            lblUninvitedContacts.Text = "Uninvited Contacts";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.DataPropertyName = "LastName";
            lastName.HeaderText = "Last Name";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // username
            // 
            username.DataPropertyName = "Username";
            username.HeaderText = "Username";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // firstName1
            // 
            firstName1.DataPropertyName = "FirstName";
            firstName1.HeaderText = "First Name";
            firstName1.Name = "firstName1";
            firstName1.ReadOnly = true;
            // 
            // lastName2
            // 
            lastName2.DataPropertyName = "LastName";
            lastName2.HeaderText = "Last Name";
            lastName2.Name = "lastName2";
            lastName2.ReadOnly = true;
            // 
            // username1
            // 
            username1.DataPropertyName = "Username";
            username1.HeaderText = "Username";
            username1.Name = "username1";
            username1.ReadOnly = true;
            // 
            // EventInvitesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUninvitedContacts);
            Controls.Add(dgvUninvitedContacts);
            Controls.Add(lblInvitedContacts);
            Controls.Add(btnInvite);
            Controls.Add(dgvInvitedContacts);
            Name = "EventInvitesForm";
            Text = "EventInvitesForm";
            ((System.ComponentModel.ISupportInitialize)dgvInvitedContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUninvitedContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInvitedContacts;
        private Button btnInvite;
        private Label lblInvitedContacts;
        private DataGridView dgvUninvitedContacts;
        private Label lblUninvitedContacts;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn firstName1;
        private DataGridViewTextBoxColumn lastName2;
        private DataGridViewTextBoxColumn username1;
    }
}