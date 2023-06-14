namespace TeaLeaves.UserControls
{
    partial class ucEventInvites
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEventInvites = new DataGridView();
            eventName = new DataGridViewTextBoxColumn();
            eventDateAndTime = new DataGridViewTextBoxColumn();
            eventDescription = new DataGridViewTextBoxColumn();
            btnAccept = new Button();
            btnDecline = new Button();
            btnRefresh = new Button();
            btnView = new Button();
            dgvAcceptedInvites = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblInvites = new Label();
            lblAcceptedInvites = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).BeginInit();
            SuspendLayout();
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.AllowUserToAddRows = false;
            dgvEventInvites.AllowUserToDeleteRows = false;
            dgvEventInvites.BackgroundColor = Color.PapayaWhip;
            dgvEventInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Columns.AddRange(new DataGridViewColumn[] { eventName, eventDateAndTime, eventDescription });
            dgvEventInvites.Location = new Point(3, 52);
            dgvEventInvites.Name = "dgvEventInvites";
            dgvEventInvites.ReadOnly = true;
            dgvEventInvites.RowTemplate.Height = 25;
            dgvEventInvites.ScrollBars = ScrollBars.Vertical;
            dgvEventInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventInvites.Size = new Size(918, 179);
            dgvEventInvites.TabIndex = 0;
            // 
            // eventName
            // 
            eventName.DataPropertyName = "Name";
            eventName.HeaderText = "Name";
            eventName.Name = "eventName";
            eventName.ReadOnly = true;
            eventName.Width = 150;
            // 
            // eventDateAndTime
            // 
            eventDateAndTime.DataPropertyName = "DateTime";
            eventDateAndTime.HeaderText = "Time";
            eventDateAndTime.Name = "eventDateAndTime";
            eventDateAndTime.ReadOnly = true;
            eventDateAndTime.Width = 180;
            // 
            // eventDescription
            // 
            eventDescription.DataPropertyName = "Description";
            eventDescription.HeaderText = "Description";
            eventDescription.Name = "eventDescription";
            eventDescription.ReadOnly = true;
            eventDescription.Width = 392;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Orange;
            btnAccept.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccept.ForeColor = Color.DarkGreen;
            btnAccept.Location = new Point(983, 22);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(126, 57);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.Orange;
            btnDecline.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecline.ForeColor = Color.DarkGreen;
            btnDecline.Location = new Point(983, 85);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(126, 57);
            btnDecline.TabIndex = 2;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Orange;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.DarkGreen;
            btnRefresh.Location = new Point(983, 211);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 57);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Orange;
            btnView.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = Color.DarkGreen;
            btnView.Location = new Point(983, 148);
            btnView.Name = "btnView";
            btnView.Size = new Size(126, 57);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            // 
            // dgvAcceptedInvites
            // 
            dgvAcceptedInvites.AllowUserToAddRows = false;
            dgvAcceptedInvites.AllowUserToDeleteRows = false;
            dgvAcceptedInvites.BackgroundColor = Color.PapayaWhip;
            dgvAcceptedInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcceptedInvites.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvAcceptedInvites.Location = new Point(3, 268);
            dgvAcceptedInvites.Name = "dgvAcceptedInvites";
            dgvAcceptedInvites.ReadOnly = true;
            dgvAcceptedInvites.RowTemplate.Height = 25;
            dgvAcceptedInvites.ScrollBars = ScrollBars.Vertical;
            dgvAcceptedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptedInvites.Size = new Size(918, 179);
            dgvAcceptedInvites.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "DateTime";
            dataGridViewTextBoxColumn2.HeaderText = "Time";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 392;
            // 
            // lblInvites
            // 
            lblInvites.AutoSize = true;
            lblInvites.Location = new Point(382, 22);
            lblInvites.Name = "lblInvites";
            lblInvites.Size = new Size(41, 15);
            lblInvites.TabIndex = 6;
            lblInvites.Text = "Invites";
            // 
            // lblAcceptedInvites
            // 
            lblAcceptedInvites.AutoSize = true;
            lblAcceptedInvites.Location = new Point(354, 234);
            lblAcceptedInvites.Name = "lblAcceptedInvites";
            lblAcceptedInvites.Size = new Size(94, 15);
            lblAcceptedInvites.TabIndex = 7;
            lblAcceptedInvites.Text = "Accepted Invites";
            // 
            // ucEventInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAcceptedInvites);
            Controls.Add(lblInvites);
            Controls.Add(dgvAcceptedInvites);
            Controls.Add(btnView);
            Controls.Add(btnRefresh);
            Controls.Add(btnDecline);
            Controls.Add(btnAccept);
            Controls.Add(dgvEventInvites);
            Name = "ucEventInvites";
            Size = new Size(1134, 449);
            Load += ucEventInvites_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEventInvites;
        private Button btnAccept;
        private Button btnDecline;
        private Button btnRefresh;
        private Button btnView;
        private DataGridViewTextBoxColumn eventName;
        private DataGridViewTextBoxColumn eventDateAndTime;
        private DataGridViewTextBoxColumn eventDescription;
        private DataGridView dgvAcceptedInvites;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblInvites;
        private Label lblAcceptedInvites;
    }
}
