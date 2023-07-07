namespace TeaLeaves.UserControls
{
    partial class ucSurveyInvites
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
            lblAcceptedInvites = new Label();
            lblSurveys = new Label();
            dgvAcceptedInvites = new DataGridView();
            SurveyName1 = new DataGridViewTextBoxColumn();
            DateTime1 = new DataGridViewTextBoxColumn();
            SurveyCreator1 = new DataGridViewTextBoxColumn();
            btnViewSurvey = new Button();
            dgvEventInvites = new DataGridView();
            SurveyName = new DataGridViewTextBoxColumn();
            SurveyDateTime = new DataGridViewTextBoxColumn();
            SurveyCreator = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            btnViewAnswered = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            SuspendLayout();
            // 
            // lblAcceptedInvites
            // 
            lblAcceptedInvites.AutoSize = true;
            lblAcceptedInvites.BackColor = SystemColors.Control;
            lblAcceptedInvites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcceptedInvites.ForeColor = Color.DarkOrange;
            lblAcceptedInvites.Location = new Point(54, 318);
            lblAcceptedInvites.Name = "lblAcceptedInvites";
            lblAcceptedInvites.Size = new Size(149, 21);
            lblAcceptedInvites.TabIndex = 28;
            lblAcceptedInvites.Text = "Answered Surveys";
            // 
            // lblSurveys
            // 
            lblSurveys.AutoSize = true;
            lblSurveys.BackColor = SystemColors.Control;
            lblSurveys.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSurveys.ForeColor = Color.DarkOrange;
            lblSurveys.Location = new Point(54, 41);
            lblSurveys.Name = "lblSurveys";
            lblSurveys.Size = new Size(203, 21);
            lblSurveys.TabIndex = 27;
            lblSurveys.Text = "Pending Survey Requests";
            // 
            // dgvAcceptedInvites
            // 
            dgvAcceptedInvites.AllowUserToAddRows = false;
            dgvAcceptedInvites.AllowUserToDeleteRows = false;
            dgvAcceptedInvites.BackgroundColor = Color.PapayaWhip;
            dgvAcceptedInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcceptedInvites.Columns.AddRange(new DataGridViewColumn[] { SurveyName1, DateTime1, SurveyCreator1 });
            dgvAcceptedInvites.Location = new Point(54, 342);
            dgvAcceptedInvites.Name = "dgvAcceptedInvites";
            dgvAcceptedInvites.ReadOnly = true;
            dgvAcceptedInvites.RowTemplate.Height = 25;
            dgvAcceptedInvites.ScrollBars = ScrollBars.Vertical;
            dgvAcceptedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptedInvites.Size = new Size(701, 160);
            dgvAcceptedInvites.TabIndex = 26;
            // 
            // SurveyName1
            // 
            SurveyName1.DataPropertyName = "Name";
            SurveyName1.HeaderText = "Name";
            SurveyName1.Name = "SurveyName1";
            SurveyName1.ReadOnly = true;
            SurveyName1.Width = 220;
            // 
            // DateTime1
            // 
            DateTime1.DataPropertyName = "SurveyDateTime";
            DateTime1.HeaderText = "Date And Time";
            DateTime1.Name = "DateTime1";
            DateTime1.ReadOnly = true;
            DateTime1.Width = 220;
            // 
            // SurveyCreator1
            // 
            SurveyCreator1.DataPropertyName = "SurveyCreator";
            SurveyCreator1.HeaderText = "Survey Creator";
            SurveyCreator1.Name = "SurveyCreator1";
            SurveyCreator1.ReadOnly = true;
            SurveyCreator1.Width = 220;
            // 
            // btnViewSurvey
            // 
            btnViewSurvey.BackColor = Color.Orange;
            btnViewSurvey.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewSurvey.ForeColor = Color.DarkGreen;
            btnViewSurvey.Location = new Point(764, 65);
            btnViewSurvey.Name = "btnViewSurvey";
            btnViewSurvey.Size = new Size(126, 57);
            btnViewSurvey.TabIndex = 25;
            btnViewSurvey.Text = "View Survey";
            btnViewSurvey.UseVisualStyleBackColor = false;
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.AllowUserToAddRows = false;
            dgvEventInvites.AllowUserToDeleteRows = false;
            dgvEventInvites.BackgroundColor = Color.PapayaWhip;
            dgvEventInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Columns.AddRange(new DataGridViewColumn[] { SurveyName, SurveyDateTime, SurveyCreator });
            dgvEventInvites.Location = new Point(54, 65);
            dgvEventInvites.Name = "dgvEventInvites";
            dgvEventInvites.ReadOnly = true;
            dgvEventInvites.RowTemplate.Height = 25;
            dgvEventInvites.ScrollBars = ScrollBars.Vertical;
            dgvEventInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventInvites.Size = new Size(701, 160);
            dgvEventInvites.TabIndex = 21;
            // 
            // SurveyName
            // 
            SurveyName.DataPropertyName = "Name";
            SurveyName.HeaderText = "Name";
            SurveyName.Name = "SurveyName";
            SurveyName.ReadOnly = true;
            SurveyName.Width = 220;
            // 
            // SurveyDateTime
            // 
            SurveyDateTime.DataPropertyName = "SurveyDateTime";
            SurveyDateTime.HeaderText = "Date and Time";
            SurveyDateTime.Name = "SurveyDateTime";
            SurveyDateTime.ReadOnly = true;
            SurveyDateTime.Width = 220;
            // 
            // SurveyCreator
            // 
            SurveyCreator.DataPropertyName = "CreatorName";
            SurveyCreator.HeaderText = "Survey Creator";
            SurveyCreator.Name = "SurveyCreator";
            SurveyCreator.ReadOnly = true;
            SurveyCreator.Width = 220;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Orange;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.DarkGreen;
            btnRefresh.Location = new Point(764, 191);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 57);
            btnRefresh.TabIndex = 24;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnViewAnswered
            // 
            btnViewAnswered.BackColor = Color.Orange;
            btnViewAnswered.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewAnswered.ForeColor = Color.DarkGreen;
            btnViewAnswered.Location = new Point(764, 128);
            btnViewAnswered.Name = "btnViewAnswered";
            btnViewAnswered.Size = new Size(126, 57);
            btnViewAnswered.TabIndex = 36;
            btnViewAnswered.Text = "View Answered Survey";
            btnViewAnswered.UseVisualStyleBackColor = false;
            // 
            // ucSurveyInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnViewAnswered);
            Controls.Add(lblAcceptedInvites);
            Controls.Add(lblSurveys);
            Controls.Add(dgvAcceptedInvites);
            Controls.Add(btnViewSurvey);
            Controls.Add(btnRefresh);
            Controls.Add(dgvEventInvites);
            Name = "ucSurveyInvites";
            Size = new Size(988, 549);
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDeclinedInvites;
        private DataGridView dgvDeclinedInvites;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblAcceptedInvites;
        private Label lblSurveys;
        private DataGridView dgvAcceptedInvites;
        private Button btnViewSurvey;
        private DataGridView dgvEventInvites;
        private Button btnRefresh;
        private Button btnViewAnswered;
        private DataGridViewTextBoxColumn SurveyName;
        private DataGridViewTextBoxColumn SurveyDateTime;
        private DataGridViewTextBoxColumn SurveyCreator;
        private DataGridViewTextBoxColumn SurveyName1;
        private DataGridViewTextBoxColumn DateTime1;
        private DataGridViewTextBoxColumn SurveyCreator1;
    }
}
