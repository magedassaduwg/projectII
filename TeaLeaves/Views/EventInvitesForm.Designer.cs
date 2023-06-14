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
            dgvInvitedContacts.Location = new Point(28, 82);
            dgvInvitedContacts.Name = "dgvInvitedContacts";
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
            dgvUninvitedContacts.Location = new Point(414, 82);
            dgvUninvitedContacts.Name = "dgvUninvitedContacts";
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
    }
}