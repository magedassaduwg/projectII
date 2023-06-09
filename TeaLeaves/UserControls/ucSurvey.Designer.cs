﻿namespace TeaLeaves.UserControls
{
    partial class ucSurvey
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
            tableLayoutPanelSurvey = new TableLayoutPanel();
            btnEdit = new Button();
            buttonAdd = new Button();
            dataGridViewSurvey = new DataGridView();
            SurveyName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            panelSurveyHeader = new Panel();
            lblMySurveys = new Label();
            btnDelete = new Button();
            btnInvites = new Button();
            surveyResult = new Button();
            tableLayoutPanelSurvey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSurvey).BeginInit();
            panelSurveyHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelSurvey
            // 
            tableLayoutPanelSurvey.ColumnCount = 4;
            tableLayoutPanelSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.Controls.Add(btnEdit, 2, 2);
            tableLayoutPanelSurvey.Controls.Add(buttonAdd, 2, 1);
            tableLayoutPanelSurvey.Controls.Add(dataGridViewSurvey, 1, 1);
            tableLayoutPanelSurvey.Controls.Add(panelSurveyHeader, 1, 0);
            tableLayoutPanelSurvey.Controls.Add(btnDelete, 2, 5);
            tableLayoutPanelSurvey.Controls.Add(btnInvites, 2, 3);
            tableLayoutPanelSurvey.Controls.Add(surveyResult, 2, 4);
            tableLayoutPanelSurvey.Dock = DockStyle.Fill;
            tableLayoutPanelSurvey.Location = new Point(0, 0);
            tableLayoutPanelSurvey.Name = "tableLayoutPanelSurvey";
            tableLayoutPanelSurvey.RowCount = 8;
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelSurvey.Size = new Size(694, 442);
            tableLayoutPanelSurvey.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.BackColor = Color.Orange;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.DarkGreen;
            btnEdit.Location = new Point(454, 113);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 46);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.BackColor = Color.Orange;
            buttonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.DarkGreen;
            buttonAdd.Location = new Point(454, 52);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(132, 43);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewSurvey
            // 
            dataGridViewSurvey.AllowUserToAddRows = false;
            dataGridViewSurvey.AllowUserToDeleteRows = false;
            dataGridViewSurvey.BackgroundColor = Color.PapayaWhip;
            dataGridViewSurvey.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSurvey.Columns.AddRange(new DataGridViewColumn[] { SurveyName, Date });
            dataGridViewSurvey.Dock = DockStyle.Fill;
            dataGridViewSurvey.Location = new Point(107, 45);
            dataGridViewSurvey.Name = "dataGridViewSurvey";
            dataGridViewSurvey.ReadOnly = true;
            tableLayoutPanelSurvey.SetRowSpan(dataGridViewSurvey, 5);
            dataGridViewSurvey.RowTemplate.Height = 40;
            dataGridViewSurvey.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSurvey.Size = new Size(341, 309);
            dataGridViewSurvey.TabIndex = 6;
            // 
            // SurveyName
            // 
            SurveyName.DataPropertyName = "SurveyName";
            SurveyName.HeaderText = "Name";
            SurveyName.Name = "SurveyName";
            SurveyName.ReadOnly = true;
            SurveyName.Width = 390;
            // 
            // Date
            // 
            Date.DataPropertyName = "SurveyDateTime";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 200;
            // 
            // panelSurveyHeader
            // 
            panelSurveyHeader.BackColor = Color.DarkOrange;
            tableLayoutPanelSurvey.SetColumnSpan(panelSurveyHeader, 2);
            panelSurveyHeader.Controls.Add(lblMySurveys);
            panelSurveyHeader.Location = new Point(107, 3);
            panelSurveyHeader.Name = "panelSurveyHeader";
            panelSurveyHeader.Size = new Size(479, 36);
            panelSurveyHeader.TabIndex = 1;
            // 
            // lblMySurveys
            // 
            lblMySurveys.AutoSize = true;
            lblMySurveys.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMySurveys.ForeColor = Color.DarkGreen;
            lblMySurveys.Location = new Point(16, 0);
            lblMySurveys.Name = "lblMySurveys";
            lblMySurveys.Size = new Size(134, 32);
            lblMySurveys.TabIndex = 0;
            lblMySurveys.Text = "My Surveys";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Orange;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkGreen;
            btnDelete.Location = new Point(454, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInvites
            // 
            btnInvites.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnInvites.BackColor = Color.Orange;
            btnInvites.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvites.ForeColor = Color.DarkGreen;
            btnInvites.Location = new Point(454, 176);
            btnInvites.Name = "btnInvites";
            btnInvites.Size = new Size(132, 46);
            btnInvites.TabIndex = 3;
            btnInvites.Text = "Invites";
            btnInvites.UseVisualStyleBackColor = false;
            btnInvites.Click += btnInvites_Click;
            // 
            // surveyResult
            // 
            surveyResult.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            surveyResult.BackColor = Color.Orange;
            surveyResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            surveyResult.ForeColor = Color.DarkGreen;
            surveyResult.Location = new Point(454, 239);
            surveyResult.Name = "surveyResult";
            surveyResult.Size = new Size(132, 46);
            surveyResult.TabIndex = 4;
            surveyResult.Text = "Survey Result";
            surveyResult.UseVisualStyleBackColor = false;
            surveyResult.Click += surveyResult_Click;
            // 
            // ucSurvey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelSurvey);
            Name = "ucSurvey";
            Size = new Size(694, 442);
            Load += ucSurvey_Load;
            tableLayoutPanelSurvey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSurvey).EndInit();
            panelSurveyHeader.ResumeLayout(false);
            panelSurveyHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelSurvey;
        private DataGridView dataGridViewSurvey;
        private Panel panelSurveyHeader;
        private Label lblMySurveys;
        private Button buttonAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnInvites;
        private DataGridViewTextBoxColumn SurveyName;
        private DataGridViewTextBoxColumn Date;
        private Button surveyResult;
    }
}
