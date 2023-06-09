namespace TeaLeaves.Views
{
    partial class MessageForm
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
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSend = new Button();
            txtMessage = new RichTextBox();
            btnManageContacts = new Button();
            lstContacts = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panelMessages = new FlowLayoutPanel();
            lblSelectedContact = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnSend, 0, 0);
            tableLayoutPanel3.Controls.Add(txtMessage, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 517);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(665, 86);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Dock = DockStyle.Fill;
            btnSend.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.Location = new Point(501, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(161, 80);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Dock = DockStyle.Fill;
            txtMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(3, 3);
            txtMessage.MaxLength = 500;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(492, 80);
            txtMessage.TabIndex = 4;
            txtMessage.Text = "";
            // 
            // btnManageContacts
            // 
            btnManageContacts.Dock = DockStyle.Fill;
            btnManageContacts.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageContacts.Location = new Point(674, 517);
            btnManageContacts.Name = "btnManageContacts";
            btnManageContacts.Size = new Size(218, 86);
            btnManageContacts.TabIndex = 2;
            btnManageContacts.Text = "Manage Contacts";
            btnManageContacts.UseVisualStyleBackColor = true;
            btnManageContacts.Click += btnManageContacts_Click;
            // 
            // lstContacts
            // 
            lstContacts.Dock = DockStyle.Fill;
            lstContacts.DrawMode = DrawMode.OwnerDrawFixed;
            lstContacts.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstContacts.FormattingEnabled = true;
            lstContacts.ItemHeight = 20;
            lstContacts.Items.AddRange(new object[] { "No Contacts" });
            lstContacts.Location = new Point(674, 93);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(218, 418);
            lstContacts.TabIndex = 1;
            lstContacts.DrawItem += lstContacts_DrawItem;
            lstContacts.SelectedIndexChanged += lstContacts_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lstContacts, 1, 1);
            tableLayoutPanel1.Controls.Add(btnManageContacts, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(895, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panelMessages, 0, 1);
            tableLayoutPanel4.Controls.Add(lblSelectedContact, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 93);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.Size = new Size(665, 418);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // panelMessages
            // 
            panelMessages.AutoScroll = true;
            panelMessages.BorderStyle = BorderStyle.Fixed3D;
            panelMessages.Dock = DockStyle.Fill;
            panelMessages.FlowDirection = FlowDirection.TopDown;
            panelMessages.Location = new Point(4, 46);
            panelMessages.Name = "panelMessages";
            panelMessages.Size = new Size(657, 368);
            panelMessages.TabIndex = 7;
            panelMessages.WrapContents = false;
            // 
            // lblSelectedContact
            // 
            lblSelectedContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelectedContact.AutoSize = true;
            lblSelectedContact.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedContact.Location = new Point(4, 1);
            lblSelectedContact.Name = "lblSelectedContact";
            lblSelectedContact.Size = new Size(0, 41);
            lblSelectedContact.TabIndex = 0;
            lblSelectedContact.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 606);
            Controls.Add(tableLayoutPanel1);
            Name = "MessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageForm";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSend;
        private RichTextBox txtMessage;
        private Button btnManageContacts;
        private ListBox lstContacts;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel panelMessages;
        private Label lblSelectedContact;
    }
}