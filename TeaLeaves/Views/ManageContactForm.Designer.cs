namespace TeaLeaves.Views
{
    partial class ManageContactForm
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
            splitContainer1 = new SplitContainer();
            contactLayoutPanel = new TableLayoutPanel();
            addButton = new Button();
            contactDataGridView = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usersBindingSource = new BindingSource(components);
            SelectedContactTable = new TableLayoutPanel();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            usernameLabel = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            emailText = new TextBox();
            usernameText = new TextBox();
            closeButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contactLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SelectedContactTable.SuspendLayout();
            SuspendLayout();
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
            splitContainer1.TabIndex = 0;
            // 
            // contactLayoutPanel
            // 
            contactLayoutPanel.ColumnCount = 2;
            contactLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contactLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contactLayoutPanel.Controls.Add(addButton, 0, 1);
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
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            contactLayoutPanel.SetColumnSpan(addButton, 2);
            addButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addButton.Location = new Point(87, 406);
            addButton.Name = "addButton";
            addButton.Size = new Size(92, 33);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // contactDataGridView
            // 
            contactDataGridView.AllowUserToAddRows = false;
            contactDataGridView.AllowUserToDeleteRows = false;
            contactDataGridView.AutoGenerateColumns = false;
            contactDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactDataGridView.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            contactLayoutPanel.SetColumnSpan(contactDataGridView, 2);
            contactDataGridView.DataSource = usersBindingSource;
            contactDataGridView.Dock = DockStyle.Fill;
            contactDataGridView.Location = new Point(3, 3);
            contactDataGridView.Name = "contactDataGridView";
            contactDataGridView.ReadOnly = true;
            contactDataGridView.RowTemplate.Height = 25;
            contactDataGridView.Size = new Size(260, 389);
            contactDataGridView.TabIndex = 0;
            contactDataGridView.RowEnter += contactDataGridView_RowEnter;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // SelectedContactTable
            // 
            SelectedContactTable.ColumnCount = 4;
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.524334F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.158556F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.158556F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.158556F));
            SelectedContactTable.Controls.Add(firstNameLabel, 0, 0);
            SelectedContactTable.Controls.Add(lastNameLabel, 0, 1);
            SelectedContactTable.Controls.Add(emailLabel, 0, 2);
            SelectedContactTable.Controls.Add(usernameLabel, 0, 3);
            SelectedContactTable.Controls.Add(firstNameText, 1, 0);
            SelectedContactTable.Controls.Add(lastNameText, 1, 1);
            SelectedContactTable.Controls.Add(emailText, 1, 2);
            SelectedContactTable.Controls.Add(usernameText, 1, 3);
            SelectedContactTable.Controls.Add(deleteButton, 1, 4);
            SelectedContactTable.Controls.Add(closeButton, 2, 4);
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
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.Right;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(3, 34);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(92, 21);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Right;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(5, 124);
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
            emailLabel.Location = new Point(43, 214);
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
            usernameLabel.Location = new Point(8, 304);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(87, 21);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // firstNameText
            // 
            firstNameText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(firstNameText, 2);
            firstNameText.Location = new Point(101, 33);
            firstNameText.Name = "firstNameText";
            firstNameText.ReadOnly = true;
            firstNameText.Size = new Size(210, 23);
            firstNameText.TabIndex = 10;
            // 
            // lastNameText
            // 
            lastNameText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(lastNameText, 2);
            lastNameText.Location = new Point(101, 123);
            lastNameText.Name = "lastNameText";
            lastNameText.ReadOnly = true;
            lastNameText.Size = new Size(210, 23);
            lastNameText.TabIndex = 11;
            // 
            // emailText
            // 
            emailText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(emailText, 2);
            emailText.Location = new Point(101, 213);
            emailText.Name = "emailText";
            emailText.ReadOnly = true;
            emailText.Size = new Size(210, 23);
            emailText.TabIndex = 12;
            // 
            // usernameText
            // 
            usernameText.Anchor = AnchorStyles.Left;
            SelectedContactTable.SetColumnSpan(usernameText, 2);
            usernameText.Location = new Point(101, 303);
            usernameText.Name = "usernameText";
            usernameText.ReadOnly = true;
            usernameText.Size = new Size(210, 23);
            usernameText.TabIndex = 13;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.None;
            closeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            closeButton.Location = new Point(265, 388);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 33);
            closeButton.TabIndex = 9;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Enabled = false;
            deleteButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleteButton.Location = new Point(122, 388);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 33);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // ManageContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "ManageContactForm";
            Text = "ManageContactForm";
            Load += ManageContactForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contactLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            SelectedContactTable.ResumeLayout(false);
            SelectedContactTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView contactDataGridView;
        private TableLayoutPanel SelectedContactTable;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label usernameLabel;
        private Label emailLabel;
        private Button closeButton;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox emailText;
        private TextBox usernameText;
        private BindingSource usersBindingSource;
        private Button deleteButton;
        private TableLayoutPanel contactLayoutPanel;
        private Button addButton;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}