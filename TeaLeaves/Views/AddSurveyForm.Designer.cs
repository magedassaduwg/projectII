namespace TeaLeaves.Views
{
    partial class AddSurveyForm
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
            tableLayoutPanelAddSurvey=new TableLayoutPanel();
            labelSurveyDescription=new Label();
            richTextBoxDescription=new RichTextBox();
            textBox5=new TextBox();
            labelOption1=new Label();
            labelOption=new Label();
            buttonAdd=new Button();
            buttonClose=new Button();
            labelError=new Label();
            dataGridViewSurvey=new DataGridView();
            Option=new DataGridViewTextBoxColumn();
            Votes=new DataGridViewTextBoxColumn();
            buttonSave=new Button();
            tableLayoutPanelAddSurvey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSurvey).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelAddSurvey
            // 
            tableLayoutPanelAddSurvey.ColumnCount=5;
            tableLayoutPanelAddSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanelAddSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanelAddSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.125F));
            tableLayoutPanelAddSurvey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.875F));
            tableLayoutPanelAddSurvey.Controls.Add(labelSurveyDescription, 1, 1);
            tableLayoutPanelAddSurvey.Controls.Add(richTextBoxDescription, 2, 1);
            tableLayoutPanelAddSurvey.Controls.Add(textBox5, 2, 3);
            tableLayoutPanelAddSurvey.Controls.Add(labelOption1, 1, 2);
            tableLayoutPanelAddSurvey.Controls.Add(labelOption, 1, 3);
            tableLayoutPanelAddSurvey.Controls.Add(labelError, 2, 5);
            tableLayoutPanelAddSurvey.Controls.Add(dataGridViewSurvey, 2, 2);
            tableLayoutPanelAddSurvey.Controls.Add(buttonAdd, 3, 3);
            tableLayoutPanelAddSurvey.Controls.Add(buttonClose, 4, 4);
            tableLayoutPanelAddSurvey.Controls.Add(buttonSave, 3, 4);
            tableLayoutPanelAddSurvey.Dock=DockStyle.Fill;
            tableLayoutPanelAddSurvey.Location=new Point(0, 0);
            tableLayoutPanelAddSurvey.Name="tableLayoutPanelAddSurvey";
            tableLayoutPanelAddSurvey.RowCount=6;
            tableLayoutPanelAddSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelAddSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelAddSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanelAddSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelAddSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelAddSurvey.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelAddSurvey.Size=new Size(800, 450);
            tableLayoutPanelAddSurvey.TabIndex=0;
            // 
            // labelSurveyDescription
            // 
            labelSurveyDescription.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelSurveyDescription.AutoSize=true;
            labelSurveyDescription.Location=new Point(43, 71);
            labelSurveyDescription.Name="labelSurveyDescription";
            labelSurveyDescription.Size=new Size(114, 15);
            labelSurveyDescription.TabIndex=0;
            labelSurveyDescription.Text="Survey Description";
            // 
            // richTextBoxDescription
            // 
            tableLayoutPanelAddSurvey.SetColumnSpan(richTextBoxDescription, 2);
            richTextBoxDescription.Dock=DockStyle.Fill;
            richTextBoxDescription.Location=new Point(163, 48);
            richTextBoxDescription.MaxLength=250;
            richTextBoxDescription.Name="richTextBoxDescription";
            richTextBoxDescription.Size=new Size(507, 61);
            richTextBoxDescription.TabIndex=0;
            richTextBoxDescription.Text="";
            // 
            // textBox5
            // 
            textBox5.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            textBox5.Location=new Point(163, 325);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(378, 23);
            textBox5.TabIndex=1;
            // 
            // labelOption1
            // 
            labelOption1.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelOption1.AutoSize=true;
            labelOption1.Location=new Point(43, 205);
            labelOption1.Name="labelOption1";
            labelOption1.Size=new Size(114, 15);
            labelOption1.TabIndex=7;
            // 
            // labelOption
            // 
            labelOption.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            labelOption.AutoSize=true;
            labelOption.Location=new Point(43, 329);
            labelOption.Name="labelOption";
            labelOption.Size=new Size(114, 15);
            labelOption.TabIndex=11;
            labelOption.Text="Option ";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonAdd.Location=new Point(547, 325);
            buttonAdd.Name="buttonAdd";
            buttonAdd.Size=new Size(123, 23);
            buttonAdd.TabIndex=2;
            buttonAdd.Text="Add";
            buttonAdd.UseVisualStyleBackColor=true;
            // 
            // buttonClose
            // 
            buttonClose.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonClose.Location=new Point(676, 370);
            buttonClose.Name="buttonClose";
            buttonClose.Size=new Size(121, 23);
            buttonClose.TabIndex=4;
            buttonClose.Text="Close";
            buttonClose.UseVisualStyleBackColor=true;
            // 
            // labelError
            // 
            labelError.AutoSize=true;
            labelError.Location=new Point(163, 404);
            labelError.Name="labelError";
            labelError.Size=new Size(57, 15);
            labelError.TabIndex=12;
            labelError.Text="labelerror";
            // 
            // dataGridViewSurvey
            // 
            dataGridViewSurvey.BackgroundColor=Color.PapayaWhip;
            dataGridViewSurvey.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSurvey.Columns.AddRange(new DataGridViewColumn[] { Option, Votes });
            tableLayoutPanelAddSurvey.SetColumnSpan(dataGridViewSurvey, 2);
            dataGridViewSurvey.Dock=DockStyle.Fill;
            dataGridViewSurvey.Location=new Point(163, 115);
            dataGridViewSurvey.Name="dataGridViewSurvey";
            dataGridViewSurvey.ReadOnly=true;
            dataGridViewSurvey.RowTemplate.Height=25;
            dataGridViewSurvey.Size=new Size(507, 196);
            dataGridViewSurvey.TabIndex=10;
            // 
            // Option
            // 
            Option.DataPropertyName="Option";
            Option.HeaderText="Option";
            Option.Name="Option";
            Option.ReadOnly=true;
            // 
            // Votes
            // 
            Votes.DataPropertyName="Votes";
            Votes.HeaderText="Votes";
            Votes.Name="Votes";
            Votes.ReadOnly=true;
            // 
            // buttonSave
            // 
            buttonSave.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonSave.Location=new Point(547, 370);
            buttonSave.Name="buttonSave";
            buttonSave.Size=new Size(123, 23);
            buttonSave.TabIndex=3;
            buttonSave.Text="Save";
            buttonSave.UseVisualStyleBackColor=true;
            // 
            // AddSurveyForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(tableLayoutPanelAddSurvey);
            Name="AddSurveyForm";
            Text="AddSurveyForm";
            tableLayoutPanelAddSurvey.ResumeLayout(false);
            tableLayoutPanelAddSurvey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSurvey).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAddSurvey;
        private Label labelSurveyDescription;
        private RichTextBox richTextBoxDescription;
        private TextBox textBox5;
        private Label labelOption1;
        private Label labelOption;
        private Button buttonAdd;
        private Button buttonClose;
        private Label labelError;
        private DataGridView dataGridViewSurvey;
        private DataGridViewTextBoxColumn Option;
        private DataGridViewTextBoxColumn Votes;
        private Button buttonSave;
    }
}