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
            components = new System.ComponentModel.Container();
            dgvEventInvites = new DataGridView();
            eventNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventBindingSource = new BindingSource(components);
            btnAccept = new Button();
            btnDecline = new Button();
            btnRefresh = new Button();
            btnView = new Button();
            dgvAcceptedInvites = new DataGridView();
            eventNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lblInvites = new Label();
            lblAcceptedInvites = new Label();
            tbCategory = new TextBox();
            tbDate = new TextBox();
            lblFilterByCategory = new Label();
            lblFilterByDateTime = new Label();
            lblCategoryError = new Label();
            label2 = new Label();
            dgvDeclines = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblDeclineInvites = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeclines).BeginInit();
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
            dgvEventInvites.Size = new Size(953, 140);
            dgvEventInvites.TabIndex = 0;
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
            dgvAcceptedInvites.Location = new Point(3, 244);
            dgvAcceptedInvites.Name = "dgvAcceptedInvites";
            dgvAcceptedInvites.ReadOnly = true;
            dgvAcceptedInvites.RowTemplate.Height = 25;
            dgvAcceptedInvites.ScrollBars = ScrollBars.Vertical;
            dgvAcceptedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptedInvites.Size = new Size(953, 140);
            dgvAcceptedInvites.TabIndex = 5;
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
            lblAcceptedInvites.Location = new Point(354, 210);
            lblAcceptedInvites.Name = "lblAcceptedInvites";
            lblAcceptedInvites.Size = new Size(136, 21);
            lblAcceptedInvites.TabIndex = 7;
            lblAcceptedInvites.Text = "Accepted Invites";
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(962, 304);
            tbCategory.Name = "tbCategory";
            tbCategory.PlaceholderText = "Category Name";
            tbCategory.Size = new Size(169, 23);
            tbCategory.TabIndex = 8;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(962, 387);
            tbDate.Name = "tbDate";
            tbDate.PlaceholderText = "YYYY-MM-DD HH-MM-SS";
            tbDate.Size = new Size(169, 23);
            tbDate.TabIndex = 9;
            // 
            // lblFilterByCategory
            // 
            lblFilterByCategory.AutoSize = true;
            lblFilterByCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilterByCategory.Location = new Point(983, 280);
            lblFilterByCategory.Name = "lblFilterByCategory";
            lblFilterByCategory.Size = new Size(133, 21);
            lblFilterByCategory.TabIndex = 10;
            lblFilterByCategory.Text = "Filter By Category";
            // 
            // lblFilterByDateTime
            // 
            lblFilterByDateTime.AutoSize = true;
            lblFilterByDateTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilterByDateTime.Location = new Point(962, 363);
            lblFilterByDateTime.Name = "lblFilterByDateTime";
            lblFilterByDateTime.Size = new Size(172, 21);
            lblFilterByDateTime.TabIndex = 11;
            lblFilterByDateTime.Text = "Filter By Date And Time";
            // 
            // lblCategoryError
            // 
            lblCategoryError.AutoSize = true;
            lblCategoryError.BackColor = SystemColors.Control;
            lblCategoryError.Location = new Point(1026, 339);
            lblCategoryError.Name = "lblCategoryError";
            lblCategoryError.Size = new Size(38, 15);
            lblCategoryError.TabIndex = 12;
            lblCategoryError.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1026, 422);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // dgvDeclines
            // 
            dgvDeclines.AllowUserToAddRows = false;
            dgvDeclines.AllowUserToDeleteRows = false;
            dgvDeclines.AutoGenerateColumns = false;
            dgvDeclines.BackgroundColor = Color.PapayaWhip;
            dgvDeclines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeclines.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvDeclines.DataSource = eventBindingSource;
            dgvDeclines.Location = new Point(3, 442);
            dgvDeclines.Name = "dgvDeclines";
            dgvDeclines.ReadOnly = true;
            dgvDeclines.RowTemplate.Height = 25;
            dgvDeclines.ScrollBars = ScrollBars.Vertical;
            dgvDeclines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeclines.Size = new Size(953, 140);
            dgvDeclines.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "EventName";
            dataGridViewTextBoxColumn1.HeaderText = "EventName";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 240;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "EventDateTime";
            dataGridViewTextBoxColumn2.HeaderText = "EventDateTime";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 240;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 430;
            // 
            // lblDeclineInvites
            // 
            lblDeclineInvites.AutoSize = true;
            lblDeclineInvites.BackColor = SystemColors.Control;
            lblDeclineInvites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeclineInvites.ForeColor = Color.DarkOrange;
            lblDeclineInvites.Location = new Point(354, 404);
            lblDeclineInvites.Name = "lblDeclineInvites";
            lblDeclineInvites.Size = new Size(133, 21);
            lblDeclineInvites.TabIndex = 15;
            lblDeclineInvites.Text = "Declined Invites";
            // 
            // ucEventInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDeclineInvites);
            Controls.Add(dgvDeclines);
            Controls.Add(label2);
            Controls.Add(lblCategoryError);
            Controls.Add(lblFilterByDateTime);
            Controls.Add(lblFilterByCategory);
            Controls.Add(tbDate);
            Controls.Add(tbCategory);
            Controls.Add(lblAcceptedInvites);
            Controls.Add(lblInvites);
            Controls.Add(dgvAcceptedInvites);
            Controls.Add(btnView);
            Controls.Add(btnRefresh);
            Controls.Add(btnDecline);
            Controls.Add(btnAccept);
            Controls.Add(dgvEventInvites);
            Name = "ucEventInvites";
            Size = new Size(1134, 585);
            Load += ucEventInvites_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeclines).EndInit();
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
        private TextBox tbCategory;
        private TextBox tbDate;
        private Label lblFilterByCategory;
        private Label lblFilterByDateTime;
        private Label lblCategoryError;
        private Label label2;
        private DataGridView dgvDeclines;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblDeclineInvites;
    }
}
