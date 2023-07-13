namespace TeaLeaves.UserControls
{
    partial class ucMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMessage));
            tblMessages = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSend = new Button();
            btnUploadImage = new Button();
            txtMessage = new RichTextBox();
            btnImagePreview = new Button();
            lstContacts = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tblMessagesWithHeader = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            lblSelectedContact = new Label();
            panelSearch = new FlowLayoutPanel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCreateGroup = new Button();
            btnManageContacts = new Button();
            notification = new NotifyIcon(components);
            cmsMessage = new ContextMenuStrip(components);
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblMessagesWithHeader.SuspendLayout();
            tblHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tblMessages
            // 
            tblMessages.AutoSize = true;
            tblMessages.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMessages.ColumnCount = 2;
            tblMessages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMessages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMessages.Dock = DockStyle.Top;
            tblMessages.Location = new Point(4, 57);
            tblMessages.Name = "tblMessages";
            tblMessages.RowCount = 1;
            tblMessages.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMessages.Size = new Size(811, 0);
            tblMessages.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(btnSend, 3, 0);
            tableLayoutPanel3.Controls.Add(btnUploadImage, 0, 0);
            tableLayoutPanel3.Controls.Add(txtMessage, 0, 0);
            tableLayoutPanel3.Controls.Add(btnImagePreview, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 471);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(819, 77);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Orange;
            btnSend.Dock = DockStyle.Fill;
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = Color.DarkGreen;
            btnSend.Location = new Point(697, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(119, 71);
            btnSend.TabIndex = 12;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.Orange;
            btnUploadImage.Dock = DockStyle.Fill;
            btnUploadImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUploadImage.ForeColor = Color.DarkGreen;
            btnUploadImage.Image = (Image)resources.GetObject("btnUploadImage.Image");
            btnUploadImage.Location = new Point(412, 3);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(157, 71);
            btnUploadImage.TabIndex = 10;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // txtMessage
            // 
            txtMessage.Dock = DockStyle.Fill;
            txtMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(3, 3);
            txtMessage.MaxLength = 500;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(403, 71);
            txtMessage.TabIndex = 4;
            txtMessage.Text = "";
            // 
            // btnImagePreview
            // 
            btnImagePreview.BackColor = Color.Orange;
            btnImagePreview.BackgroundImageLayout = ImageLayout.Stretch;
            btnImagePreview.Dock = DockStyle.Fill;
            btnImagePreview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImagePreview.ForeColor = Color.DarkGreen;
            btnImagePreview.ImageAlign = ContentAlignment.MiddleLeft;
            btnImagePreview.Location = new Point(575, 3);
            btnImagePreview.Name = "btnImagePreview";
            btnImagePreview.Size = new Size(116, 71);
            btnImagePreview.TabIndex = 13;
            btnImagePreview.Text = "Clear Image";
            btnImagePreview.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImagePreview.UseVisualStyleBackColor = false;
            btnImagePreview.Visible = false;
            btnImagePreview.Click += btnImagePreview_Click;
            // 
            // lstContacts
            // 
            lstContacts.Dock = DockStyle.Fill;
            lstContacts.DrawMode = DrawMode.OwnerDrawFixed;
            lstContacts.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstContacts.FormattingEnabled = true;
            lstContacts.ItemHeight = 23;
            lstContacts.Items.AddRange(new object[] { "No Contacts" });
            lstContacts.Location = new Point(828, 3);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(269, 462);
            lstContacts.TabIndex = 1;
            lstContacts.DrawItem += lstContacts_DrawItem;
            lstContacts.SelectedIndexChanged += lstContacts_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lstContacts, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tblMessagesWithHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1100, 551);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tblMessagesWithHeader
            // 
            tblMessagesWithHeader.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblMessagesWithHeader.ColumnCount = 1;
            tblMessagesWithHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMessagesWithHeader.Controls.Add(tblMessages, 0, 1);
            tblMessagesWithHeader.Controls.Add(tblHeader, 0, 0);
            tblMessagesWithHeader.Dock = DockStyle.Fill;
            tblMessagesWithHeader.Location = new Point(3, 3);
            tblMessagesWithHeader.Name = "tblMessagesWithHeader";
            tblMessagesWithHeader.RowCount = 2;
            tblMessagesWithHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4967461F));
            tblMessagesWithHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 88.50325F));
            tblMessagesWithHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMessagesWithHeader.Size = new Size(819, 462);
            tblMessagesWithHeader.TabIndex = 6;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblHeader.Controls.Add(lblSelectedContact, 0, 0);
            tblHeader.Controls.Add(panelSearch, 1, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(4, 4);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.Size = new Size(811, 46);
            tblHeader.TabIndex = 2;
            // 
            // lblSelectedContact
            // 
            lblSelectedContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelectedContact.AutoSize = true;
            lblSelectedContact.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedContact.Location = new Point(3, 0);
            lblSelectedContact.Name = "lblSelectedContact";
            lblSelectedContact.Size = new Size(0, 46);
            lblSelectedContact.TabIndex = 1;
            lblSelectedContact.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(408, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(400, 40);
            panelSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtSearch.Location = new Point(3, 10);
            txtSearch.Margin = new Padding(3, 10, 3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(262, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Orange;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.DarkGreen;
            btnSearch.Location = new Point(271, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 40);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnCreateGroup, 0, 0);
            tableLayoutPanel2.Controls.Add(btnManageContacts, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(828, 471);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(269, 77);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.BackColor = Color.YellowGreen;
            btnCreateGroup.Dock = DockStyle.Fill;
            btnCreateGroup.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateGroup.ForeColor = Color.DarkGreen;
            btnCreateGroup.Location = new Point(137, 3);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(129, 71);
            btnCreateGroup.TabIndex = 4;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.UseVisualStyleBackColor = false;
            btnCreateGroup.Click += btnCreateGroup_Click;
            // 
            // btnManageContacts
            // 
            btnManageContacts.BackColor = Color.YellowGreen;
            btnManageContacts.Dock = DockStyle.Fill;
            btnManageContacts.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageContacts.ForeColor = Color.DarkGreen;
            btnManageContacts.Location = new Point(3, 3);
            btnManageContacts.Name = "btnManageContacts";
            btnManageContacts.Size = new Size(128, 71);
            btnManageContacts.TabIndex = 3;
            btnManageContacts.Text = "Manage Contacts";
            btnManageContacts.UseVisualStyleBackColor = false;
            btnManageContacts.Click += btnManageContacts_Click;
            // 
            // notification
            // 
            notification.Text = "You received  a message";
            notification.Visible = true;
            // 
            // cmsMessage
            // 
            cmsMessage.Name = "cmsMessage";
            cmsMessage.RenderMode = ToolStripRenderMode.Professional;
            cmsMessage.Size = new Size(61, 4);
            cmsMessage.Opening += cmsMessage_Opening;
            // 
            // ucMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "ucMessage";
            Size = new Size(1100, 551);
            Resize += ucMessage_Resize;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tblMessagesWithHeader.ResumeLayout(false);
            tblMessagesWithHeader.PerformLayout();
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMessages;
        private TableLayoutPanel tableLayoutPanel3;
        private RichTextBox txtMessage;
        private ListBox lstContacts;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblMessagesWithHeader;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCreateGroup;
        private Button btnManageContacts;
        private Button btnUploadImage;
        private Button btnSend;
        private Button btnImagePreview;
        private NotifyIcon notification;
        private ContextMenuStrip cmsMessage;
        private TableLayoutPanel tblHeader;
        private Label lblSelectedContact;
        private FlowLayoutPanel panelSearch;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
