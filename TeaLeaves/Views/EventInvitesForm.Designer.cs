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
            dgvAcceptedContacts = new DataGridView();
            dgvDeclinedContacts = new DataGridView();
            lblAcceptedContacts = new Label();
            lblDeclinedContacts = new Label();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            firstName1 = new DataGridViewTextBoxColumn();
            lastName2 = new DataGridViewTextBoxColumn();
            username1 = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInvitedContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUninvitedContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeclinedContacts).BeginInit();
            SuspendLayout();
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
            dgvInvitedContacts.Location = new Point(12, 45);
            dgvInvitedContacts.Name = "dgvInvitedContacts";
            dgvInvitedContacts.ReadOnly = true;
            dgvInvitedContacts.RowTemplate.Height = 25;
            dgvInvitedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvitedContacts.Size = new Size(358, 211);
            dgvInvitedContacts.TabIndex = 0;
            // 
            // btnInvite
            // 
            btnInvite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvite.Location = new Point(458, 582);
            btnInvite.Name = "btnInvite";
            btnInvite.Size = new Size(250, 64);
            btnInvite.TabIndex = 1;
            btnInvite.Text = "Invite";
            btnInvite.UseVisualStyleBackColor = true;
            btnInvite.Click += btnInvite_Click;
            // 
            // lblInvitedContacts
            // 
            lblInvitedContacts.AutoSize = true;
            lblInvitedContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvitedContacts.ForeColor = Color.DarkOrange;
            lblInvitedContacts.Location = new Point(116, 21);
            lblInvitedContacts.Name = "lblInvitedContacts";
            lblInvitedContacts.Size = new Size(134, 21);
            lblInvitedContacts.TabIndex = 2;
            lblInvitedContacts.Text = "Invited Contacts";
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
            dgvUninvitedContacts.Location = new Point(398, 45);
            dgvUninvitedContacts.Name = "dgvUninvitedContacts";
            dgvUninvitedContacts.ReadOnly = true;
            dgvUninvitedContacts.RowTemplate.Height = 25;
            dgvUninvitedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUninvitedContacts.Size = new Size(358, 521);
            dgvUninvitedContacts.TabIndex = 3;
            // 
            // lblUninvitedContacts
            // 
            lblUninvitedContacts.AutoSize = true;
            lblUninvitedContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUninvitedContacts.ForeColor = Color.DarkOrange;
            lblUninvitedContacts.Location = new Point(505, 21);
            lblUninvitedContacts.Name = "lblUninvitedContacts";
            lblUninvitedContacts.Size = new Size(156, 21);
            lblUninvitedContacts.TabIndex = 4;
            lblUninvitedContacts.Text = "Uninvited Contacts";
            // 
            // dgvAcceptedContacts
            // 
            dgvAcceptedContacts.AllowUserToAddRows = false;
            dgvAcceptedContacts.AllowUserToDeleteRows = false;
            dgvAcceptedContacts.AllowUserToResizeColumns = false;
            dgvAcceptedContacts.AllowUserToResizeRows = false;
            dgvAcceptedContacts.BackgroundColor = Color.PapayaWhip;
            dgvAcceptedContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcceptedContacts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvAcceptedContacts.Location = new Point(12, 303);
            dgvAcceptedContacts.Name = "dgvAcceptedContacts";
            dgvAcceptedContacts.ReadOnly = true;
            dgvAcceptedContacts.RowTemplate.Height = 25;
            dgvAcceptedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptedContacts.Size = new Size(358, 176);
            dgvAcceptedContacts.TabIndex = 5;
            // 
            // dgvDeclinedContacts
            // 
            dgvDeclinedContacts.AllowUserToAddRows = false;
            dgvDeclinedContacts.AllowUserToDeleteRows = false;
            dgvDeclinedContacts.AllowUserToResizeColumns = false;
            dgvDeclinedContacts.AllowUserToResizeRows = false;
            dgvDeclinedContacts.BackgroundColor = Color.PapayaWhip;
            dgvDeclinedContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeclinedContacts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvDeclinedContacts.Location = new Point(12, 521);
            dgvDeclinedContacts.Name = "dgvDeclinedContacts";
            dgvDeclinedContacts.ReadOnly = true;
            dgvDeclinedContacts.RowTemplate.Height = 25;
            dgvDeclinedContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeclinedContacts.Size = new Size(358, 176);
            dgvDeclinedContacts.TabIndex = 6;
            // 
            // lblAcceptedContacts
            // 
            lblAcceptedContacts.AutoSize = true;
            lblAcceptedContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcceptedContacts.ForeColor = Color.DarkOrange;
            lblAcceptedContacts.Location = new Point(116, 279);
            lblAcceptedContacts.Name = "lblAcceptedContacts";
            lblAcceptedContacts.Size = new Size(151, 21);
            lblAcceptedContacts.TabIndex = 7;
            lblAcceptedContacts.Text = "Accepted Contacts";
            // 
            // lblDeclinedContacts
            // 
            lblDeclinedContacts.AutoSize = true;
            lblDeclinedContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeclinedContacts.ForeColor = Color.DarkOrange;
            lblDeclinedContacts.Location = new Point(116, 497);
            lblDeclinedContacts.Name = "lblDeclinedContacts";
            lblDeclinedContacts.Size = new Size(148, 21);
            lblDeclinedContacts.TabIndex = 8;
            lblDeclinedContacts.Text = "Declined Contacts";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn4.HeaderText = "First Name";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn5.HeaderText = "Last Name";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            dataGridViewTextBoxColumn6.HeaderText = "Username";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 115;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn1.HeaderText = "First Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Username";
            dataGridViewTextBoxColumn3.HeaderText = "Username";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 115;
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
            username1.Width = 115;
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
            username.Width = 115;
            // 
            // EventInvitesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 709);
            Controls.Add(lblDeclinedContacts);
            Controls.Add(lblAcceptedContacts);
            Controls.Add(dgvDeclinedContacts);
            Controls.Add(dgvAcceptedContacts);
            Controls.Add(lblUninvitedContacts);
            Controls.Add(dgvUninvitedContacts);
            Controls.Add(lblInvitedContacts);
            Controls.Add(btnInvite);
            Controls.Add(dgvInvitedContacts);
            Name = "EventInvitesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventInvitesForm";
            ((System.ComponentModel.ISupportInitialize)dgvInvitedContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUninvitedContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeclinedContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInvitedContacts;
        private Button btnInvite;
        private Label lblInvitedContacts;
        private DataGridView dgvUninvitedContacts;
        private Label lblUninvitedContacts;
        private DataGridView dgvAcceptedContacts;
        private DataGridView dgvDeclinedContacts;
        private Label lblAcceptedContacts;
        private Label lblDeclinedContacts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn firstName1;
        private DataGridViewTextBoxColumn lastName2;
        private DataGridViewTextBoxColumn username1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}