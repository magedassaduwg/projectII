namespace TeaLeaves.Views
{
    partial class MainForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tabControlMain = new TabControl();
            tabPageMessage = new TabPage();
            tabPageEvent = new TabPage();
            ucEventPlanners = new UserControls.ucEventPlanner();
            ucMessages = new UserControls.ucMessage();
            tabPageInvites = new TabPage();
            tabPageContact = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblGreeting = new Label();
            lnkLogout = new LinkLabel();
            tableLayoutPanel2.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageEvent.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tabControlMain, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(1106, 426);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageMessage);
            tabControlMain.Controls.Add(tabPageEvent);
            tabControlMain.Controls.Add(tabPageInvites);
            tabControlMain.Controls.Add(tabPageContact);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(3, 45);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1100, 378);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageMessage
            // 
            tabPageMessage.Controls.Add(ucMessages);
            tabPageMessage.Location = new Point(4, 24);
            tabPageMessage.Name = "tabPageMessage";
            tabPageMessage.Padding = new Padding(3);
            tabPageMessage.Size = new Size(1092, 350);
            tabPageMessage.TabIndex = 0;
            tabPageMessage.Text = "Message";
            tabPageMessage.UseVisualStyleBackColor = true;

            ucMessages.Dock = DockStyle.Fill;
            ucMessages.Location = new Point(0, 0);
            ucMessages.Name = "ucMessages";
            ucMessages.Size = new Size(1086, 344);
            ucMessages.TabIndex = 0;
            // 
            // tabPageEvent
            // 
            tabPageEvent.Controls.Add(ucEventPlanners);
            tabPageEvent.Location = new Point(4, 24);
            tabPageEvent.Name = "tabPageEvent";
            tabPageEvent.Padding = new Padding(3);
            tabPageEvent.Size = new Size(1092, 350);
            tabPageEvent.TabIndex = 1;
            tabPageEvent.Text = "Event Planner";
            tabPageEvent.UseVisualStyleBackColor = true;
            // 
            // ucEventPlanner1
            // 
            ucEventPlanners.Dock = DockStyle.Fill;
            ucEventPlanners.Location = new Point(3, 3);
            ucEventPlanners.Name = "ucEventPlanners";
            ucEventPlanners.Size = new Size(1086, 344);
            ucEventPlanners.TabIndex = 0;
            // 
            // tabPageInvites
            // 
            tabPageInvites.Location = new Point(4, 24);
            tabPageInvites.Name = "tabPageInvites";
            tabPageInvites.Padding = new Padding(3);
            tabPageInvites.Size = new Size(1092, 350);
            tabPageInvites.TabIndex = 2;
            tabPageInvites.Text = "Event Invite";
            tabPageInvites.UseVisualStyleBackColor = true;
            // 
            // tabPageContact
            // 
            tabPageContact.Location = new Point(4, 24);
            tabPageContact.Name = "tabPageContact";
            tabPageContact.Padding = new Padding(3);
            tabPageContact.Size = new Size(1092, 350);
            tabPageContact.TabIndex = 3;
            tabPageContact.Text = "Contact";
            tabPageContact.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblGreeting);
            flowLayoutPanel1.Controls.Add(lnkLogout);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1100, 36);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblGreeting
            // 
            lblGreeting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreeting.Location = new Point(3, 0);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(0, 21);
            lblGreeting.TabIndex = 0;
            lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lnkLogout
            // 
            lnkLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lnkLogout.AutoSize = true;
            lnkLogout.Location = new Point(9, 0);
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Size = new Size(48, 21);
            lnkLogout.TabIndex = 1;
            lnkLogout.TabStop = true;
            lnkLogout.Text = "Log out";
            lnkLogout.TextAlign = ContentAlignment.MiddleCenter;
            lnkLogout.LinkClicked += lnkLogout_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 600);
            MinimumSize = new Size(1200, 500);
            Controls.Add(tableLayoutPanel2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageEvent.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabControl tabControlMain;
        private TabPage tabPageMessage;
        private TabPage tabPageEvent;
        private UserControls.ucEventPlanner ucEventPlanners;
        private UserControls.ucMessage ucMessages;
        private TabPage tabPageInvites;
        private TabPage tabPageContact;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblGreeting;
        private LinkLabel lnkLogout;
    }
}