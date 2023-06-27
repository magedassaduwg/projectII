using TeaLeaves.UserControls;
using static MassTransit.Monitoring.Performance.BuiltInCounters;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel2 = new TableLayoutPanel();
            tabControlMain = new TabControl();
            tabPageMessage = new TabPage();
            tabPageEvent = new TabPage();
            ucEventPlanners = new ucEventPlanner();
            tabPageInvites = new TabPage();
            ucEventInvites1 = new ucEventInvites();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblGreeting = new Label();
            buttonLogout = new Button();
            viewProfileButton = new Button();
            ucMessages1 = new ucMessage();
            button2 = new Button();
            tableLayoutPanel2.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageEvent.SuspendLayout();
            tabPageInvites.SuspendLayout();
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
            tableLayoutPanel2.Size = new Size(1300, 735);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageMessage);
            tabControlMain.Controls.Add(tabPageEvent);
            tabControlMain.Controls.Add(tabPageInvites);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(3, 76);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1294, 656);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageMessage
            // 
            tabPageMessage.Location = new Point(4, 24);
            tabPageMessage.Name = "tabPageMessage";
            tabPageMessage.Padding = new Padding(3);
            tabPageMessage.Size = new Size(1286, 628);
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
            tabPageEvent.Size = new Size(1286, 628);
            tabPageEvent.TabIndex = 1;
            tabPageEvent.Text = "Event Planner";
            tabPageEvent.UseVisualStyleBackColor = true;
            // 
            // ucEventPlanners
            // 
            ucEventPlanners.Dock = DockStyle.Fill;
            ucEventPlanners.Location = new Point(3, 3);
            ucEventPlanners.Name = "ucEventPlanners";
            ucEventPlanners.Size = new Size(1280, 622);
            ucEventPlanners.TabIndex = 0;
            // 
            // tabPageInvites
            // 
            tabPageInvites.Controls.Add(ucEventInvites1);
            tabPageInvites.Location = new Point(4, 24);
            tabPageInvites.Name = "tabPageInvites";
            tabPageInvites.Padding = new Padding(3);
            tabPageInvites.Size = new Size(1286, 628);
            tabPageInvites.TabIndex = 2;
            tabPageInvites.Text = "Event Invite";
            tabPageInvites.UseVisualStyleBackColor = true;
            // 
            // ucEventInvites1
            // 
            ucEventInvites1.Dock = DockStyle.Fill;
            ucEventInvites1.Location = new Point(3, 3);
            ucEventInvites1.Name = "ucEventInvites1";
            ucEventInvites1.Size = new Size(1280, 622);
            ucEventInvites1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblGreeting);
            flowLayoutPanel1.Controls.Add(buttonLogout);
            flowLayoutPanel1.Controls.Add(viewProfileButton);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1294, 67);
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
            // viewProfileButton
            // 
            viewProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewProfileButton.BackColor = Color.YellowGreen;
            viewProfileButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewProfileButton.ForeColor = Color.DarkOrange;
            viewProfileButton.Location = new Point(99, 3);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(115, 35);
            viewProfileButton.TabIndex = 3;
            viewProfileButton.Text = "Your Profile";
            viewProfileButton.UseVisualStyleBackColor = false;
            viewProfileButton.Click += viewProfileButton_Click;
            // 
            // ucMessages1
            // 
            ucMessages1.Location = new Point(0, 0);
            ucMessages1.Name = "ucMessages1";
            ucMessages1.Size = new Size(1100, 551);
            ucMessages1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.YellowGreen;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(220, 3);
            button2.Name = "button2";
            button2.Size = new Size(196, 35);
            button2.TabIndex = 4;
            button2.Text = "temp ManageContact Button";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 735);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeaLeaves";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageEvent.ResumeLayout(false);
            tabPageInvites.ResumeLayout(false);
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
        private UserControls.ucMessage ucMessages1;
        private TabPage tabPageInvites;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblGreeting;
        private UserControls.ucEventInvites ucEventInvites1;
        private Button buttonLogout;
        private Button button1;
        private Button yourProfileButton;
        private Button viewProfileButton;
        private Button button2;
    }
}