namespace TeaLeaves.Views
{
    partial class ViewEventForm
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
            tableLayoutPanelAddEvent = new TableLayoutPanel();
            labelName = new Label();
            labelEVenue = new Label();
            labelEDate = new Label();
            labelETime = new Label();
            labelEDescription = new Label();
            tbName = new TextBox();
            tbAddress = new TextBox();
            tbDescription = new RichTextBox();
            tbDate = new TextBox();
            tbTime = new TextBox();
            btnBack = new Button();
            lblEventResponsibilities = new Label();
            dgvUnassignedResponsibilities = new DataGridView();
            ResponsibilityName = new DataGridViewTextBoxColumn();
            lblUnassignedResponsibilities = new Label();
            tableLayoutPanelAddEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnassignedResponsibilities).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelAddEvent
            // 
            tableLayoutPanelAddEvent.BackColor = Color.WhiteSmoke;
            tableLayoutPanelAddEvent.ColumnCount = 6;
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.625F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.125F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.75F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.125F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.375F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanelAddEvent.Controls.Add(labelName, 0, 0);
            tableLayoutPanelAddEvent.Controls.Add(labelEVenue, 0, 1);
            tableLayoutPanelAddEvent.Controls.Add(labelEDate, 0, 2);
            tableLayoutPanelAddEvent.Controls.Add(labelETime, 0, 3);
            tableLayoutPanelAddEvent.Controls.Add(labelEDescription, 0, 4);
            tableLayoutPanelAddEvent.Controls.Add(tbName, 1, 0);
            tableLayoutPanelAddEvent.Controls.Add(tbAddress, 1, 1);
            tableLayoutPanelAddEvent.Controls.Add(tbDescription, 1, 4);
            tableLayoutPanelAddEvent.Controls.Add(tbDate, 1, 2);
            tableLayoutPanelAddEvent.Controls.Add(tbTime, 1, 3);
            tableLayoutPanelAddEvent.Controls.Add(btnBack, 0, 7);
            tableLayoutPanelAddEvent.Controls.Add(lblEventResponsibilities, 0, 6);
            tableLayoutPanelAddEvent.Controls.Add(dgvUnassignedResponsibilities, 1, 6);
            tableLayoutPanelAddEvent.Controls.Add(lblUnassignedResponsibilities, 1, 5);
            tableLayoutPanelAddEvent.Dock = DockStyle.Fill;
            tableLayoutPanelAddEvent.Location = new Point(0, 0);
            tableLayoutPanelAddEvent.Name = "tableLayoutPanelAddEvent";
            tableLayoutPanelAddEvent.RowCount = 7;
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.01322F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0132141F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0132141F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0132141F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3553581F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 8.2232F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3553581F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.01321F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelAddEvent.Size = new Size(879, 450);
            tableLayoutPanelAddEvent.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.DarkGreen;
            labelName.Location = new Point(3, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(210, 21);
            labelName.TabIndex = 0;
            labelName.Text = "Event Name:";
            // 
            // labelEVenue
            // 
            labelEVenue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEVenue.AutoSize = true;
            labelEVenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEVenue.ForeColor = Color.DarkGreen;
            labelEVenue.Location = new Point(3, 63);
            labelEVenue.Name = "labelEVenue";
            labelEVenue.Size = new Size(210, 21);
            labelEVenue.TabIndex = 1;
            labelEVenue.Text = "Event Venue:";
            // 
            // labelEDate
            // 
            labelEDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEDate.AutoSize = true;
            labelEDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDate.ForeColor = Color.DarkGreen;
            labelEDate.Location = new Point(3, 112);
            labelEDate.Name = "labelEDate";
            labelEDate.Size = new Size(210, 21);
            labelEDate.TabIndex = 2;
            labelEDate.Text = "Event Date:";
            // 
            // labelETime
            // 
            labelETime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelETime.AutoSize = true;
            labelETime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelETime.ForeColor = Color.DarkGreen;
            labelETime.Location = new Point(3, 161);
            labelETime.Name = "labelETime";
            labelETime.Size = new Size(210, 21);
            labelETime.TabIndex = 3;
            labelETime.Text = "Event Time:";
            // 
            // labelEDescription
            // 
            labelEDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEDescription.AutoSize = true;
            labelEDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDescription.ForeColor = Color.DarkGreen;
            labelEDescription.Location = new Point(3, 226);
            labelEDescription.Name = "labelEDescription";
            labelEDescription.Size = new Size(210, 21);
            labelEDescription.TabIndex = 4;
            labelEDescription.Text = "Event Description:";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbName, 4);
            tbName.Location = new Point(219, 13);
            tbName.MaxLength = 100;
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(531, 23);
            tbName.TabIndex = 1;
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbAddress, 4);
            tbAddress.Location = new Point(219, 62);
            tbAddress.MaxLength = 50;
            tbAddress.Name = "tbAddress";
            tbAddress.ReadOnly = true;
            tbAddress.Size = new Size(531, 23);
            tbAddress.TabIndex = 2;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbDescription, 4);
            tbDescription.Location = new Point(219, 200);
            tbDescription.MaxLength = 250;
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.Size = new Size(531, 74);
            tbDescription.TabIndex = 9;
            tbDescription.Text = "";
            // 
            // tbDate
            // 
            tbDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbDate, 2);
            tbDate.Location = new Point(219, 111);
            tbDate.MaxLength = 50;
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(273, 23);
            tbDate.TabIndex = 18;
            // 
            // tbTime
            // 
            tbTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbTime, 2);
            tbTime.Location = new Point(219, 160);
            tbTime.MaxLength = 25;
            tbTime.Name = "tbTime";
            tbTime.ReadOnly = true;
            tbTime.Size = new Size(273, 23);
            tbTime.TabIndex = 19;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DarkGreen;
            btnBack.Location = new Point(20, 400);
            btnBack.Margin = new Padding(20, 3, 3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 39);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblEventResponsibilities
            // 
            lblEventResponsibilities.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEventResponsibilities.AutoSize = true;
            lblEventResponsibilities.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEventResponsibilities.ForeColor = Color.DarkGreen;
            lblEventResponsibilities.Location = new Point(3, 345);
            lblEventResponsibilities.Name = "lblEventResponsibilities";
            lblEventResponsibilities.Size = new Size(210, 21);
            lblEventResponsibilities.TabIndex = 21;
            lblEventResponsibilities.Text = "Event Responsibilities:";
            // 
            // dgvUnassignedResponsibilities
            // 
            dgvUnassignedResponsibilities.BackgroundColor = Color.PapayaWhip;
            dgvUnassignedResponsibilities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnassignedResponsibilities.Columns.AddRange(new DataGridViewColumn[] { ResponsibilityName });
            tableLayoutPanelAddEvent.SetColumnSpan(dgvUnassignedResponsibilities, 2);
            dgvUnassignedResponsibilities.Location = new Point(219, 318);
            dgvUnassignedResponsibilities.Name = "dgvUnassignedResponsibilities";
            dgvUnassignedResponsibilities.ReadOnly = true;
            tableLayoutPanelAddEvent.SetRowSpan(dgvUnassignedResponsibilities, 2);
            dgvUnassignedResponsibilities.RowTemplate.Height = 40;
            dgvUnassignedResponsibilities.Size = new Size(273, 129);
            dgvUnassignedResponsibilities.TabIndex = 23;
            // 
            // ResponsibilityName
            // 
            ResponsibilityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ResponsibilityName.DataPropertyName = "Name";
            ResponsibilityName.HeaderText = "Name";
            ResponsibilityName.Name = "ResponsibilityName";
            ResponsibilityName.ReadOnly = true;
            // 
            // lblUnassignedResponsibilities
            // 
            lblUnassignedResponsibilities.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUnassignedResponsibilities.AutoSize = true;
            tableLayoutPanelAddEvent.SetColumnSpan(lblUnassignedResponsibilities, 2);
            lblUnassignedResponsibilities.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnassignedResponsibilities.ForeColor = Color.DarkGreen;
            lblUnassignedResponsibilities.Location = new Point(219, 286);
            lblUnassignedResponsibilities.Name = "lblUnassignedResponsibilities";
            lblUnassignedResponsibilities.Size = new Size(273, 21);
            lblUnassignedResponsibilities.TabIndex = 25;
            lblUnassignedResponsibilities.Text = "Unassigned Responsibilities";
            // 
            // ViewEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 450);
            Controls.Add(tableLayoutPanelAddEvent);
            Name = "ViewEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEventForm";
            Load += ViewEventForm_Load;
            tableLayoutPanelAddEvent.ResumeLayout(false);
            tableLayoutPanelAddEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnassignedResponsibilities).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAddEvent;
        private Label labelName;
        private Label labelEVenue;
        private Label labelEDate;
        private Label labelETime;
        private Label labelEDescription;
        private TextBox tbName;
        private TextBox tbAddress;
        private RichTextBox tbDescription;
        private TextBox tbDate;
        private TextBox tbTime;
        private Button btnBack;
        private Label lblEventResponsibilities;
        private DataGridView dgvUnassignedResponsibilities;
        private Label lblUnassignedResponsibilities;
        private DataGridViewTextBoxColumn ResponsibilityName;
    }
}