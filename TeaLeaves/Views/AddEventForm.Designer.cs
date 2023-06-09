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
            tableLayoutPanelAddEvent=new TableLayoutPanel();
            labelName=new Label();
            labelEVenue=new Label();
            labelEDate=new Label();
            labelETime=new Label();
            labelEDescription=new Label();
            textBoxEName=new TextBox();
            textBoxStreetName=new TextBox();
            textBoxCity=new TextBox();
            comboBoxState=new ComboBox();
            dateTimePickerEvent=new DateTimePicker();
            labelHour=new Label();
            labelMinute=new Label();
            numericUpDownHour=new NumericUpDown();
            numericUpDownMinute=new NumericUpDown();
            richTextBoxDescription=new RichTextBox();
            buttonSave=new Button();
            buttonClose=new Button();
            labelError=new Label();
            tableLayoutPanelAddEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelAddEvent
            // 
            tableLayoutPanelAddEvent.BackColor=Color.WhiteSmoke;
            tableLayoutPanelAddEvent.ColumnCount=6;
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.625F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.125F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.25F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.25F));
            tableLayoutPanelAddEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.75F));
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
            tableLayoutPanelAddEvent.Controls.Add(buttonSave, 2, 5);
            tableLayoutPanelAddEvent.Controls.Add(buttonClose, 3, 5);
            tableLayoutPanelAddEvent.Controls.Add(labelError, 0, 5);
            tableLayoutPanelAddEvent.Dock=DockStyle.Fill;
            tableLayoutPanelAddEvent.Location=new Point(0, 0);
            tableLayoutPanelAddEvent.Name="tableLayoutPanelAddEvent";
            tableLayoutPanelAddEvent.RowCount=6;
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelAddEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddEvent.Size=new Size(800, 450);
            tableLayoutPanelAddEvent.TabIndex=0;
            // 
            // labelName
            // 
            labelName.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelName.AutoSize=true;
            labelName.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor=Color.DarkGreen;
            labelName.Location=new Point(3, 23);
            labelName.Name="labelName";
            labelName.Size=new Size(191, 21);
            labelName.TabIndex=0;
            labelName.Text="Event Name:";
            // 
            // labelEVenue
            // 
            labelEVenue.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelEVenue.AutoSize=true;
            labelEVenue.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEVenue.ForeColor=Color.DarkGreen;
            labelEVenue.Location=new Point(3, 90);
            labelEVenue.Name="labelEVenue";
            labelEVenue.Size=new Size(191, 21);
            labelEVenue.TabIndex=1;
            labelEVenue.Text="Event Venue:";
            // 
            // labelEDate
            // 
            labelEDate.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelEDate.AutoSize=true;
            labelEDate.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDate.ForeColor=Color.DarkGreen;
            labelEDate.Location=new Point(3, 157);
            labelEDate.Name="labelEDate";
            labelEDate.Size=new Size(191, 21);
            labelEDate.TabIndex=2;
            labelEDate.Text="Event Date:";
            // 
            // labelETime
            // 
            labelETime.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelETime.AutoSize=true;
            labelETime.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelETime.ForeColor=Color.DarkGreen;
            labelETime.Location=new Point(3, 224);
            labelETime.Name="labelETime";
            labelETime.Size=new Size(191, 21);
            labelETime.TabIndex=3;
            labelETime.Text="Event Time:";
            // 
            // labelEDescription
            // 
            labelEDescription.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelEDescription.AutoSize=true;
            labelEDescription.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEDescription.ForeColor=Color.DarkGreen;
            labelEDescription.Location=new Point(3, 313);
            labelEDescription.Name="labelEDescription";
            labelEDescription.Size=new Size(191, 21);
            labelEDescription.TabIndex=4;
            labelEDescription.Text="Event Description:";
            // 
            // textBoxEName
            // 
            textBoxEName.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(textBoxEName, 4);
            textBoxEName.Location=new Point(200, 22);
            textBoxEName.Name="textBoxEName";
            textBoxEName.Size=new Size(527, 23);
            textBoxEName.TabIndex=5;
            // 
            // textBoxStreetName
            // 
            textBoxStreetName.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(textBoxStreetName, 2);
            textBoxStreetName.Location=new Point(200, 89);
            textBoxStreetName.Name="textBoxStreetName";
            textBoxStreetName.Size=new Size(277, 23);
            textBoxStreetName.TabIndex=6;
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            textBoxCity.Location=new Point(483, 89);
            textBoxCity.Name="textBoxCity";
            textBoxCity.Size=new Size(114, 23);
            textBoxCity.TabIndex=7;
            // 
            // comboBoxState
            // 
            comboBoxState.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            comboBoxState.FormattingEnabled=true;
            comboBoxState.Location=new Point(603, 89);
            comboBoxState.Name="comboBoxState";
            comboBoxState.Size=new Size(124, 23);
            comboBoxState.TabIndex=8;
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(dateTimePickerEvent, 2);
            dateTimePickerEvent.Location=new Point(200, 156);
            dateTimePickerEvent.Name="dateTimePickerEvent";
            dateTimePickerEvent.Size=new Size(277, 23);
            dateTimePickerEvent.TabIndex=9;
            // 
            // labelHour
            // 
            labelHour.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelHour.AutoSize=true;
            labelHour.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHour.ForeColor=Color.DarkGreen;
            labelHour.Location=new Point(200, 224);
            labelHour.Name="labelHour";
            labelHour.Size=new Size(123, 21);
            labelHour.TabIndex=10;
            labelHour.Text="Hour";
            labelHour.TextAlign=ContentAlignment.MiddleRight;
            // 
            // labelMinute
            // 
            labelMinute.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelMinute.AutoSize=true;
            labelMinute.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMinute.ForeColor=Color.DarkGreen;
            labelMinute.Location=new Point(483, 224);
            labelMinute.Name="labelMinute";
            labelMinute.Size=new Size(114, 21);
            labelMinute.TabIndex=11;
            labelMinute.Text="Minute";
            labelMinute.TextAlign=ContentAlignment.MiddleRight;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            numericUpDownHour.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownHour.Location=new Point(329, 220);
            numericUpDownHour.Name="numericUpDownHour";
            numericUpDownHour.Size=new Size(148, 29);
            numericUpDownHour.TabIndex=12;
            numericUpDownHour.ValueChanged+=numericUpDownHour_ValueChanged;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            numericUpDownMinute.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownMinute.Location=new Point(603, 220);
            numericUpDownMinute.Name="numericUpDownMinute";
            numericUpDownMinute.Size=new Size(124, 29);
            numericUpDownMinute.TabIndex=13;
            numericUpDownMinute.ValueChanged+=numericUpDownMinute_ValueChanged;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            tableLayoutPanelAddEvent.SetColumnSpan(richTextBoxDescription, 4);
            richTextBoxDescription.Location=new Point(200, 271);
            richTextBoxDescription.Name="richTextBoxDescription";
            richTextBoxDescription.Size=new Size(527, 106);
            richTextBoxDescription.TabIndex=14;
            richTextBoxDescription.Text="";
            // 
            // buttonSave
            // 
            buttonSave.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonSave.BackColor=Color.Orange;
            buttonSave.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor=Color.DarkGreen;
            buttonSave.Location=new Point(329, 403);
            buttonSave.Name="buttonSave";
            buttonSave.Size=new Size(148, 23);
            buttonSave.TabIndex=15;
            buttonSave.Text="Save";
            buttonSave.UseVisualStyleBackColor=false;
            buttonSave.Click+=buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonClose.BackColor=Color.Orange;
            buttonClose.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor=Color.DarkGreen;
            buttonClose.Location=new Point(483, 403);
            buttonClose.Name="buttonClose";
            buttonClose.Size=new Size(114, 23);
            buttonClose.TabIndex=16;
            buttonClose.Text="Close";
            buttonClose.UseVisualStyleBackColor=false;
            buttonClose.Click += new System.EventHandler(this.buttonClose_click);
            // 
            // labelError
            // 
            labelError.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelError.AutoSize=true;
            tableLayoutPanelAddEvent.SetColumnSpan(labelError, 2);
            labelError.ForeColor=Color.Red;
            labelError.Location=new Point(3, 407);
            labelError.Name="labelError";
            labelError.Size=new Size(320, 15);
            labelError.TabIndex=17;
            labelError.Text="label1";
            // 
            // EventsForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(tableLayoutPanelAddEvent);
            Name="EventsForm";
            StartPosition=FormStartPosition.CenterScreen;
            Text="EventsForm";
            Load+=EventsForm_Load;
            tableLayoutPanelAddEvent.ResumeLayout(false);
            tableLayoutPanelAddEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
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
    }
}