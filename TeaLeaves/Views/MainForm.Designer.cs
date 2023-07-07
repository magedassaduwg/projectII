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
            ucMessage1 = new ucMessage();
            tabPageEvent = new TabPage();
            ucEventPlanners = new ucEventPlanner();
            tabPageInvites = new TabPage();
            ucEventInvites1 = new ucEventInvites();
            tabPageMySurvey = new TabPage();
            usSurvey1 = new ucSurvey();
            tabPageSurveyInvite = new TabPage();
            ucSurveyInvites1 = new ucSurveyInvites();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblGreeting = new Label();
            buttonLogout = new Button();
            viewProfileButton = new Button();
            tableLayoutPanel2.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageMessage.SuspendLayout();
            tabPageEvent.SuspendLayout();
            tabPageInvites.SuspendLayout();
            tabPageMySurvey.SuspendLayout();
            tabPageSurveyInvite.SuspendLayout();
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
            tabControlMain.Controls.Add(tabPageMySurvey);
            tabControlMain.Controls.Add(tabPageSurveyInvite);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(3, 76);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1294, 656);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageMessage
            // 
            tabPageMessage.Controls.Add(ucMessage1);
            tabPageMessage.Location = new Point(4, 24);
            tabPageMessage.Name = "tabPageMessage";
            tabPageMessage.Padding = new Padding(3);
            tabPageMessage.Size = new Size(1286, 628);
            tabPageMessage.TabIndex = 0;
            tabPageMessage.Text = "Message";
            tabPageMessage.UseVisualStyleBackColor = true;
            // 
            // ucMessage1
            // 
            ucMessage1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucMessage1.Dock = DockStyle.Fill;
            ucMessage1.Location = new Point(3, 3);
            ucMessage1.Name = "ucMessage1";
            ucMessage1.Size = new Size(1280, 622);
            ucMessage1.TabIndex = 0;
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
            // tabPageMySurvey
            // 
            tabPageMySurvey.Controls.Add(usSurvey1);
            tabPageMySurvey.Location = new Point(4, 24);
            tabPageMySurvey.Name = "tabPageMySurvey";
            tabPageMySurvey.Padding = new Padding(3);
            tabPageMySurvey.Size = new Size(1286, 628);
            tabPageMySurvey.TabIndex = 3;
            tabPageMySurvey.Text = "My Surveys";
            tabPageMySurvey.UseVisualStyleBackColor = true;
            // 
            // usSurvey1
            // 
            usSurvey1.Dock = DockStyle.Fill;
            usSurvey1.Location = new Point(3, 3);
            usSurvey1.Name = "usSurvey1";
            usSurvey1.Size = new Size(1280, 622);
            usSurvey1.TabIndex = 0;
            // 
            // tabPageSurveyInvite
            // 
            tabPageSurveyInvite.Controls.Add(ucSurveyInvites1);
            tabPageSurveyInvite.Location = new Point(4, 24);
            tabPageSurveyInvite.Name = "tabPageSurveyInvite";
            tabPageSurveyInvite.Padding = new Padding(3);
            tabPageSurveyInvite.Size = new Size(1286, 628);
            tabPageSurveyInvite.TabIndex = 4;
            tabPageSurveyInvite.Text = "Survey Invites";
            tabPageSurveyInvite.UseVisualStyleBackColor = true;
            // 
            // ucSurveyInvites1
            // 
            ucSurveyInvites1.Dock = DockStyle.Fill;
            ucSurveyInvites1.Location = new Point(3, 3);
            ucSurveyInvites1.Name = "ucSurveyInvites1";
            ucSurveyInvites1.Size = new Size(1280, 622);
            ucSurveyInvites1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblGreeting);
            flowLayoutPanel1.Controls.Add(buttonLogout);
            flowLayoutPanel1.Controls.Add(viewProfileButton);
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
            buttonLogout.ForeColor = Color.DarkGreen;
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
            viewProfileButton.ForeColor = Color.DarkGreen;
            viewProfileButton.Location = new Point(99, 3);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(115, 35);
            viewProfileButton.TabIndex = 3;
            viewProfileButton.Text = "Your Profile";
            viewProfileButton.UseVisualStyleBackColor = false;
            viewProfileButton.Click += viewProfileButton_Click;
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
            tabPageMessage.ResumeLayout(false);
            tabPageEvent.ResumeLayout(false);
            tabPageInvites.ResumeLayout(false);
            tabPageMySurvey.ResumeLayout(false);
            tabPageSurveyInvite.ResumeLayout(false);
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
        private TabPage tabPageInvites;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblGreeting;
        private UserControls.ucEventInvites ucEventInvites1;
        private Button buttonLogout;
        private Button button1;
        private Button yourProfileButton;
        private Button viewProfileButton;
        private ucMessage ucMessage1;
        private TabPage tabPageMySurvey;
        private TabPage tabPageSurveyInvite;
        private ucSurveyInvites ucSurveyInvites1;
        private ucSurvey usSurvey1;
    }
}