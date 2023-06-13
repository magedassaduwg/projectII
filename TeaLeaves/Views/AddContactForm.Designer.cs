namespace TeaLeaves.Views
{
    partial class AddContactForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            contactTextBox = new TextBox();
            addButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5935173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4064827F));
            tableLayoutPanel1.Controls.Add(contactTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(addButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.333334F));
            tableLayoutPanel1.Size = new Size(401, 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // contactTextBox
            // 
            contactTextBox.Anchor = AnchorStyles.Right;
            contactTextBox.Location = new Point(35, 39);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(213, 23);
            contactTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(288, 39);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 101);
            Controls.Add(tableLayoutPanel1);
            Name = "AddContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add a Contact!";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox contactTextBox;
        private Button addButton;
    }
}