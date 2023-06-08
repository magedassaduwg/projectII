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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSend = new Button();
            txtMessage = new RichTextBox();
            btnManageContacts = new Button();
            lstContacts = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            flpWelcomeLinks = new FlowLayoutPanel();
            lblWelcome = new Label();
            lnkLogout = new LinkLabel();
            lblStatus = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panelMessages = new FlowLayoutPanel();
            lblSelectedContact = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flpWelcomeLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // lstContacts
            // 
            lstContacts.Dock = DockStyle.Fill;
            lstContacts.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstContacts.FormattingEnabled = true;
            lstContacts.ItemHeight = 20;
            lstContacts.Items.AddRange(new object[] { "No Contacts" });
            lstContacts.Location = new Point(674, 93);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(218, 418);
            lstContacts.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(flpWelcomeLinks, 1, 0);
            tableLayoutPanel2.Controls.Add(lblStatus, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(889, 84);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flpWelcomeLinks
            // 
            flpWelcomeLinks.Controls.Add(lblWelcome);
            flpWelcomeLinks.Controls.Add(lnkLogout);
            flpWelcomeLinks.FlowDirection = FlowDirection.TopDown;
            flpWelcomeLinks.Location = new Point(269, 3);
            flpWelcomeLinks.Name = "flpWelcomeLinks";
            flpWelcomeLinks.Size = new Size(403, 55);
            flpWelcomeLinks.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(3, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(71, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lnkLogout
            // 
            lnkLogout.AutoSize = true;
            lnkLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkLogout.Location = new Point(3, 20);
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Size = new Size(56, 20);
            lnkLogout.TabIndex = 0;
            lnkLogout.TabStop = true;
            lnkLogout.Text = "Logout";
            lnkLogout.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Green;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(713, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(173, 84);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Connected";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
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
            lblSelectedContact.Size = new Size(172, 41);
            lblSelectedContact.TabIndex = 0;
            lblSelectedContact.Text = "Magood Assad";
            lblSelectedContact.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 606);
            Controls.Add(tableLayoutPanel1);
            Name = "MessageForm";
            Text = "MessageForm";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flpWelcomeLinks.ResumeLayout(false);
            flpWelcomeLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flpWelcomeLinks;
        private Label lblWelcome;
        private LinkLabel lnkLogout;
        private Label lblStatus;
        private PictureBox pictureBox1;
        private FlowLayoutPanel panelMessages;
        private Label lblSelectedContact;
    }
}