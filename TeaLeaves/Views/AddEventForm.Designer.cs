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
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.625F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.625F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.875F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.375F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
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
            tableLayoutPanelAddEvent.Controls.Add(buttonSave, 2, 6);
            tableLayoutPanelAddEvent.Controls.Add(buttonClose, 3, 6);
            tableLayoutPanelAddEvent.Controls.Add(labelError, 0, 6);
            tableLayoutPanelAddEvent.Controls.Add(textBoxZip, 5, 1);
            tableLayoutPanelAddEvent.Controls.Add(labelCategory, 3, 0);
            tableLayoutPanelAddEvent.Controls.Add(comboBoxCategory, 4, 0);
            tableLayoutPanelAddEvent.Controls.Add(lblEventResponsibilities, 0, 5);
            tableLayoutPanelAddEvent.Controls.Add(tbResponsibilityName, 1, 5);
            tableLayoutPanelAddEvent.Controls.Add(dgvResponsibilities, 4, 5);
            tableLayoutPanelAddEvent.Controls.Add(btnAddResponsibility, 3, 5);
            tableLayoutPanelAddEvent.Dock = DockStyle.Fill;
            tableLayoutPanelAddEvent.Location = new Point(0, 0);
            tableLayoutPanelAddEvent.Name = "tableLayoutPanelAddEvent";
            tableLayoutPanelAddEvent.RowCount = 7;
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelAddEvent.Size = new Size(800, 561);
            tableLayoutPanelAddEvent.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.DarkGreen;
            labelName.Location = new Point(3, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(151, 21);
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
            labelEVenue.Size = new Size(151, 21);
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
            labelEDate.Size = new Size(151, 21);
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
            labelETime.Size = new Size(151, 21);
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
            labelEDescription.Size = new Size(151, 21);
            labelEDescription.TabIndex = 4;
            labelEDescription.Text = "Event Description:";
            // 
            // textBoxEName
            // 
            textBoxEName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(textBoxEName, 2);
            textBoxEName.Location = new Point(160, 22);
            textBoxEName.MaxLength = 100;
            textBoxEName.Name = "textBoxEName";
            textBoxEName.Size = new Size(262, 23);
            textBoxEName.TabIndex = 1;
            textBoxEName.TextChanged += textBoxEName_TextChanged;
            // 
            // textBoxStreetName
            // 
            textBoxStreetName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(textBoxStreetName, 2);
            textBoxStreetName.Location = new Point(160, 89);
            textBoxStreetName.MaxLength = 50;
            textBoxStreetName.Name = "textBoxStreetName";
            textBoxStreetName.PlaceholderText = "Street Name";
            textBoxStreetName.Size = new Size(262, 23);
            textBoxStreetName.TabIndex = 2;
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCity.Location = new Point(428, 89);
            textBoxCity.MaxLength = 25;
            textBoxCity.Name = "textBoxCity";
            textBoxCity.PlaceholderText = "City";
            textBoxCity.Size = new Size(142, 23);
            textBoxCity.TabIndex = 3;
            // 
            // comboBoxState
            // 
            comboBoxState.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxState.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(576, 89);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(109, 23);
            comboBoxState.TabIndex = 4;
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEvent.CalendarMonthBackground = Color.Orange;
            dateTimePickerEvent.CalendarTrailingForeColor = Color.DarkGreen;
            tableLayoutPanelAddEvent.SetColumnSpan(dateTimePickerEvent, 2);
            dateTimePickerEvent.Location = new Point(160, 156);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(262, 23);
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
            labelHour.Location = new Point(160, 224);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(119, 21);
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
            labelMinute.Location = new Point(428, 224);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(142, 21);
            labelMinute.TabIndex = 11;
            labelMinute.Text = "Minute";
            labelMinute.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownHour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownHour.Location = new Point(285, 220);
            numericUpDownHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownHour.Name = "numericUpDownHour";
            numericUpDownHour.Size = new Size(137, 29);
            numericUpDownHour.TabIndex = 7;
            numericUpDownHour.ValueChanged += numericUpDownHour_ValueChanged;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMinute.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownMinute.Location = new Point(576, 220);
            numericUpDownMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(109, 29);
            numericUpDownMinute.TabIndex = 8;
            numericUpDownMinute.ValueChanged += numericUpDownMinute_ValueChanged;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(richTextBoxDescription, 4);
            richTextBoxDescription.Location = new Point(160, 271);
            richTextBoxDescription.MaxLength = 250;
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(525, 106);
            richTextBoxDescription.TabIndex = 9;
            richTextBoxDescription.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.BackColor = Color.Orange;
            buttonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.DarkGreen;
            buttonSave.Location = new Point(285, 515);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(137, 23);
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
            buttonClose.Location = new Point(428, 515);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(142, 23);
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
            labelError.Location = new Point(3, 519);
            labelError.Name = "labelError";
            labelError.Size = new Size(276, 15);
            labelError.TabIndex = 17;
            // 
            // textBoxZip
            // 
            textBoxZip.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxZip.Location = new Point(691, 89);
            textBoxZip.MaxLength = 5;
            textBoxZip.Name = "textBoxZip";
            textBoxZip.PlaceholderText = "Zip Code";
            textBoxZip.Size = new Size(106, 23);
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
            labelCategory.Location = new Point(428, 23);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(142, 20);
            labelCategory.TabIndex = 18;
            labelCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(comboBoxCategory, 2);
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(576, 22);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(221, 23);
            comboBoxCategory.TabIndex = 19;
            // 
            // lblEventResponsibilities
            // 
            lblEventResponsibilities.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEventResponsibilities.AutoSize = true;
            lblEventResponsibilities.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEventResponsibilities.ForeColor = Color.DarkGreen;
            lblEventResponsibilities.Location = new Point(3, 415);
            lblEventResponsibilities.Name = "lblEventResponsibilities";
            lblEventResponsibilities.Size = new Size(151, 42);
            lblEventResponsibilities.TabIndex = 20;
            lblEventResponsibilities.Text = "Event Responsibilities:";
            // 
            // dgvResponsibilities
            // 
            dgvResponsibilities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelAddEvent.SetColumnSpan(dgvResponsibilities, 2);
            dgvResponsibilities.Location = new Point(576, 383);
            dgvResponsibilities.Name = "dgvResponsibilities";
            dgvResponsibilities.RowTemplate.Height = 25;
            dgvResponsibilities.Size = new Size(221, 106);
            dgvResponsibilities.TabIndex = 21;
            // 
            // tbResponsibilityName
            // 
            tableLayoutPanelAddEvent.SetColumnSpan(tbResponsibilityName, 2);
            tbResponsibilityName.Location = new Point(160, 435);
            tbResponsibilityName.Margin = new Padding(3, 55, 3, 3);
            tbResponsibilityName.Name = "tbResponsibilityName";
            tbResponsibilityName.Size = new Size(262, 23);
            tbResponsibilityName.TabIndex = 22;
            // 
            // btnAddResponsibility
            // 
            btnAddResponsibility.Location = new Point(428, 435);
            btnAddResponsibility.Margin = new Padding(3, 55, 3, 3);
            btnAddResponsibility.Name = "btnAddResponsibility";
            btnAddResponsibility.Size = new Size(137, 23);
            btnAddResponsibility.TabIndex = 23;
            btnAddResponsibility.Text = "Add";
            btnAddResponsibility.UseVisualStyleBackColor = true;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
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
        private TextBox tbResponsibilityName;
        private Button btnAddResponsibility;
    }
}