namespace TeaLeaves.Views
{
    partial class AddEventForm
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
            textBoxEName = new TextBox();
            textBoxStreetName = new TextBox();
            textBoxCity = new TextBox();
            comboBoxState = new ComboBox();
            dateTimePickerEvent = new DateTimePicker();
            labelHour = new Label();
            labelMinute = new Label();
            numericUpDownHour = new NumericUpDown();
            numericUpDownMinute = new NumericUpDown();
            richTextBoxDescription = new RichTextBox();
            buttonSave = new Button();
            buttonClose = new Button();
            labelError = new Label();
            textBoxZip = new TextBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            lblEventResponsibilities = new Label();
            dgvResponsibilities = new DataGridView();
            ResponsibilityName = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            lblResponsibilities = new Label();
            lblResponsibilityName = new Label();
            tbResponsibilityName = new TextBox();
            btnAddResponsibility = new Button();
            tableLayoutPanelAddEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResponsibilities).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelAddEvent
            // 
            tableLayoutPanelAddEvent.BackColor = Color.WhiteSmoke;
            tableLayoutPanelAddEvent.ColumnCount = 6;
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9932938F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.7497387F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.007761F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.83169F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4097557F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.007761F));
            tableLayoutPanelAddEvent.Controls.Add(labelName, 0, 0);
            tableLayoutPanelAddEvent.Controls.Add(labelEVenue, 0, 1);
            tableLayoutPanelAddEvent.Controls.Add(labelEDate, 0, 2);
            tableLayoutPanelAddEvent.Controls.Add(labelETime, 0, 3);
            tableLayoutPanelAddEvent.Controls.Add(labelEDescription, 0, 4);
            tableLayoutPanelAddEvent.Controls.Add(textBoxEName, 1, 0);
            tableLayoutPanelAddEvent.Controls.Add(textBoxStreetName, 1, 1);
            tableLayoutPanelAddEvent.Controls.Add(textBoxCity, 3, 1);
            tableLayoutPanelAddEvent.Controls.Add(comboBoxState, 4, 1);
            tableLayoutPanelAddEvent.Controls.Add(dateTimePickerEvent, 1, 2);
            tableLayoutPanelAddEvent.Controls.Add(labelHour, 1, 3);
            tableLayoutPanelAddEvent.Controls.Add(labelMinute, 3, 3);
            tableLayoutPanelAddEvent.Controls.Add(numericUpDownHour, 2, 3);
            tableLayoutPanelAddEvent.Controls.Add(numericUpDownMinute, 4, 3);
            tableLayoutPanelAddEvent.Controls.Add(richTextBoxDescription, 1, 4);
            tableLayoutPanelAddEvent.Controls.Add(buttonSave, 2, 7);
            tableLayoutPanelAddEvent.Controls.Add(buttonClose, 3, 7);
            tableLayoutPanelAddEvent.Controls.Add(labelError, 0, 7);
            tableLayoutPanelAddEvent.Controls.Add(textBoxZip, 5, 1);
            tableLayoutPanelAddEvent.Controls.Add(labelCategory, 3, 0);
            tableLayoutPanelAddEvent.Controls.Add(comboBoxCategory, 4, 0);
            tableLayoutPanelAddEvent.Controls.Add(lblEventResponsibilities, 0, 6);
            tableLayoutPanelAddEvent.Controls.Add(dgvResponsibilities, 3, 6);
            tableLayoutPanelAddEvent.Controls.Add(lblResponsibilities, 3, 5);
            tableLayoutPanelAddEvent.Controls.Add(lblResponsibilityName, 1, 5);
            tableLayoutPanelAddEvent.Controls.Add(tbResponsibilityName, 1, 6);
            tableLayoutPanelAddEvent.Controls.Add(btnAddResponsibility, 2, 6);
            tableLayoutPanelAddEvent.Dock = DockStyle.Fill;
            tableLayoutPanelAddEvent.Location = new Point(0, 0);
            tableLayoutPanelAddEvent.Name = "tableLayoutPanelAddEvent";
            tableLayoutPanelAddEvent.RowCount = 8;
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4285717F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4285717F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4285717F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4285717F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0476189F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 4.76190472F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0476189F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4285717F));
            tableLayoutPanelAddEvent.Size = new Size(1010, 621);
            tableLayoutPanelAddEvent.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.DarkGreen;
            labelName.Location = new Point(3, 24);
            labelName.Name = "labelName";
            labelName.Size = new Size(175, 21);
            labelName.TabIndex = 0;
            labelName.Text = "Event Name:";
            // 
            // labelEVenue
            // 
            labelEVenue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEVenue.AutoSize = true;
            labelEVenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEVenue.ForeColor = Color.DarkGreen;
            labelEVenue.Location = new Point(3, 94);
            labelEVenue.Name = "labelEVenue";
            labelEVenue.Size = new Size(175, 21);
            labelEVenue.TabIndex = 1;
            labelEVenue.Text = "Event Venue:";
            // 
            // labelEDate
            // 
            labelEDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEDate.AutoSize = true;
            labelEDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDate.ForeColor = Color.DarkGreen;
            labelEDate.Location = new Point(3, 164);
            labelEDate.Name = "labelEDate";
            labelEDate.Size = new Size(175, 21);
            labelEDate.TabIndex = 2;
            labelEDate.Text = "Event Date:";
            // 
            // labelETime
            // 
            labelETime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelETime.AutoSize = true;
            labelETime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelETime.ForeColor = Color.DarkGreen;
            labelETime.Location = new Point(3, 234);
            labelETime.Name = "labelETime";
            labelETime.Size = new Size(175, 21);
            labelETime.TabIndex = 3;
            labelETime.Text = "Event Time:";
            // 
            // labelEDescription
            // 
            labelEDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEDescription.AutoSize = true;
            labelEDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDescription.ForeColor = Color.DarkGreen;
            labelEDescription.Location = new Point(3, 328);
            labelEDescription.Name = "labelEDescription";
            labelEDescription.Size = new Size(175, 21);
            labelEDescription.TabIndex = 4;
            labelEDescription.Text = "Event Description:";
            // 
            // textBoxEName
            // 
            textBoxEName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(textBoxEName, 2);
            textBoxEName.Location = new Point(184, 23);
            textBoxEName.MaxLength = 100;
            textBoxEName.Name = "textBoxEName";
            textBoxEName.Size = new Size(314, 23);
            textBoxEName.TabIndex = 1;
            textBoxEName.TextChanged += textBoxEName_TextChanged;
            // 
            // textBoxStreetName
            // 
            textBoxStreetName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(textBoxStreetName, 2);
            textBoxStreetName.Location = new Point(184, 93);
            textBoxStreetName.MaxLength = 50;
            textBoxStreetName.Name = "textBoxStreetName";
            textBoxStreetName.PlaceholderText = "Street Name";
            textBoxStreetName.Size = new Size(314, 23);
            textBoxStreetName.TabIndex = 2;
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCity.Location = new Point(504, 93);
            textBoxCity.MaxLength = 25;
            textBoxCity.Name = "textBoxCity";
            textBoxCity.PlaceholderText = "City";
            textBoxCity.Size = new Size(194, 23);
            textBoxCity.TabIndex = 3;
            // 
            // comboBoxState
            // 
            comboBoxState.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxState.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(704, 93);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(149, 23);
            comboBoxState.TabIndex = 4;
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEvent.CalendarMonthBackground = Color.Orange;
            dateTimePickerEvent.CalendarTrailingForeColor = Color.DarkGreen;
            tableLayoutPanelAddEvent.SetColumnSpan(dateTimePickerEvent, 2);
            dateTimePickerEvent.Location = new Point(184, 163);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(314, 23);
            dateTimePickerEvent.TabIndex = 6;
            dateTimePickerEvent.Value = new DateTime(2023, 6, 12, 0, 0, 0, 0);
            dateTimePickerEvent.ValueChanged += dateTimePickerEvent_ValueChanged;
            // 
            // labelHour
            // 
            labelHour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelHour.AutoSize = true;
            labelHour.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHour.ForeColor = Color.DarkGreen;
            labelHour.Location = new Point(184, 234);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(163, 21);
            labelHour.TabIndex = 10;
            labelHour.Text = "Hour";
            labelHour.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMinute
            // 
            labelMinute.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMinute.ForeColor = Color.DarkGreen;
            labelMinute.Location = new Point(504, 234);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(194, 21);
            labelMinute.TabIndex = 11;
            labelMinute.Text = "Minute";
            labelMinute.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownHour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownHour.Location = new Point(353, 230);
            numericUpDownHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownHour.Name = "numericUpDownHour";
            numericUpDownHour.Size = new Size(145, 29);
            numericUpDownHour.TabIndex = 7;
            numericUpDownHour.ValueChanged += numericUpDownHour_ValueChanged;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMinute.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownMinute.Location = new Point(704, 230);
            numericUpDownMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(149, 29);
            numericUpDownMinute.TabIndex = 8;
            numericUpDownMinute.ValueChanged += numericUpDownMinute_ValueChanged;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(richTextBoxDescription, 4);
            richTextBoxDescription.Location = new Point(184, 289);
            richTextBoxDescription.MaxLength = 250;
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(669, 100);
            richTextBoxDescription.TabIndex = 9;
            richTextBoxDescription.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.BackColor = Color.Orange;
            buttonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.DarkGreen;
            buttonSave.Location = new Point(353, 571);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(145, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonClose.BackColor = Color.Orange;
            buttonClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.DarkGreen;
            buttonClose.Location = new Point(504, 571);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(194, 23);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_click;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelError.AutoSize = true;
            tableLayoutPanelAddEvent.SetColumnSpan(labelError, 2);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(3, 575);
            labelError.Name = "labelError";
            labelError.Size = new Size(344, 15);
            labelError.TabIndex = 17;
            // 
            // textBoxZip
            // 
            textBoxZip.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxZip.Location = new Point(859, 93);
            textBoxZip.MaxLength = 5;
            textBoxZip.Name = "textBoxZip";
            textBoxZip.PlaceholderText = "Zip Code";
            textBoxZip.Size = new Size(148, 23);
            textBoxZip.TabIndex = 5;
            textBoxZip.TextChanged += textBoxZip_TextChanged;
            textBoxZip.KeyPress += textBoxZip_KeyPress;
            // 
            // labelCategory
            // 
            labelCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.ForeColor = Color.DarkGreen;
            labelCategory.Location = new Point(504, 25);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(194, 20);
            labelCategory.TabIndex = 18;
            labelCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(comboBoxCategory, 2);
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(704, 23);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(303, 23);
            comboBoxCategory.TabIndex = 19;
            // 
            // lblEventResponsibilities
            // 
            lblEventResponsibilities.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEventResponsibilities.AutoSize = true;
            lblEventResponsibilities.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEventResponsibilities.ForeColor = Color.DarkGreen;
            lblEventResponsibilities.Location = new Point(3, 475);
            lblEventResponsibilities.Name = "lblEventResponsibilities";
            lblEventResponsibilities.Size = new Size(175, 21);
            lblEventResponsibilities.TabIndex = 20;
            lblEventResponsibilities.Text = "Event Responsibilities:";
            // 
            // dgvResponsibilities
            // 
            dgvResponsibilities.BackgroundColor = Color.PapayaWhip;
            dgvResponsibilities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResponsibilities.Columns.AddRange(new DataGridViewColumn[] { ResponsibilityName, User });
            tableLayoutPanelAddEvent.SetColumnSpan(dgvResponsibilities, 2);
            dgvResponsibilities.Location = new Point(504, 430);
            dgvResponsibilities.Name = "dgvResponsibilities";
            dgvResponsibilities.ReadOnly = true;
            dgvResponsibilities.RowTemplate.Height = 25;
            dgvResponsibilities.Size = new Size(304, 112);
            dgvResponsibilities.TabIndex = 21;
            // 
            // ResponsibilityName
            // 
            ResponsibilityName.DataPropertyName = "Name";
            ResponsibilityName.HeaderText = "Name";
            ResponsibilityName.Name = "ResponsibilityName";
            ResponsibilityName.ReadOnly = true;
            ResponsibilityName.Width = 130;
            // 
            // User
            // 
            User.DataPropertyName = "Username";
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 130;
            // 
            // lblResponsibilities
            // 
            lblResponsibilities.AutoSize = true;
            lblResponsibilities.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResponsibilities.ForeColor = Color.DarkGreen;
            lblResponsibilities.Location = new Point(504, 406);
            lblResponsibilities.Margin = new Padding(3, 8, 3, 0);
            lblResponsibilities.Name = "lblResponsibilities";
            lblResponsibilities.Size = new Size(92, 15);
            lblResponsibilities.TabIndex = 25;
            lblResponsibilities.Text = "Responsibilities";
            // 
            // lblResponsibilityName
            // 
            lblResponsibilityName.AutoSize = true;
            lblResponsibilityName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResponsibilityName.ForeColor = Color.DarkGreen;
            lblResponsibilityName.Location = new Point(184, 406);
            lblResponsibilityName.Margin = new Padding(3, 8, 3, 0);
            lblResponsibilityName.Name = "lblResponsibilityName";
            lblResponsibilityName.Size = new Size(119, 15);
            lblResponsibilityName.TabIndex = 26;
            lblResponsibilityName.Text = "Responsibility Name";
            // 
            // tbResponsibilityName
            // 
            tbResponsibilityName.Location = new Point(184, 475);
            tbResponsibilityName.Margin = new Padding(3, 48, 3, 3);
            tbResponsibilityName.Name = "tbResponsibilityName";
            tbResponsibilityName.Size = new Size(163, 23);
            tbResponsibilityName.TabIndex = 27;
            // 
            // btnAddResponsibility
            // 
            btnAddResponsibility.Location = new Point(353, 475);
            btnAddResponsibility.Margin = new Padding(3, 48, 3, 3);
            btnAddResponsibility.Name = "btnAddResponsibility";
            btnAddResponsibility.Size = new Size(145, 23);
            btnAddResponsibility.TabIndex = 28;
            btnAddResponsibility.Text = "add";
            btnAddResponsibility.UseVisualStyleBackColor = true;
            btnAddResponsibility.Click += btnAddResponsibility_Click;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 621);
            Controls.Add(tableLayoutPanelAddEvent);
            Name = "AddEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventsForm";
            Load += EventsForm_Load;
            tableLayoutPanelAddEvent.ResumeLayout(false);
            tableLayoutPanelAddEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResponsibilities).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAddEvent;
        private Label labelName;
        private Label labelEVenue;
        private Label labelEDate;
        private Label labelETime;
        private Label labelEDescription;
        private TextBox textBoxEName;
        private TextBox textBoxStreetName;
        private TextBox textBoxCity;
        private ComboBox comboBoxState;
        private DateTimePicker dateTimePickerEvent;
        private Label labelHour;
        private Label labelMinute;
        private NumericUpDown numericUpDownHour;
        private NumericUpDown numericUpDownMinute;
        private RichTextBox richTextBoxDescription;
        private Button buttonSave;
        private Button buttonClose;
        private Label labelError;
        private TextBox textBoxZip;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Label lblEventResponsibilities;
        private DataGridView dgvResponsibilities;
        private Label lblResponsibilities;
        private DataGridViewTextBoxColumn ResponsibilityName;
        private DataGridViewTextBoxColumn User;
        private Label lblResponsibilityName;
        private TextBox tbResponsibilityName;
        private Button btnAddResponsibility;
    }
}