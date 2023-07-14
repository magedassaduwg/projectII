namespace TeaLeaves.UserControls
{
    partial class ucManageContacts
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
            components = new System.ComponentModel.Container();
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
            deleteButton = new Button();
            usersBindingSource = new BindingSource(components);
            addButton = new Button();
            contactDataGridView = new DataGridView();
            contactLayoutPanel = new TableLayoutPanel();
            SelectedContactTable = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            button4 = new Button();
            dgvContacts = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).BeginInit();
            contactLayoutPanel.SuspendLayout();
            SelectedContactTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.Right;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(30, 100);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Right;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(4, 105);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(30, 105);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(4, 210);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(30, 63);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(6, 273);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(28, 105);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // firstNameText
            // 
            firstNameText.Anchor = AnchorStyles.Left;
            firstNameText.Location = new Point(40, 41);
            firstNameText.Name = "firstNameText";
            firstNameText.ReadOnly = true;
            firstNameText.Size = new Size(102, 23);
            firstNameText.TabIndex = 10;
            // 
            // lastNameText
            // 
            lastNameText.Anchor = AnchorStyles.Left;
            lastNameText.Location = new Point(40, 146);
            lastNameText.Name = "lastNameText";
            lastNameText.ReadOnly = true;
            lastNameText.Size = new Size(102, 23);
            lastNameText.TabIndex = 11;
            // 
            // emailText
            // 
            emailText.Anchor = AnchorStyles.Left;
            emailText.Location = new Point(40, 230);
            emailText.Name = "emailText";
            emailText.ReadOnly = true;
            emailText.Size = new Size(102, 23);
            emailText.TabIndex = 12;
            // 
            // usernameText
            // 
            usernameText.Anchor = AnchorStyles.Left;
            usernameText.Location = new Point(40, 314);
            usernameText.Name = "usernameText";
            usernameText.ReadOnly = true;
            usernameText.Size = new Size(102, 23);
            usernameText.TabIndex = 13;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.None;
            closeButton.BackColor = Color.YellowGreen;
            closeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            closeButton.ForeColor = Color.DarkGreen;
            closeButton.Location = new Point(148, 381);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(49, 33);
            closeButton.TabIndex = 9;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // viewProfileButton
            // 
            viewProfileButton.Anchor = AnchorStyles.None;
            viewProfileButton.BackColor = Color.YellowGreen;
            viewProfileButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            viewProfileButton.ForeColor = Color.DarkGreen;
            viewProfileButton.Location = new Point(40, 381);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(48, 33);
            viewProfileButton.TabIndex = 15;
            viewProfileButton.Text = "Profile";
            viewProfileButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.YellowGreen;
            deleteButton.Enabled = false;
            deleteButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.DarkGreen;
            deleteButton.Location = new Point(94, 381);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(48, 33);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.Orange;
            contactLayoutPanel.SetColumnSpan(addButton, 2);
            addButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addButton.ForeColor = Color.DarkGreen;
            addButton.Location = new Point(3, 90);
            addButton.Name = "addButton";
            addButton.Size = new Size(44, 7);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // contactDataGridView
            // 
            contactDataGridView.AllowUserToAddRows = false;
            contactDataGridView.AllowUserToDeleteRows = false;
            contactDataGridView.AutoGenerateColumns = false;
            contactDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactLayoutPanel.SetColumnSpan(contactDataGridView, 2);
            contactDataGridView.DataSource = usersBindingSource;
            contactDataGridView.Dock = DockStyle.Fill;
            contactDataGridView.Location = new Point(3, 3);
            contactDataGridView.MultiSelect = false;
            contactDataGridView.Name = "contactDataGridView";
            contactDataGridView.ReadOnly = true;
            contactDataGridView.RowTemplate.Height = 25;
            contactDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contactDataGridView.Size = new Size(44, 81);
            contactDataGridView.TabIndex = 0;
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
            contactLayoutPanel.Size = new Size(50, 100);
            contactLayoutPanel.TabIndex = 1;
            // 
            // SelectedContactTable
            // 
            SelectedContactTable.ColumnCount = 4;
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.524334F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.158556F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.158556F));
            SelectedContactTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.158556F));
            SelectedContactTable.Controls.Add(firstNameLabel, 0, 0);
            SelectedContactTable.Location = new Point(0, 0);
            SelectedContactTable.Name = "SelectedContactTable";
            SelectedContactTable.RowCount = 1;
            SelectedContactTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SelectedContactTable.Size = new Size(200, 100);
            SelectedContactTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 138);
            label2.Name = "label2";
            label2.Size = new Size(173, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 237);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(89, 336);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.SetColumnSpan(textBox1, 2);
            textBox1.Location = new Point(182, 38);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.SetColumnSpan(textBox2, 2);
            textBox2.Location = new Point(182, 137);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.SetColumnSpan(textBox3, 2);
            textBox3.Location = new Point(182, 236);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.SetColumnSpan(textBox4, 2);
            textBox4.Location = new Point(182, 335);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(198, 23);
            textBox4.TabIndex = 13;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.YellowGreen;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkGreen;
            button2.Location = new Point(183, 429);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 15;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.YellowGreen;
            button3.Enabled = false;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkGreen;
            button3.Location = new Point(285, 429);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Orange;
            tableLayoutPanel1.SetColumnSpan(button4, 2);
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkGreen;
            button4.Location = new Point(83, 448);
            button4.Name = "button4";
            button4.Size = new Size(92, 33);
            button4.TabIndex = 8;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Columns.AddRange(new DataGridViewColumn[] { FullName });
            tableLayoutPanel1.SetColumnSpan(dgvContacts, 2);
            dgvContacts.Dock = DockStyle.Fill;
            dgvContacts.Location = new Point(3, 3);
            dgvContacts.MultiSelect = false;
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowTemplate.Height = 40;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(252, 428);
            dgvContacts.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvContacts, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.77778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2222223F));
            tableLayoutPanel1.Size = new Size(258, 495);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel2.Controls.Add(button2, 1, 4);
            tableLayoutPanel2.Controls.Add(button3, 2, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(514, 495);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(776, 495);
            splitContainer1.SplitterDistance = 258;
            splitContainer1.TabIndex = 1;
            // 
            // ucManageContacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ucManageContacts";
            Size = new Size(776, 495);
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactDataGridView).EndInit();
            contactLayoutPanel.ResumeLayout(false);
            SelectedContactTable.ResumeLayout(false);
            SelectedContactTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
        private Button deleteButton;
        private BindingSource usersBindingSource;
        private Button addButton;
        private TableLayoutPanel contactLayoutPanel;
        private DataGridView contactDataGridView;
        private TableLayoutPanel SelectedContactTable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
        private BindingSource bindingSource1;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvContacts;
        private SplitContainer splitContainer1;
        private DataGridViewTextBoxColumn FullName;
    }
}
