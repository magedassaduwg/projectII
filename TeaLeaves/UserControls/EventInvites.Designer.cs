namespace TeaLeaves.UserControls
{
    partial class EventInvites
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
            dgvEventInvites = new DataGridView();
            btnAccept = new Button();
            btnDecline = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).BeginInit();
            SuspendLayout();
            // 
            // dgvEventInvites
            // 
            dgvEventInvites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventInvites.Location = new Point(58, 73);
            dgvEventInvites.Name = "dgvEventInvites";
            dgvEventInvites.RowTemplate.Height = 25;
            dgvEventInvites.Size = new Size(557, 349);
            dgvEventInvites.TabIndex = 0;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(651, 73);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(126, 57);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            btnDecline.Location = new Point(651, 152);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(126, 57);
            btnDecline.TabIndex = 2;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = true;
            // 
            // EventInvites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDecline);
            Controls.Add(btnAccept);
            Controls.Add(dgvEventInvites);
            Name = "EventInvites";
            Size = new Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)dgvEventInvites).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEventInvites;
        private Button btnAccept;
        private Button btnDecline;
    }
}
