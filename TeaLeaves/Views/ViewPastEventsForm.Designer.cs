namespace TeaLeaves.Views
{
    partial class ViewPastEventsForm
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
            dgvEventInvites = new DataGridView();
            EventName = new DataGridViewTextBoxColumn();
            EventDateTime = new DataGridViewTextBoxColumn();
            Creator = new DataGridViewTextBoxColumn();
            Accepted = new DataGridViewTextBoxColumn();
            Declined = new DataGridViewTextBoxColumn();
            lblPastEvents = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            SuspendLayout();
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.AllowUserToAddRows = false;
            dgvEventInvites.AllowUserToDeleteRows = false;
            dgvEventInvites.BackgroundColor = Color.PapayaWhip;
            dgvEventInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Columns.AddRange(new DataGridViewColumn[] { EventName, EventDateTime, Creator, Accepted, Declined });
            dgvEventInvites.Location = new Point(2, 84);
            dgvEventInvites.Name = "dgvEventInvites";
            dgvEventInvites.ReadOnly = true;
            dgvEventInvites.RowTemplate.Height = 40;
            dgvEventInvites.ScrollBars = ScrollBars.Vertical;
            dgvEventInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventInvites.Size = new Size(905, 452);
            dgvEventInvites.TabIndex = 22;
            // 
            // EventName
            // 
            EventName.DataPropertyName = "EventName";
            EventName.HeaderText = "Name";
            EventName.Name = "EventName";
            EventName.ReadOnly = true;
            EventName.Width = 220;
            // 
            // EventDateTime
            // 
            EventDateTime.DataPropertyName = "EventDateTime";
            EventDateTime.HeaderText = "Date and Time";
            EventDateTime.Name = "EventDateTime";
            EventDateTime.ReadOnly = true;
            EventDateTime.Width = 220;
            // 
            // Creator
            // 
            Creator.DataPropertyName = "CreatorName";
            Creator.HeaderText = "Event Creator";
            Creator.Name = "Creator";
            Creator.ReadOnly = true;
            Creator.Width = 220;
            // 
            // Accepted
            // 
            Accepted.DataPropertyName = "Accepted";
            Accepted.HeaderText = "Accepted";
            Accepted.Name = "Accepted";
            Accepted.ReadOnly = true;
            // 
            // Declined
            // 
            Declined.DataPropertyName = "Declined";
            Declined.HeaderText = "Declined";
            Declined.Name = "Declined";
            Declined.ReadOnly = true;
            // 
            // lblPastEvents
            // 
            lblPastEvents.AutoSize = true;
            lblPastEvents.BackColor = SystemColors.Control;
            lblPastEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPastEvents.ForeColor = Color.DarkGreen;
            lblPastEvents.Location = new Point(392, 38);
            lblPastEvents.Name = "lblPastEvents";
            lblPastEvents.Size = new Size(96, 21);
            lblPastEvents.TabIndex = 23;
            lblPastEvents.Text = "Past Events";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DarkGreen;
            btnBack.Location = new Point(20, 573);
            btnBack.Margin = new Padding(20, 3, 3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 39);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ViewPastEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 643);
            Controls.Add(btnBack);
            Controls.Add(lblPastEvents);
            Controls.Add(dgvEventInvites);
            Name = "ViewPastEventsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewPassedEventsForm";
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEventInvites;
        private Label lblPastEvents;
        private Button btnBack;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn EventDateTime;
        private DataGridViewTextBoxColumn Creator;
        private DataGridViewTextBoxColumn Accepted;
        private DataGridViewTextBoxColumn Declined;
    }
}