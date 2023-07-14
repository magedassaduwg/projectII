namespace TeaLeaves.Views
{
    partial class ProfileForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            userProfilePictureBox = new PictureBox();
            userBlurbLabel = new Label();
            userBlurbBox = new TextBox();
            editButton = new Button();
            saveButton = new Button();
            uploadButton = new Button();
            statsButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            friendListButton = new Button();
            closeButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userProfilePictureBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Controls.Add(userProfilePictureBox, 1, 0);
            tableLayoutPanel1.Controls.Add(userBlurbLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(userBlurbBox, 1, 2);
            tableLayoutPanel1.Controls.Add(editButton, 2, 3);
            tableLayoutPanel1.Controls.Add(saveButton, 2, 2);
            tableLayoutPanel1.Controls.Add(uploadButton, 2, 0);
            tableLayoutPanel1.Controls.Add(statsButton, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.83668F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.163324F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(449, 583);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // userProfilePictureBox
            // 
            userProfilePictureBox.Dock = DockStyle.Fill;
            userProfilePictureBox.Image = Properties.Resources.tealeaves_logo;
            userProfilePictureBox.Location = new Point(78, 3);
            userProfilePictureBox.Name = "userProfilePictureBox";
            userProfilePictureBox.Size = new Size(294, 318);
            userProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilePictureBox.TabIndex = 0;
            userProfilePictureBox.TabStop = false;
            // 
            // userBlurbLabel
            // 
            userBlurbLabel.Anchor = AnchorStyles.Left;
            userBlurbLabel.AutoSize = true;
            userBlurbLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userBlurbLabel.Location = new Point(78, 326);
            userBlurbLabel.Name = "userBlurbLabel";
            userBlurbLabel.Size = new Size(88, 21);
            userBlurbLabel.TabIndex = 1;
            userBlurbLabel.Text = "Biography:";
            // 
            // userBlurbBox
            // 
            userBlurbBox.Dock = DockStyle.Fill;
            userBlurbBox.Location = new Point(78, 352);
            userBlurbBox.Multiline = true;
            userBlurbBox.Name = "userBlurbBox";
            userBlurbBox.ReadOnly = true;
            userBlurbBox.Size = new Size(294, 182);
            userBlurbBox.TabIndex = 2;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.Enabled = false;
            editButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            editButton.Location = new Point(379, 544);
            editButton.Name = "editButton";
            editButton.Size = new Size(66, 31);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Visible = false;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Enabled = false;
            saveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            saveButton.Location = new Point(379, 427);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(66, 31);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // uploadButton
            // 
            uploadButton.Anchor = AnchorStyles.None;
            uploadButton.Enabled = false;
            uploadButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            uploadButton.Location = new Point(379, 146);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(66, 31);
            uploadButton.TabIndex = 0;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Visible = false;
            uploadButton.Click += uploadButton_Click;
            // 
            // statsButton
            // 
            statsButton.Anchor = AnchorStyles.None;
            statsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            statsButton.Location = new Point(8, 427);
            statsButton.Name = "statsButton";
            statsButton.Size = new Size(58, 31);
            statsButton.TabIndex = 1;
            statsButton.Text = "Stats";
            statsButton.UseVisualStyleBackColor = true;
            statsButton.Click += statsButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(friendListButton);
            flowLayoutPanel1.Controls.Add(closeButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(78, 540);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(294, 40);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // friendListButton
            // 
            friendListButton.Anchor = AnchorStyles.Left;
            friendListButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            friendListButton.Location = new Point(3, 3);
            friendListButton.Name = "friendListButton";
            friendListButton.Size = new Size(151, 31);
            friendListButton.TabIndex = 4;
            friendListButton.Text = "Friends";
            friendListButton.UseVisualStyleBackColor = true;
            friendListButton.Click += friendListButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Right;
            closeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            closeButton.Location = new Point(160, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(127, 31);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 583);
            Controls.Add(tableLayoutPanel1);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeaLeaves";
            Load += ProfileForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userProfilePictureBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox userProfilePictureBox;
        private Label userBlurbLabel;
        private TextBox userBlurbBox;
        private Button closeButton;
        private Button editButton;
        private Button saveButton;
        private Button uploadButton;
        private Button statsButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button friendListButton;
    }
}