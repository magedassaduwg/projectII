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
            contactDataGridView = new DataGridView();
            SelectedContactTable = new TableLayoutPanel();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            usernameLabel = new Label();
            editButton = new Button();
            saveChangeButton = new Button();
            closeButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            usersBindingSource = new BindingSource(components);
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).BeginInit();
            SelectedContactTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(contactDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SelectedContactTable);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // contactDataGridView
            // 
            contactDataGridView.AllowUserToAddRows = false;
            contactDataGridView.AllowUserToDeleteRows = false;
            contactDataGridView.AutoGenerateColumns = false;
            contactDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactDataGridView.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            contactDataGridView.DataSource = usersBindingSource;
            contactDataGridView.Dock = DockStyle.Fill;
            contactDataGridView.Location = new Point(0, 0);
            contactDataGridView.Name = "contactDataGridView";
            contactDataGridView.ReadOnly = true;
            contactDataGridView.RowTemplate.Height = 25;
            contactDataGridView.Size = new Size(266, 450);
            contactDataGridView.TabIndex = 0;
            // 
            // SelectedContactTable
            // 
            SelectedContactTable.ColumnCount = 3;
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.1040459F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.89595F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            SelectedContactTable.Controls.Add(firstNameLabel, 0, 0);
            SelectedContactTable.Controls.Add(lastNameLabel, 0, 1);
            SelectedContactTable.Controls.Add(emailLabel, 0, 2);
            SelectedContactTable.Controls.Add(usernameLabel, 0, 3);
            SelectedContactTable.Controls.Add(editButton, 0, 4);
            SelectedContactTable.Controls.Add(saveChangeButton, 1, 4);
            SelectedContactTable.Controls.Add(closeButton, 2, 4);
            SelectedContactTable.Controls.Add(textBox1, 1, 0);
            SelectedContactTable.Controls.Add(textBox2, 1, 1);
            SelectedContactTable.Controls.Add(textBox3, 1, 2);
            SelectedContactTable.Controls.Add(textBox4, 1, 3);
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
            firstNameLabel.Location = new Point(47, 34);
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
            lastNameLabel.Location = new Point(49, 124);
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
            emailLabel.Location = new Point(87, 214);
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
            usernameLabel.Location = new Point(52, 304);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(87, 21);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            editButton.Location = new Point(24, 388);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 33);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // saveChangeButton
            // 
            saveChangeButton.Anchor = AnchorStyles.None;
            saveChangeButton.Enabled = false;
            saveChangeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            saveChangeButton.Location = new Point(232, 388);
            saveChangeButton.Name = "saveChangeButton";
            saveChangeButton.Size = new Size(94, 33);
            saveChangeButton.TabIndex = 8;
            saveChangeButton.Text = "Save";
            saveChangeButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.None;
            closeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            closeButton.Location = new Point(426, 388);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 33);
            closeButton.TabIndex = 9;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(145, 33);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(145, 123);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(145, 213);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(210, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.Location = new Point(145, 303);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(210, 23);
            textBox4.TabIndex = 13;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "ManageContactForm";
            Text = "ManageContactForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).EndInit();
            SelectedContactTable.ResumeLayout(false);
            SelectedContactTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
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
        private Button editButton;
        private Button saveChangeButton;
        private Button closeButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private BindingSource usersBindingSource;
    }
}