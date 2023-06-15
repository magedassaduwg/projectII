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
            labelError = new Label();
            tbDate = new TextBox();
            tbTime = new TextBox();
            btnBack = new Button();
            tableLayoutPanelAddEvent.SuspendLayout();
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
            tableLayoutPanelAddEvent.Controls.Add(labelError, 2, 5);
            tableLayoutPanelAddEvent.Controls.Add(btnBack, 0, 5);
            tableLayoutPanelAddEvent.Dock = DockStyle.Fill;
            tableLayoutPanelAddEvent.Location = new Point(0, 0);
            tableLayoutPanelAddEvent.Name = "tableLayoutPanelAddEvent";
            tableLayoutPanelAddEvent.RowCount = 6;
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.Size = new Size(800, 450);
            tableLayoutPanelAddEvent.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.DarkGreen;
            labelName.Location = new Point(3, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(191, 21);
            labelName.TabIndex = 0;
            labelName.Text = "Event Name:";
            // 
            // labelEVenue
            // 
            labelEVenue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEVenue.AutoSize = true;
            labelEVenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEVenue.ForeColor = Color.DarkGreen;
            labelEVenue.Location = new Point(3, 90);
            labelEVenue.Name = "labelEVenue";
            labelEVenue.Size = new Size(191, 21);
            labelEVenue.TabIndex = 1;
            labelEVenue.Text = "Event Venue:";
            // 
            // labelEDate
            // 
            labelEDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEDate.AutoSize = true;
            labelEDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDate.ForeColor = Color.DarkGreen;
            labelEDate.Location = new Point(3, 157);
            labelEDate.Name = "labelEDate";
            labelEDate.Size = new Size(191, 21);
            labelEDate.TabIndex = 2;
            labelEDate.Text = "Event Date:";
            // 
            // labelETime
            // 
            labelETime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelETime.AutoSize = true;
            labelETime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelETime.ForeColor = Color.DarkGreen;
            labelETime.Location = new Point(3, 224);
            labelETime.Name = "labelETime";
            labelETime.Size = new Size(191, 21);
            labelETime.TabIndex = 3;
            labelETime.Text = "Event Time:";
            // 
            // labelEDescription
            // 
            labelEDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEDescription.AutoSize = true;
            labelEDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDescription.ForeColor = Color.DarkGreen;
            labelEDescription.Location = new Point(3, 313);
            labelEDescription.Name = "labelEDescription";
            labelEDescription.Size = new Size(191, 21);
            labelEDescription.TabIndex = 4;
            labelEDescription.Text = "Event Description:";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbName, 4);
            tbName.Location = new Point(200, 22);
            tbName.MaxLength = 100;
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(485, 23);
            tbName.TabIndex = 1;
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbAddress, 4);
            tbAddress.Location = new Point(200, 89);
            tbAddress.MaxLength = 50;
            tbAddress.Name = "tbAddress";
            tbAddress.ReadOnly = true;
            tbAddress.Size = new Size(485, 23);
            tbAddress.TabIndex = 2;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbDescription, 4);
            tbDescription.Location = new Point(200, 271);
            tbDescription.MaxLength = 250;
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.Size = new Size(485, 106);
            tbDescription.TabIndex = 9;
            tbDescription.Text = "";
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelError.AutoSize = true;
            tableLayoutPanelAddEvent.SetColumnSpan(labelError, 2);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(329, 407);
            labelError.Name = "labelError";
            labelError.Size = new Size(241, 15);
            labelError.TabIndex = 17;
            // 
            // tbDate
            // 
            tbDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbDate, 2);
            tbDate.Location = new Point(200, 156);
            tbDate.MaxLength = 50;
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(249, 23);
            tbDate.TabIndex = 18;
            // 
            // tbTime
            // 
            tbTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(tbTime, 2);
            tbTime.Location = new Point(200, 223);
            tbTime.MaxLength = 25;
            tbTime.Name = "tbTime";
            tbTime.ReadOnly = true;
            tbTime.Size = new Size(249, 23);
            tbTime.TabIndex = 19;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DarkGreen;
            btnBack.Location = new Point(20, 383);
            btnBack.Margin = new Padding(20, 3, 3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 39);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ViewEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelAddEvent);
            Name = "ViewEventForm";
            Text = "ViewEventForm";
            Load += ViewEventForm_Load;
            tableLayoutPanelAddEvent.ResumeLayout(false);
            tableLayoutPanelAddEvent.PerformLayout();
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
        private Label labelError;
        private TextBox tbDate;
        private TextBox tbTime;
        private Button btnBack;
    }
}