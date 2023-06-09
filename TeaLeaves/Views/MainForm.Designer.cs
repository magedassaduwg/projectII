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
            tabControlMain=new TabControl();
            tabPageMessage=new TabPage();
            tabPageEvent=new TabPage();
            ucEventPlanner1=new UserControls.ucEventPlanner();
            tabPageInvites=new TabPage();
            tabPageContact=new TabPage();
            tabControlMain.SuspendLayout();
            tabPageEvent.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageMessage);
            tabControlMain.Controls.Add(tabPageEvent);
            tabControlMain.Controls.Add(tabPageInvites);
            tabControlMain.Controls.Add(tabPageContact);
            tabControlMain.Dock=DockStyle.Fill;
            tabControlMain.Location=new Point(0, 0);
            tabControlMain.Name="tabControlMain";
            tabControlMain.SelectedIndex=0;
            tabControlMain.Size=new Size(564, 359);
            tabControlMain.TabIndex=0;
            // 
            // tabPageMessage
            // 
            tabPageMessage.Location=new Point(4, 24);
            tabPageMessage.Name="tabPageMessage";
            tabPageMessage.Padding=new Padding(3);
            tabPageMessage.Size=new Size(556, 331);
            tabPageMessage.TabIndex=0;
            tabPageMessage.Text="Message";
            tabPageMessage.UseVisualStyleBackColor=true;
            // 
            // tabPageEvent
            // 
            tabPageEvent.Controls.Add(ucEventPlanner1);
            tabPageEvent.Location=new Point(4, 24);
            tabPageEvent.Name="tabPageEvent";
            tabPageEvent.Padding=new Padding(3);
            tabPageEvent.Size=new Size(556, 331);
            tabPageEvent.TabIndex=1;
            tabPageEvent.Text="Event Planner";
            tabPageEvent.UseVisualStyleBackColor=true;
            // 
            // ucEventPlanner1
            // 
            ucEventPlanner1.Dock=DockStyle.Fill;
            ucEventPlanner1.Location=new Point(3, 3);
            ucEventPlanner1.Name="ucEventPlanner1";
            ucEventPlanner1.Size=new Size(550, 325);
            ucEventPlanner1.TabIndex=1;
         
            // 
            // tabPageInvites
            // 
            tabPageInvites.Location=new Point(4, 24);
            tabPageInvites.Name="tabPageInvites";
            tabPageInvites.Padding=new Padding(3);
            tabPageInvites.Size=new Size(556, 331);
            tabPageInvites.TabIndex=2;
            tabPageInvites.Text="Event Invite";
            tabPageInvites.UseVisualStyleBackColor=true;
            // 
            // tabPageContact
            // 
            tabPageContact.Location=new Point(4, 24);
            tabPageContact.Name="tabPageContact";
            tabPageContact.Padding=new Padding(3);
            tabPageContact.Size=new Size(556, 331);
            tabPageContact.TabIndex=3;
            tabPageContact.Text="Contact";
            tabPageContact.UseVisualStyleBackColor=true;
            // 
            // MainForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(564, 359);
            Controls.Add(tabControlMain);
            Name="MainForm";
            Text="MainForm";
            tabControlMain.ResumeLayout(false);
            tabPageEvent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageEvent;
        private TabPage tabPageMessage;
        private UserControls.ucEventPlanner ucEventPlanner1;
        private TabPage tabPageInvites;
        private TabPage tabPageContact;
        private TableLayoutPanel tableLayoutPanel1;
    }
}