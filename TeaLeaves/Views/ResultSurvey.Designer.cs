namespace TeaLeaves.Views
{
    partial class ResultSurvey
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
            tableLayoutPanelResult = new TableLayoutPanel();
            buttonClose = new Button();
            richTextBoxDescription = new RichTextBox();
            dataGridViewSurvey = new DataGridView();
            Option = new DataGridViewTextBoxColumn();
            Votes = new DataGridViewTextBoxColumn();
            labelSurveyDescription = new Label();
            tableLayoutPanelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSurvey).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelResult
            // 
            tableLayoutPanelResult.ColumnCount = 2;
            tableLayoutPanelResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelResult.Controls.Add(buttonClose, 1, 3);
            tableLayoutPanelResult.Controls.Add(richTextBoxDescription, 1, 1);
            tableLayoutPanelResult.Controls.Add(dataGridViewSurvey, 1, 2);
            tableLayoutPanelResult.Controls.Add(labelSurveyDescription, 0, 1);
            tableLayoutPanelResult.Dock = DockStyle.Fill;
            tableLayoutPanelResult.Location = new Point(0, 0);
            tableLayoutPanelResult.Name = "tableLayoutPanelResult";
            tableLayoutPanelResult.RowCount = 4;
            tableLayoutPanelResult.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26315832F));
            tableLayoutPanelResult.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526333F));
            tableLayoutPanelResult.RowStyles.Add(new RowStyle(SizeType.Percent, 63.1579F));
            tableLayoutPanelResult.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263166F));
            tableLayoutPanelResult.Size = new Size(800, 450);
            tableLayoutPanelResult.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonClose.BackColor = Color.YellowGreen;
            buttonClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.DarkGreen;
            buttonClose.Location = new Point(203, 414);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(594, 23);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Dock = DockStyle.Fill;
            richTextBoxDescription.Enabled = false;
            richTextBoxDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxDescription.Location = new Point(203, 26);
            richTextBoxDescription.MaxLength = 250;
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(594, 88);
            richTextBoxDescription.TabIndex = 12;
            richTextBoxDescription.Text = "";
            // 
            // dataGridViewSurvey
            // 
            dataGridViewSurvey.BackgroundColor = Color.PapayaWhip;
            dataGridViewSurvey.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSurvey.Columns.AddRange(new DataGridViewColumn[] { Option, Votes });
            dataGridViewSurvey.Dock = DockStyle.Fill;
            dataGridViewSurvey.Location = new Point(203, 120);
            dataGridViewSurvey.Name = "dataGridViewSurvey";
            dataGridViewSurvey.ReadOnly = true;
            dataGridViewSurvey.RowTemplate.Height = 40;
            dataGridViewSurvey.Size = new Size(594, 278);
            dataGridViewSurvey.TabIndex = 11;
            // 
            // Option
            // 
            Option.DataPropertyName = "Name";
            Option.HeaderText = "Option";
            Option.Name = "Option";
            Option.ReadOnly = true;
            Option.Width = 350;
            // 
            // Votes
            // 
            Votes.DataPropertyName = "Votes";
            Votes.HeaderText = "Votes";
            Votes.Name = "Votes";
            Votes.ReadOnly = true;
            Votes.Width = 200;
            // 
            // labelSurveyDescription
            // 
            labelSurveyDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelSurveyDescription.AutoSize = true;
            labelSurveyDescription.Location = new Point(3, 62);
            labelSurveyDescription.Name = "labelSurveyDescription";
            labelSurveyDescription.Size = new Size(194, 15);
            labelSurveyDescription.TabIndex = 1;
            labelSurveyDescription.Text = "Survey Description";
            // 
            // ResultSurvey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelResult);
            Name = "ResultSurvey";
            Text = "ResultSurvey";
            Load += ResultSurvey_Load;
            tableLayoutPanelResult.ResumeLayout(false);
            tableLayoutPanelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSurvey).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelResult;
        private Label labelSurveyDescription;
        private DataGridView dataGridViewSurvey;
        private RichTextBox richTextBoxDescription;
        private Button buttonClose;
        private DataGridViewTextBoxColumn Option;
        private DataGridViewTextBoxColumn Votes;
    }
}