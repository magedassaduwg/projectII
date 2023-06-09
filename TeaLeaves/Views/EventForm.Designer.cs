namespace TeaLeaves.Views
{
    partial class EventForm
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
            tcEvent = new TabControl();
            myEvents = new TabPage();
            ucEventPlanner1 = new UserControls.ucEventPlanner();
            invites = new TabPage();
            ucEventInvites1 = new UserControls.ucEventInvites();
            tcEvent.SuspendLayout();
            myEvents.SuspendLayout();
            invites.SuspendLayout();
            SuspendLayout();
            // 
            // tcEvent
            // 
            tcEvent.Controls.Add(myEvents);
            tcEvent.Controls.Add(invites);
            tcEvent.Dock = DockStyle.Fill;
            tcEvent.Location = new Point(0, 0);
            tcEvent.Name = "tcEvent";
            tcEvent.SelectedIndex = 0;
            tcEvent.Size = new Size(800, 450);
            tcEvent.TabIndex = 0;
            // 
            // myEvents
            // 
            myEvents.Controls.Add(ucEventPlanner1);
            myEvents.Location = new Point(4, 24);
            myEvents.Name = "myEvents";
            myEvents.Padding = new Padding(3);
            myEvents.Size = new Size(792, 422);
            myEvents.TabIndex = 0;
            myEvents.Text = "My Events";
            myEvents.UseVisualStyleBackColor = true;
            // 
            // ucEventPlanner1
            // 
            ucEventPlanner1.Dock = DockStyle.Fill;
            ucEventPlanner1.Location = new Point(3, 3);
            ucEventPlanner1.Name = "ucEventPlanner1";
            ucEventPlanner1.Size = new Size(786, 416);
            ucEventPlanner1.TabIndex = 0;
            // 
            // invites
            // 
            invites.Controls.Add(ucEventInvites1);
            invites.Location = new Point(4, 24);
            invites.Name = "invites";
            invites.Padding = new Padding(3);
            invites.Size = new Size(792, 422);
            invites.TabIndex = 1;
            invites.Text = "Invites";
            invites.UseVisualStyleBackColor = true;
            // 
            // ucEventInvites1
            // 
            ucEventInvites1.Dock = DockStyle.Fill;
            ucEventInvites1.Location = new Point(3, 3);
            ucEventInvites1.Name = "ucEventInvites1";
            ucEventInvites1.Size = new Size(786, 416);
            ucEventInvites1.TabIndex = 0;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcEvent);
            Name = "EventForm";
            Text = "EventForm";
            tcEvent.ResumeLayout(false);
            myEvents.ResumeLayout(false);
            invites.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcEvent;
        private TabPage myEvents;
        private TabPage invites;
        private UserControls.ucEventPlanner ucEventPlanner1;
        private UserControls.ucEventInvites ucEventInvites1;
    }
}