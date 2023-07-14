namespace TeaLeaves.Views
{
    partial class ProfileContactBookForm
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
            components = new System.ComponentModel.Container();
            userProfilePictureBox = new PictureBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            usernameLabel = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            emailText = new TextBox();
            usernameText = new TextBox();
            closeButton = new Button();
            viewProfileButton = new Button();
            usersBindingSource = new BindingSource(components);
            sortButton = new Button();
            contactDataGridView = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            contactLayoutPanel = new TableLayoutPanel();
            SelectedContactTable = new TableLayoutPanel();
            addContactButton = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)userProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).BeginInit();
            contactLayoutPanel.SuspendLayout();
            SelectedContactTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // userProfilePictureBox
            // 
            userProfilePictureBox.Dock = DockStyle.Fill;
            userProfilePictureBox.Image = Properties.Resources.tealeaves_logo;
            userProfilePictureBox.Location = new Point(355, 3);
            userProfilePictureBox.Name = "userProfilePictureBox";
            SelectedContactTable.SetRowSpan(userProfilePictureBox, 2);
            userProfilePictureBox.Size = new Size(172, 174);
            userProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilePictureBox.TabIndex = 16;
            userProfilePictureBox.TabStop = false;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.Right;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(37, 24);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(57, 42);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Right;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(4, 124);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 21);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(42, 214);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 21);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(7, 304);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(87, 21);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // firstNameText
            // 
            firstNameText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(firstNameText, 2);
            firstNameText.Location = new Point(100, 33);
            firstNameText.Name = "firstNameText";
            firstNameText.ReadOnly = true;
            firstNameText.Size = new Size(210, 23);
            firstNameText.TabIndex = 10;
            // 
            // lastNameText
            // 
            lastNameText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(lastNameText, 2);
            lastNameText.Location = new Point(100, 123);
            lastNameText.Name = "lastNameText";
            lastNameText.ReadOnly = true;
            lastNameText.Size = new Size(210, 23);
            lastNameText.TabIndex = 11;
            // 
            // emailText
            // 
            emailText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(emailText, 2);
            emailText.Location = new Point(100, 213);
            emailText.Name = "emailText";
            emailText.ReadOnly = true;
            emailText.Size = new Size(210, 23);
            emailText.TabIndex = 12;
            // 
            // usernameText
            // 
            usernameText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(usernameText, 2);
            usernameText.Location = new Point(100, 303);
            usernameText.Name = "usernameText";
            usernameText.ReadOnly = true;
            usernameText.Size = new Size(210, 23);
            usernameText.TabIndex = 13;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.None;
            closeButton.BackColor = Color.YellowGreen;
            closeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            closeButton.ForeColor = Color.DarkGreen;
            closeButton.Location = new Point(394, 388);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 33);
            closeButton.TabIndex = 9;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // viewProfileButton
            // 
            viewProfileButton.Anchor = AnchorStyles.None;
            viewProfileButton.BackColor = Color.YellowGreen;
            viewProfileButton.Enabled = false;
            viewProfileButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            viewProfileButton.ForeColor = Color.DarkGreen;
            viewProfileButton.Location = new Point(249, 388);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(94, 33);
            viewProfileButton.TabIndex = 15;
            viewProfileButton.Text = "Profile";
            viewProfileButton.UseVisualStyleBackColor = false;
            viewProfileButton.Click += viewProfileButton_Click;
            // 
            // sortButton
            // 
            sortButton.Anchor = AnchorStyles.None;
            sortButton.BackColor = Color.Orange;
            contactLayoutPanel.SetColumnSpan(sortButton, 2);
            sortButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            sortButton.ForeColor = Color.DarkGreen;
            sortButton.Location = new Point(87, 406);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(92, 33);
            sortButton.TabIndex = 9;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += sortButton_Click;
            // 
            // contactDataGridView
            // 
            contactDataGridView.AllowUserToAddRows = false;
            contactDataGridView.AllowUserToDeleteRows = false;
            contactDataGridView.AutoGenerateColumns = false;
            contactDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            contactDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactDataGridView.Columns.AddRange(new DataGridViewColumn[] { FullName });
            contactLayoutPanel.SetColumnSpan(contactDataGridView, 2);
            contactDataGridView.DataSource = usersBindingSource;
            contactDataGridView.Dock = DockStyle.Fill;
            contactDataGridView.Location = new Point(3, 3);
            contactDataGridView.MultiSelect = false;
            contactDataGridView.Name = "contactDataGridView";
            contactDataGridView.ReadOnly = true;
            contactDataGridView.RowTemplate.Height = 40;
            contactDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contactDataGridView.Size = new Size(260, 389);
            contactDataGridView.TabIndex = 0;
            contactDataGridView.CellFormatting += contactDataGridView_CellFormatting;
            contactDataGridView.RowEnter += contactDataGridView_RowEnter;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // contactLayoutPanel
            // 
            contactLayoutPanel.ColumnCount = 2;
            contactLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contactLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contactLayoutPanel.Controls.Add(sortButton, 0, 1);
            contactLayoutPanel.Controls.Add(contactDataGridView, 0, 0);
            contactLayoutPanel.Dock = DockStyle.Fill;
            contactLayoutPanel.Location = new Point(0, 0);
            contactLayoutPanel.Name = "contactLayoutPanel";
            contactLayoutPanel.RowCount = 2;
            contactLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 87.77778F));
            contactLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2222223F));
            contactLayoutPanel.Size = new Size(266, 450);
            contactLayoutPanel.TabIndex = 1;
            // 
            // SelectedContactTable
            // 
            SelectedContactTable.ColumnCount = 4;
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.524334F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.158556F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.320755F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.396225F));
            SelectedContactTable.Controls.Add(userProfilePictureBox, 3, 0);
            SelectedContactTable.Controls.Add(firstNameLabel, 0, 0);
            SelectedContactTable.Controls.Add(lastNameLabel, 0, 1);
            SelectedContactTable.Controls.Add(emailLabel, 0, 2);
            SelectedContactTable.Controls.Add(usernameLabel, 0, 3);
            SelectedContactTable.Controls.Add(firstNameText, 1, 0);
            SelectedContactTable.Controls.Add(lastNameText, 1, 1);
            SelectedContactTable.Controls.Add(emailText, 1, 2);
            SelectedContactTable.Controls.Add(usernameText, 1, 3);
            SelectedContactTable.Controls.Add(closeButton, 3, 4);
            SelectedContactTable.Controls.Add(viewProfileButton, 2, 4);
            SelectedContactTable.Controls.Add(addContactButton, 1, 4);
            SelectedContactTable.Dock = DockStyle.Fill;
            SelectedContactTable.Location = new Point(0, 0);
            SelectedContactTable.Name = "SelectedContactTable";
            SelectedContactTable.RowCount = 5;
            SelectedContactTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SelectedContactTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SelectedContactTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SelectedContactTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SelectedContactTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            SelectedContactTable.Size = new Size(530, 450);
            SelectedContactTable.TabIndex = 0;
            // 
            // addContactButton
            // 
            addContactButton.Anchor = AnchorStyles.None;
            addContactButton.BackColor = Color.YellowGreen;
            addContactButton.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addContactButton.ForeColor = Color.DarkGreen;
            addContactButton.Location = new Point(111, 388);
            addContactButton.Name = "addContactButton";
            addContactButton.Size = new Size(115, 33);
            addContactButton.TabIndex = 17;
            addContactButton.Text = " Add Friend";
            addContactButton.UseVisualStyleBackColor = false;
            addContactButton.Click += addContactButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(contactLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SelectedContactTable);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 1;
            // 
            // ProfileContactBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "ProfileContactBookForm";
            Text = "ProfileContactBookForm";
            Load += ProfileContactBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)userProfilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).EndInit();
            contactLayoutPanel.ResumeLayout(false);
            SelectedContactTable.ResumeLayout(false);
            SelectedContactTable.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox userProfilePictureBox;
        private TableLayoutPanel SelectedContactTable;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label usernameLabel;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox emailText;
        private TextBox usernameText;
        private Button closeButton;
        private Button viewProfileButton;
        private BindingSource usersBindingSource;
        private Button sortButton;
        private DataGridView contactDataGridView;
        private TableLayoutPanel contactLayoutPanel;
        private SplitContainer splitContainer1;
        private Button addContactButton;
        private DataGridViewTextBoxColumn FullName;
    }
}