﻿namespace TeaLeaves.UserControls
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
            components = new System.ComponentModel.Container();
            dgvEventInvites = new DataGridView();
            eventBindingSource = new BindingSource(components);
            btnAccept = new Button();
            btnDecline = new Button();
            btnRefresh = new Button();
            btnView = new Button();
            dgvAcceptedInvites = new DataGridView();
            lblInvites = new Label();
            lblAcceptedInvites = new Label();
            eventNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            eventNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).BeginInit();
            SuspendLayout();
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.AllowUserToAddRows = false;
            dgvEventInvites.AllowUserToDeleteRows = false;
            dgvEventInvites.AutoGenerateColumns = false;
            dgvEventInvites.BackgroundColor = Color.PapayaWhip;
            dgvEventInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Columns.AddRange(new DataGridViewColumn[] { eventNameDataGridViewTextBoxColumn, eventDateTimeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dgvEventInvites.DataSource = eventBindingSource;
            dgvEventInvites.Location = new Point(3, 52);
            dgvEventInvites.Name = "dgvEventInvites";
            dgvEventInvites.ReadOnly = true;
            dgvEventInvites.RowTemplate.Height = 25;
            dgvEventInvites.ScrollBars = ScrollBars.Vertical;
            dgvEventInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventInvites.Size = new Size(953, 179);
            dgvEventInvites.TabIndex = 0;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Models.Event);
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
            btnDecline.Click += btnDecline_Click;
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
            btnView.Click += btnView_Click;
            // 
            // dgvAcceptedInvites
            // 
            dgvAcceptedInvites.AllowUserToAddRows = false;
            dgvAcceptedInvites.AllowUserToDeleteRows = false;
            dgvAcceptedInvites.AutoGenerateColumns = false;
            dgvAcceptedInvites.BackgroundColor = Color.PapayaWhip;
            dgvAcceptedInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcceptedInvites.Columns.AddRange(new DataGridViewColumn[] { eventNameDataGridViewTextBoxColumn1, eventDateTimeDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1 });
            dgvAcceptedInvites.DataSource = eventBindingSource;
            dgvAcceptedInvites.Location = new Point(3, 268);
            dgvAcceptedInvites.Name = "dgvAcceptedInvites";
            dgvAcceptedInvites.ReadOnly = true;
            dgvAcceptedInvites.RowTemplate.Height = 25;
            dgvAcceptedInvites.ScrollBars = ScrollBars.Vertical;
            dgvAcceptedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptedInvites.Size = new Size(953, 179);
            dgvAcceptedInvites.TabIndex = 5;
            // 
            // lblInvites
            // 
            lblInvites.AutoSize = true;
            lblInvites.BackColor = SystemColors.Control;
            lblInvites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvites.ForeColor = Color.DarkOrange;
            lblInvites.Location = new Point(382, 22);
            lblInvites.Name = "lblInvites";
            lblInvites.Size = new Size(61, 21);
            lblInvites.TabIndex = 6;
            lblInvites.Text = "Invites";
            // 
            // lblAcceptedInvites
            // 
            lblAcceptedInvites.AutoSize = true;
            lblAcceptedInvites.BackColor = SystemColors.Control;
            lblAcceptedInvites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcceptedInvites.ForeColor = Color.DarkOrange;
            lblAcceptedInvites.Location = new Point(354, 234);
            lblAcceptedInvites.Name = "lblAcceptedInvites";
            lblAcceptedInvites.Size = new Size(136, 21);
            lblAcceptedInvites.TabIndex = 7;
            lblAcceptedInvites.Text = "Accepted Invites";
            // 
            // eventNameDataGridViewTextBoxColumn1
            // 
            eventNameDataGridViewTextBoxColumn1.DataPropertyName = "EventName";
            eventNameDataGridViewTextBoxColumn1.HeaderText = "EventName";
            eventNameDataGridViewTextBoxColumn1.Name = "eventNameDataGridViewTextBoxColumn1";
            eventNameDataGridViewTextBoxColumn1.ReadOnly = true;
            eventNameDataGridViewTextBoxColumn1.Width = 240;
            // 
            // eventDateTimeDataGridViewTextBoxColumn1
            // 
            eventDateTimeDataGridViewTextBoxColumn1.DataPropertyName = "EventDateTime";
            eventDateTimeDataGridViewTextBoxColumn1.HeaderText = "EventDateTime";
            eventDateTimeDataGridViewTextBoxColumn1.Name = "eventDateTimeDataGridViewTextBoxColumn1";
            eventDateTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            eventDateTimeDataGridViewTextBoxColumn1.Width = 240;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn1.Width = 430;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            eventNameDataGridViewTextBoxColumn.ReadOnly = true;
            eventNameDataGridViewTextBoxColumn.Width = 240;
            // 
            // eventDateTimeDataGridViewTextBoxColumn
            // 
            eventDateTimeDataGridViewTextBoxColumn.DataPropertyName = "EventDateTime";
            eventDateTimeDataGridViewTextBoxColumn.HeaderText = "EventDateTime";
            eventDateTimeDataGridViewTextBoxColumn.Name = "eventDateTimeDataGridViewTextBoxColumn";
            eventDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            eventDateTimeDataGridViewTextBoxColumn.Width = 240;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 430;
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
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
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
        private DataGridView dgvAcceptedInvites;
        private Label lblInvites;
        private Label lblAcceptedInvites;
        private BindingSource eventBindingSource;
        private DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
    }
}
