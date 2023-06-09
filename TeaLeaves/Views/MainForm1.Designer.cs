namespace TeaLeaves.Views
{
    partial class MainForm1
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
            manageContactsButton=new Button();
            btnMessages=new Button();
            SuspendLayout();
            // 
            // manageContactsButton
            // 
            manageContactsButton.Location=new Point(0, 0);
            manageContactsButton.Name="manageContactsButton";
            manageContactsButton.Size=new Size(75, 23);
            manageContactsButton.TabIndex=0;
            manageContactsButton.Text="Contacts";
            manageContactsButton.UseVisualStyleBackColor=true;
            manageContactsButton.Click+=manageContactsButton_Click;
            // 
            // btnMessages
            // 
            btnMessages.Location=new Point(81, 0);
            btnMessages.Name="btnMessages";
            btnMessages.Size=new Size(75, 23);
            btnMessages.TabIndex=1;
            btnMessages.Text="Message";
            btnMessages.UseVisualStyleBackColor=true;
            btnMessages.Click+=btnMessages_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btnMessages);
            Controls.Add(manageContactsButton);
            Name="MainForm";
            StartPosition=FormStartPosition.CenterScreen;
            Text="MainForm";
            FormClosed+=MainForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button manageContactsButton;
        private Button btnMessages;
    }
}