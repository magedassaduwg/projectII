﻿namespace TeaLeaves.UserControls
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
            tableLayoutPanel4 = new TableLayoutPanel();
            lblSelectedContact = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCreateGroup = new Button();
            btnManageContacts = new Button();
            notification = new NotifyIcon(components);
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tblMessages.Location = new Point(4, 50);
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
            lstContacts.ItemHeight = 20;
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(lblSelectedContact, 0, 0);
            tableLayoutPanel4.Controls.Add(tblMessages, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(819, 462);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // lblSelectedContact
            // 
            lblSelectedContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelectedContact.AutoSize = true;
            lblSelectedContact.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedContact.Location = new Point(4, 1);
            lblSelectedContact.Name = "lblSelectedContact";
            lblSelectedContact.Size = new Size(0, 45);
            lblSelectedContact.TabIndex = 0;
            lblSelectedContact.TextAlign = ContentAlignment.MiddleCenter;
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
            // ucMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "ucMessage";
            Size = new Size(1100, 551);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMessages;
        private TableLayoutPanel tableLayoutPanel3;
        private RichTextBox txtMessage;
        private ListBox lstContacts;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblSelectedContact;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCreateGroup;
        private Button btnManageContacts;
        private Button btnUploadImage;
        private Button btnSend;
        private Button btnImagePreview;
        private NotifyIcon notification;
    }
}
