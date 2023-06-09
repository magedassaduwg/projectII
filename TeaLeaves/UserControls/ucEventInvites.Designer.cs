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
            eventNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CreatorName = new DataGridViewTextBoxColumn();
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
            CreatorName1 = new DataGridViewTextBoxColumn();
            lblInvites = new Label();
            lblAcceptedInvites = new Label();
            radioButtonFilterByCategory = new RadioButton();
            dateTimePickerFilter = new DateTimePicker();
            buttonSearch = new Button();
            radioButtonDate = new RadioButton();
            dgvDeclinedInvites = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            CreatorName2 = new DataGridViewTextBoxColumn();
            lblDeclinedInvites = new Label();
            tbCategory = new ComboBox();
            btnViewAccepted = new Button();
            btnPastEvents = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcceptedInvites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeclinedInvites).BeginInit();
            SuspendLayout();
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.AllowUserToAddRows = false;
            dgvEventInvites.AllowUserToDeleteRows = false;
            dgvEventInvites.AutoGenerateColumns = false;
            dgvEventInvites.BackgroundColor = Color.PapayaWhip;
            dgvEventInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Columns.AddRange(new DataGridViewColumn[] { eventNameDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, eventDateTimeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, CreatorName });
            dgvEventInvites.DataSource = eventBindingSource;
            dgvEventInvites.Location = new Point(3, 52);
            dgvEventInvites.Name = "dgvEventInvites";
            dgvEventInvites.ReadOnly = true;
            dgvEventInvites.RowTemplate.Height = 40;
            dgvEventInvites.ScrollBars = ScrollBars.Vertical;
            dgvEventInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventInvites.Size = new Size(902, 160);
            dgvEventInvites.TabIndex = 11;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            eventNameDataGridViewTextBoxColumn.ReadOnly = true;
            eventNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Category";
            dataGridViewTextBoxColumn1.HeaderText = "Category";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eventDateTimeDataGridViewTextBoxColumn
            // 
            eventDateTimeDataGridViewTextBoxColumn.DataPropertyName = "EventDateTime";
            eventDateTimeDataGridViewTextBoxColumn.HeaderText = "EventDateTime";
            eventDateTimeDataGridViewTextBoxColumn.Name = "eventDateTimeDataGridViewTextBoxColumn";
            eventDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            eventDateTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // CreatorName
            // 
            CreatorName.DataPropertyName = "CreatorName";
            CreatorName.HeaderText = "CreatorName";
            CreatorName.Name = "CreatorName";
            CreatorName.ReadOnly = true;
            CreatorName.Width = 180;
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
            btnAccept.TabIndex = 0;
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
            btnDecline.TabIndex = 1;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = false;
            btnDecline.Click += btnDecline_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Orange;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.DarkGreen;
            btnRefresh.Location = new Point(983, 277);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 57);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "No Filter";
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
            btnView.TabIndex = 2;
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
            dgvAcceptedInvites.Columns.AddRange(new DataGridViewColumn[] { eventNameDataGridViewTextBoxColumn1, Category, eventDateTimeDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, CreatorName1 });
            dgvAcceptedInvites.DataSource = eventBindingSource;
            dgvAcceptedInvites.Location = new Point(3, 250);
            dgvAcceptedInvites.Name = "dgvAcceptedInvites";
            dgvAcceptedInvites.ReadOnly = true;
            dgvAcceptedInvites.RowTemplate.Height = 40;
            dgvAcceptedInvites.ScrollBars = ScrollBars.Vertical;
            dgvAcceptedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcceptedInvites.Size = new Size(902, 160);
            dgvAcceptedInvites.TabIndex = 12;
            // 
            // eventNameDataGridViewTextBoxColumn1
            // 
            eventNameDataGridViewTextBoxColumn1.DataPropertyName = "EventName";
            eventNameDataGridViewTextBoxColumn1.HeaderText = "EventName";
            eventNameDataGridViewTextBoxColumn1.Name = "eventNameDataGridViewTextBoxColumn1";
            eventNameDataGridViewTextBoxColumn1.ReadOnly = true;
            eventNameDataGridViewTextBoxColumn1.Width = 180;
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
            eventDateTimeDataGridViewTextBoxColumn1.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn1.Width = 200;
            // 
            // CreatorName1
            // 
            CreatorName1.DataPropertyName = "CreatorName";
            CreatorName1.HeaderText = "CreatorName";
            CreatorName1.Name = "CreatorName1";
            CreatorName1.ReadOnly = true;
            CreatorName1.Width = 180;
            // 
            // lblInvites
            // 
            lblInvites.AutoSize = true;
            lblInvites.BackColor = SystemColors.Control;
            lblInvites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvites.ForeColor = Color.DarkOrange;
            lblInvites.Location = new Point(354, 22);
            lblInvites.Name = "lblInvites";
            lblInvites.Size = new Size(129, 21);
            lblInvites.TabIndex = 6;
            lblInvites.Text = "Pending Invites";
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
            // radioButtonFilterByCategory
            // 
            radioButtonFilterByCategory.AutoSize = true;
            radioButtonFilterByCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonFilterByCategory.ForeColor = SystemColors.HotTrack;
            radioButtonFilterByCategory.Location = new Point(945, 354);
            radioButtonFilterByCategory.Name = "radioButtonFilterByCategory";
            radioButtonFilterByCategory.Size = new Size(117, 19);
            radioButtonFilterByCategory.TabIndex = 5;
            radioButtonFilterByCategory.TabStop = true;
            radioButtonFilterByCategory.Text = "Filter By Category";
            radioButtonFilterByCategory.UseVisualStyleBackColor = true;
            radioButtonFilterByCategory.CheckedChanged += radioButtonFilterByCategory_CheckedChanged;
            // 
            // dateTimePickerFilter
            // 
            dateTimePickerFilter.Enabled = false;
            dateTimePickerFilter.Location = new Point(930, 433);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(194, 23);
            dateTimePickerFilter.TabIndex = 8;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.YellowGreen;
            buttonSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.DarkGreen;
            buttonSearch.Location = new Point(983, 471);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 30);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // radioButtonDate
            // 
            radioButtonDate.AutoSize = true;
            radioButtonDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonDate.ForeColor = SystemColors.HotTrack;
            radioButtonDate.Location = new Point(945, 408);
            radioButtonDate.Name = "radioButtonDate";
            radioButtonDate.Size = new Size(95, 19);
            radioButtonDate.TabIndex = 7;
            radioButtonDate.TabStop = true;
            radioButtonDate.Text = "Filter By Date";
            radioButtonDate.UseVisualStyleBackColor = true;
            radioButtonDate.CheckedChanged += radioButtonDate_CheckedChanged;
            // 
            // dgvDeclinedInvites
            // 
            dgvDeclinedInvites.AllowUserToAddRows = false;
            dgvDeclinedInvites.AllowUserToDeleteRows = false;
            dgvDeclinedInvites.AutoGenerateColumns = false;
            dgvDeclinedInvites.BackgroundColor = Color.PapayaWhip;
            dgvDeclinedInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeclinedInvites.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, CreatorName2 });
            dgvDeclinedInvites.DataSource = eventBindingSource;
            dgvDeclinedInvites.Location = new Point(3, 446);
            dgvDeclinedInvites.Name = "dgvDeclinedInvites";
            dgvDeclinedInvites.ReadOnly = true;
            dgvDeclinedInvites.RowTemplate.Height = 40;
            dgvDeclinedInvites.ScrollBars = ScrollBars.Vertical;
            dgvDeclinedInvites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeclinedInvites.Size = new Size(902, 160);
            dgvDeclinedInvites.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "EventName";
            dataGridViewTextBoxColumn2.HeaderText = "EventName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 180;
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
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            dataGridViewTextBoxColumn5.HeaderText = "Description";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // CreatorName2
            // 
            CreatorName2.DataPropertyName = "CreatorName";
            CreatorName2.HeaderText = "CreatorName";
            CreatorName2.Name = "CreatorName2";
            CreatorName2.ReadOnly = true;
            CreatorName2.Width = 180;
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
            // tbCategory
            // 
            tbCategory.Enabled = false;
            tbCategory.FormattingEnabled = true;
            tbCategory.Location = new Point(930, 383);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(194, 23);
            tbCategory.TabIndex = 6;
            // 
            // btnViewAccepted
            // 
            btnViewAccepted.BackColor = Color.Orange;
            btnViewAccepted.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewAccepted.ForeColor = Color.DarkGreen;
            btnViewAccepted.Location = new Point(983, 211);
            btnViewAccepted.Name = "btnViewAccepted";
            btnViewAccepted.Size = new Size(126, 57);
            btnViewAccepted.TabIndex = 3;
            btnViewAccepted.Text = "View Accepted";
            btnViewAccepted.UseVisualStyleBackColor = false;
            btnViewAccepted.Click += btnResponsibilities_Click;
            // 
            // btnPastEvents
            // 
            btnPastEvents.BackColor = Color.YellowGreen;
            btnPastEvents.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnPastEvents.ForeColor = Color.DarkGreen;
            btnPastEvents.Location = new Point(945, 528);
            btnPastEvents.Name = "btnPastEvents";
            btnPastEvents.Size = new Size(151, 30);
            btnPastEvents.TabIndex = 10;
            btnPastEvents.Text = "View Past Events";
            btnPastEvents.UseVisualStyleBackColor = false;
            btnPastEvents.Click += btnPassedEvents_Click;
            // 
            // ucEventInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPastEvents);
            Controls.Add(btnViewAccepted);
            Controls.Add(tbCategory);
            Controls.Add(lblDeclinedInvites);
            Controls.Add(dgvDeclinedInvites);
            Controls.Add(radioButtonDate);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePickerFilter);
            Controls.Add(radioButtonFilterByCategory);
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
            ((System.ComponentModel.ISupportInitialize)dgvDeclinedInvites).EndInit();
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
        private RadioButton radioButtonFilterByCategory;
        private DateTimePicker dateTimePickerFilter;
        private Button buttonSearch;
        private RadioButton radioButtonDate;
        private DataGridView dgvDeclinedInvites;
        private Label lblDeclinedInvites;
        private ComboBox tbCategory;
        private Button btnViewAccepted;
        private DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CreatorName;
        private DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CreatorName1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn CreatorName2;
        private Button btnPastEvents;
    }
}
