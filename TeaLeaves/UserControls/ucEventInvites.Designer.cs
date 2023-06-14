namespace TeaLeaves.UserControls
{
    partial class ucEventInvites
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
            dgvEventInvites=new DataGridView();
            eventName=new DataGridViewTextBoxColumn();
            eventDateAndTime=new DataGridViewTextBoxColumn();
            eventDescription=new DataGridViewTextBoxColumn();
            btnAccept=new Button();
            btnDecline=new Button();
            btnRefresh=new Button();
            btnView=new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            SuspendLayout();
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.AllowUserToAddRows=false;
            dgvEventInvites.AllowUserToDeleteRows=false;
            dgvEventInvites.BackgroundColor=Color.PapayaWhip;
            dgvEventInvites.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Columns.AddRange(new DataGridViewColumn[] { eventName, eventDateAndTime, eventDescription });
            dgvEventInvites.Location=new Point(0, 0);
            dgvEventInvites.Name="dgvEventInvites";
            dgvEventInvites.ReadOnly=true;
            dgvEventInvites.RowTemplate.Height=25;
            dgvEventInvites.ScrollBars=ScrollBars.Vertical;
            dgvEventInvites.Size=new Size(765, 313);
            dgvEventInvites.TabIndex=0;
            // 
            // eventName
            // 
            eventName.DataPropertyName="Name";
            eventName.Frozen=true;
            eventName.HeaderText="Name";
            eventName.Name="eventName";
            eventName.ReadOnly=true;
            eventName.Width=150;
            // 
            // eventDateAndTime
            // 
            eventDateAndTime.DataPropertyName="DateTime";
            eventDateAndTime.Frozen=true;
            eventDateAndTime.HeaderText="Time";
            eventDateAndTime.Name="eventDateAndTime";
            eventDateAndTime.ReadOnly=true;
            eventDateAndTime.Width=180;
            // 
            // eventDescription
            // 
            eventDescription.DataPropertyName="Description";
            eventDescription.Frozen=true;
            eventDescription.HeaderText="Description";
            eventDescription.Name="eventDescription";
            eventDescription.ReadOnly=true;
            eventDescription.Width=392;
            // 
            // btnAccept
            // 
            btnAccept.BackColor=Color.Orange;
            btnAccept.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccept.ForeColor=Color.DarkGreen;
            btnAccept.Location=new Point(771, 11);
            btnAccept.Name="btnAccept";
            btnAccept.Size=new Size(126, 57);
            btnAccept.TabIndex=1;
            btnAccept.Text="Accept";
            btnAccept.UseVisualStyleBackColor=false;
            btnAccept.Click+=btnAccept_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor=Color.Orange;
            btnDecline.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecline.ForeColor=Color.DarkGreen;
            btnDecline.Location=new Point(771, 74);
            btnDecline.Name="btnDecline";
            btnDecline.Size=new Size(126, 57);
            btnDecline.TabIndex=2;
            btnDecline.Text="Decline";
            btnDecline.UseVisualStyleBackColor=false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor=Color.Orange;
            btnRefresh.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor=Color.DarkGreen;
            btnRefresh.Location=new Point(771, 200);
            btnRefresh.Name="btnRefresh";
            btnRefresh.Size=new Size(126, 57);
            btnRefresh.TabIndex=3;
            btnRefresh.Text="Refresh";
            btnRefresh.UseVisualStyleBackColor=false;
            btnRefresh.Click+=btnRefresh_Click;
            // 
            // btnView
            // 
            btnView.BackColor=Color.Orange;
            btnView.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor=Color.DarkGreen;
            btnView.Location=new Point(774, 137);
            btnView.Name="btnView";
            btnView.Size=new Size(126, 57);
            btnView.TabIndex=4;
            btnView.Text="View";
            btnView.UseVisualStyleBackColor=false;
            // 
            // ucEventInvites
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(btnView);
            Controls.Add(btnRefresh);
            Controls.Add(btnDecline);
            Controls.Add(btnAccept);
            Controls.Add(dgvEventInvites);
            Name="ucEventInvites";
            Size=new Size(900, 315);
            Load+=ucEventInvites_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEventInvites;
        private Button btnAccept;
        private Button btnDecline;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn eventName;
        private DataGridViewTextBoxColumn eventDateAndTime;
        private DataGridViewTextBoxColumn eventDescription;
        private Button btnView;
    }
}
