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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventBindingSource = new BindingSource(components);
            btnAccept = new Button();
            btnDecline = new Button();
            btnRefresh = new Button();
            btnView = new Button();
            dgvAcceptedInvites = new DataGridView();
            eventNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lblInvites = new Label();
            lblAcceptedInvites = new Label();
            tbCategory = new TextBox();
            radioButtonFilterByCategory = new RadioButton();
            dateTimePickerFilter = new DateTimePicker();
            buttonSearch = new Button();
            radioButtonDate = new RadioButton();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            lblDeclinedInvites = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.AllowUserToAddRows = false;
            dgvEventInvites.AllowUserToDeleteRows = false;
            dgvEventInvites.AutoGenerateColumns = false;
            dgvEventInvites.BackgroundColor = Color.PapayaWhip;
            dgvEventInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Columns.AddRange(new DataGridViewColumn[] { eventNameDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, eventDateTimeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dgvEventInvites.DataSource = eventBindingSource;
            dgvEventInvites.Location = new Point(3, 52);
            dgvEventInvites.Name = "dgvEventInvites";
            dgvEventInvites.ReadOnly = true;
            dgvEventInvites.RowTemplate.Height = 25;
            dgvEventInvites.ScrollBars = ScrollBars.Vertical;
            dgvEventInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventInvites.Size = new Size(902, 160);
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "EventName";
            dataGridViewTextBoxColumn1.HeaderText = "EventName";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 240;
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
            dgvAcceptedInvites.Columns.AddRange(new DataGridViewColumn[] { eventNameDataGridViewTextBoxColumn1, Category, eventDateTimeDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1 });
            dgvAcceptedInvites.DataSource = eventBindingSource;
            dgvAcceptedInvites.Location = new Point(3, 250);
            dgvAcceptedInvites.Name = "dgvAcceptedInvites";
            dgvAcceptedInvites.ReadOnly = true;
            dgvAcceptedInvites.RowTemplate.Height = 25;
            dgvAcceptedInvites.ScrollBars = ScrollBars.Vertical;
            dgvAcceptedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptedInvites.Size = new Size(902, 160);
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
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
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
            lblAcceptedInvites.Location = new Point(354, 216);
            lblAcceptedInvites.Name = "lblAcceptedInvites";
            lblAcceptedInvites.Size = new Size(136, 21);
            lblAcceptedInvites.TabIndex = 7;
            lblAcceptedInvites.Text = "Accepted Invites";
            // 
            // tbCategory
            // 
            tbCategory.Enabled = false;
            tbCategory.Location = new Point(930, 313);
            tbCategory.Name = "tbCategory";
            tbCategory.PlaceholderText = "Category Name";
            tbCategory.Size = new Size(169, 23);
            tbCategory.TabIndex = 8;
            // 
            // radioButtonFilterByCategory
            // 
            radioButtonFilterByCategory.AutoSize = true;
            radioButtonFilterByCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonFilterByCategory.ForeColor = SystemColors.HotTrack;
            radioButtonFilterByCategory.Location = new Point(945, 288);
            radioButtonFilterByCategory.Name = "radioButtonFilterByCategory";
            radioButtonFilterByCategory.Size = new Size(117, 19);
            radioButtonFilterByCategory.TabIndex = 12;
            radioButtonFilterByCategory.TabStop = true;
            radioButtonFilterByCategory.Text = "Filter By Category";
            radioButtonFilterByCategory.UseVisualStyleBackColor = true;
            radioButtonFilterByCategory.CheckedChanged += radioButtonFilterByCategory_CheckedChanged;
            // 
            // dateTimePickerFilter
            // 
            dateTimePickerFilter.Enabled = false;
            dateTimePickerFilter.Location = new Point(930, 367);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(194, 23);
            dateTimePickerFilter.TabIndex = 14;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.YellowGreen;
            buttonSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.DarkGreen;
            buttonSearch.Location = new Point(983, 405);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 30);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // radioButtonDate
            // 
            radioButtonDate.AutoSize = true;
            radioButtonDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonDate.ForeColor = SystemColors.HotTrack;
            radioButtonDate.Location = new Point(945, 342);
            radioButtonDate.Name = "radioButtonDate";
            radioButtonDate.Size = new Size(95, 19);
            radioButtonDate.TabIndex = 16;
            radioButtonDate.TabStop = true;
            radioButtonDate.Text = "Filter By Date";
            radioButtonDate.UseVisualStyleBackColor = true;
            radioButtonDate.CheckedChanged += radioButtonDate_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.PapayaWhip;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.DataSource = eventBindingSource;
            dataGridView1.Location = new Point(3, 446);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(902, 160);
            dataGridView1.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "EventName";
            dataGridViewTextBoxColumn2.HeaderText = "EventName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 240;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            dataGridViewTextBoxColumn3.HeaderText = "Category";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "EventDateTime";
            dataGridViewTextBoxColumn4.HeaderText = "EventDateTime";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 240;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            dataGridViewTextBoxColumn5.HeaderText = "Description";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 430;
            // 
            // lblDeclinedInvites
            // 
            lblDeclinedInvites.AutoSize = true;
            lblDeclinedInvites.BackColor = SystemColors.Control;
            lblDeclinedInvites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeclinedInvites.ForeColor = Color.DarkOrange;
            lblDeclinedInvites.Location = new Point(354, 414);
            lblDeclinedInvites.Name = "lblDeclinedInvites";
            lblDeclinedInvites.Size = new Size(133, 21);
            lblDeclinedInvites.TabIndex = 18;
            lblDeclinedInvites.Text = "Declined Invites";
            // 
            // ucEventInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDeclinedInvites);
            Controls.Add(dataGridView1);
            Controls.Add(radioButtonDate);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePickerFilter);
            Controls.Add(radioButtonFilterByCategory);
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
            Size = new Size(1134, 620);
            Load += ucEventInvites_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox tbCategory;
        private DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private RadioButton radioButtonFilterByCategory;
        private DateTimePicker dateTimePickerFilter;
        private Button buttonSearch;
        private RadioButton radioButtonDate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label lblDeclinedInvites;
    }
}
