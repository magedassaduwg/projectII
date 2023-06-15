﻿namespace TeaLeaves.Views
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
            tabPageInvites = new TabPage();
            ucEventInvites1 = new UserControls.ucEventInvites();
            tabPageContact = new TabPage();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblGreeting = new Label();
            buttonLogout = new Button();
            yourProfileButton = new Button();
            tableLayoutPanel2.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageEvent.SuspendLayout();
            tabPageInvites.SuspendLayout();
            tabPageContact.SuspendLayout();
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
            tableLayoutPanel2.Size = new Size(1300, 600);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageMessage);
            tabControlMain.Controls.Add(tabPageEvent);
            tabControlMain.Controls.Add(tabPageInvites);
            tabControlMain.Controls.Add(tabPageContact);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(3, 63);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1294, 534);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageMessage
            // 
            tabPageMessage.Location = new Point(4, 24);
            tabPageMessage.Name = "tabPageMessage";
            tabPageMessage.Padding = new Padding(3);
            tabPageMessage.Size = new Size(1286, 506);
            tabPageMessage.TabIndex = 0;
            tabPageMessage.Text = "Message";
            tabPageMessage.UseVisualStyleBackColor = true;
            // 
            // tabPageEvent
            // 
            tabPageEvent.Controls.Add(ucEventPlanners);
            tabPageEvent.Location = new Point(4, 24);
            tabPageEvent.Name = "tabPageEvent";
            tabPageEvent.Padding = new Padding(3);
            tabPageEvent.Size = new Size(1286, 506);
            tabPageEvent.TabIndex = 1;
            tabPageEvent.Text = "Event Planner";
            tabPageEvent.UseVisualStyleBackColor = true;
            // 
            // ucEventPlanners
            // 
            ucEventPlanners.Dock = DockStyle.Fill;
            ucEventPlanners.Location = new Point(3, 3);
            ucEventPlanners.Name = "ucEventPlanners";
            ucEventPlanners.Size = new Size(1280, 500);
            ucEventPlanners.TabIndex = 0;
            // 
            // tabPageInvites
            // 
            tabPageInvites.Controls.Add(ucEventInvites1);
            tabPageInvites.Location = new Point(4, 24);
            tabPageInvites.Name = "tabPageInvites";
            tabPageInvites.Padding = new Padding(3);
            tabPageInvites.Size = new Size(1286, 506);
            tabPageInvites.TabIndex = 2;
            tabPageInvites.Text = "Event Invite";
            tabPageInvites.UseVisualStyleBackColor = true;
            // 
            // ucEventInvites1
            // 
            ucEventInvites1.Dock = DockStyle.Fill;
            ucEventInvites1.Location = new Point(3, 3);
            ucEventInvites1.Name = "ucEventInvites1";
            ucEventInvites1.Size = new Size(1280, 500);
            ucEventInvites1.TabIndex = 0;
            // 
            // tabPageContact
            // 
            tabPageContact.Controls.Add(button1);
            tabPageContact.Location = new Point(4, 24);
            tabPageContact.Name = "tabPageContact";
            tabPageContact.Padding = new Padding(3);
            tabPageContact.Size = new Size(1286, 506);
            tabPageContact.TabIndex = 3;
            tabPageContact.Text = "Contact";
            tabPageContact.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(338, 252);
            button1.TabIndex = 0;
            button1.Text = "temp Manage Contacts Button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblGreeting);
            flowLayoutPanel1.Controls.Add(buttonLogout);
            flowLayoutPanel1.Controls.Add(yourProfileButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1294, 54);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblGreeting
            // 
            lblGreeting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblGreeting.Location = new Point(3, 0);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(0, 41);
            lblGreeting.TabIndex = 0;
            lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLogout.BackColor = Color.YellowGreen;
            buttonLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.DarkOrange;
            buttonLogout.Location = new Point(9, 3);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(84, 35);
            buttonLogout.TabIndex = 2;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // yourProfileButton
            // 
            yourProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yourProfileButton.BackColor = Color.YellowGreen;
            yourProfileButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            yourProfileButton.ForeColor = Color.DarkOrange;
            yourProfileButton.Location = new Point(99, 3);
            yourProfileButton.Name = "yourProfileButton";
            yourProfileButton.Size = new Size(119, 35);
            yourProfileButton.TabIndex = 3;
            yourProfileButton.Text = "Your Profile";
            yourProfileButton.UseVisualStyleBackColor = false;
            yourProfileButton.Click += yourProfileButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 600);
            Controls.Add(tableLayoutPanel2);
            MinimumSize = new Size(1200, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageEvent.ResumeLayout(false);
            tabPageInvites.ResumeLayout(false);
            tabPageContact.ResumeLayout(false);
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
        private UserControls.ucEventInvites ucEventInvites1;
        private Button buttonLogout;
        private Button button1;
        private Button yourProfileButton;
    }
}