namespace TeaLeaves.UserControls
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
            btnInvites = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            buttonAdd = new Button();
            dataGridViewSurvey = new DataGridView();
            SurveyName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            panelSurveyHeader = new Panel();
            lblMySurveys = new Label();
            tableLayoutPanelSurvey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSurvey).BeginInit();
            panelSurveyHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelSurvey
            // 
            tableLayoutPanelSurvey.ColumnCount = 3;
            tableLayoutPanelSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelSurvey.Controls.Add(btnInvites, 1, 4);
            tableLayoutPanelSurvey.Controls.Add(btnDelete, 1, 3);
            tableLayoutPanelSurvey.Controls.Add(btnEdit, 1, 2);
            tableLayoutPanelSurvey.Controls.Add(buttonAdd, 1, 1);
            tableLayoutPanelSurvey.Controls.Add(dataGridViewSurvey, 0, 1);
            tableLayoutPanelSurvey.Controls.Add(panelSurveyHeader, 0, 0);
            tableLayoutPanelSurvey.Dock = DockStyle.Fill;
            tableLayoutPanelSurvey.Location = new Point(0, 0);
            tableLayoutPanelSurvey.Name = "tableLayoutPanelSurvey";
            tableLayoutPanelSurvey.RowCount = 6;
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelSurvey.Size = new Size(694, 442);
            tableLayoutPanelSurvey.TabIndex = 0;
            // 
            // btnInvites
            // 
            btnInvites.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnInvites.BackColor = Color.Orange;
            btnInvites.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvites.ForeColor = Color.DarkGreen;
            btnInvites.Location = new Point(454, 329);
            btnInvites.Name = "btnInvites";
            btnInvites.Size = new Size(132, 46);
            btnInvites.TabIndex = 3;
            btnInvites.Text = "Invites";
            btnInvites.UseVisualStyleBackColor = false;
            btnInvites.Click += btnInvites_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Orange;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkGreen;
            btnDelete.Location = new Point(454, 241);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.BackColor = Color.Orange;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.DarkGreen;
            btnEdit.Location = new Point(454, 153);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 46);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.BackColor = Color.Orange;
            buttonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.DarkGreen;
            buttonAdd.Location = new Point(454, 66);
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
            dataGridViewSurvey.Location = new Point(3, 47);
            dataGridViewSurvey.Name = "dataGridViewSurvey";
            dataGridViewSurvey.ReadOnly = true;
            tableLayoutPanelSurvey.SetRowSpan(dataGridViewSurvey, 4);
            dataGridViewSurvey.RowTemplate.Height = 25;
            dataGridViewSurvey.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSurvey.Size = new Size(445, 346);
            dataGridViewSurvey.TabIndex = 0;
            // 
            // SurveyName
            // 
            SurveyName.DataPropertyName = "SurveyName";
            SurveyName.HeaderText = "Name";
            SurveyName.Name = "SurveyName";
            SurveyName.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "SurveyDateTime";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // panelSurveyHeader
            // 
            panelSurveyHeader.BackColor = Color.DarkOrange;
            tableLayoutPanelSurvey.SetColumnSpan(panelSurveyHeader, 2);
            panelSurveyHeader.Controls.Add(lblMySurveys);
            panelSurveyHeader.Location = new Point(3, 3);
            panelSurveyHeader.Name = "panelSurveyHeader";
            panelSurveyHeader.Size = new Size(583, 38);
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
    }
}
