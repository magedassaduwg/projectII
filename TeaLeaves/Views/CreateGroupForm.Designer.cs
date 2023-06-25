namespace TeaLeaves.Views
{
    partial class frmCreateGroup
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
            tblContacts = new TableLayoutPanel();
            tblActionButtons = new TableLayoutPanel();
            btnCancel = new Button();
            btnCreate = new Button();
            lstContacts = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtGroupName = new TextBox();
            lblGroupName = new Label();
            tblContacts.SuspendLayout();
            tblActionButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblContacts
            // 
            tblContacts.ColumnCount = 1;
            tblContacts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContacts.Controls.Add(tblActionButtons, 0, 2);
            tblContacts.Controls.Add(lstContacts, 0, 1);
            tblContacts.Controls.Add(tableLayoutPanel1, 0, 0);
            tblContacts.Dock = DockStyle.Fill;
            tblContacts.Location = new Point(0, 0);
            tblContacts.Name = "tblContacts";
            tblContacts.RowCount = 3;
            tblContacts.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblContacts.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tblContacts.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblContacts.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblContacts.Size = new Size(362, 450);
            tblContacts.TabIndex = 0;
            // 
            // tblActionButtons
            // 
            tblActionButtons.ColumnCount = 2;
            tblActionButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblActionButtons.Controls.Add(btnCancel, 0, 0);
            tblActionButtons.Controls.Add(btnCreate, 1, 0);
            tblActionButtons.Dock = DockStyle.Fill;
            tblActionButtons.Location = new Point(3, 385);
            tblActionButtons.Name = "tblActionButtons";
            tblActionButtons.RowCount = 1;
            tblActionButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblActionButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblActionButtons.Size = new Size(356, 62);
            tblActionButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.Orange;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.DarkGreen;
            btnCancel.Location = new Point(3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(172, 56);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreate.BackColor = Color.YellowGreen;
            btnCreate.DialogResult = DialogResult.OK;
            btnCreate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.DarkGreen;
            btnCreate.Location = new Point(181, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(172, 56);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Create Group";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lstContacts
            // 
            lstContacts.DisplayMember = "FullName";
            lstContacts.Dock = DockStyle.Fill;
            lstContacts.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstContacts.FormattingEnabled = true;
            lstContacts.ItemHeight = 20;
            lstContacts.Location = new Point(3, 70);
            lstContacts.Name = "lstContacts";
            lstContacts.SelectionMode = SelectionMode.MultiSimple;
            lstContacts.Size = new Size(356, 309);
            lstContacts.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(txtGroupName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblGroupName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(356, 61);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtGroupName
            // 
            txtGroupName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGroupName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtGroupName.Location = new Point(109, 17);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(244, 27);
            txtGroupName.TabIndex = 0;
            // 
            // lblGroupName
            // 
            lblGroupName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblGroupName.AutoSize = true;
            lblGroupName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGroupName.Location = new Point(3, 20);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(100, 20);
            lblGroupName.TabIndex = 1;
            lblGroupName.Text = "Group Name";
            // 
            // frmCreateGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(tblContacts);
            Name = "frmCreateGroup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Group";
            Load += frmCreateGroup_Load;
            tblContacts.ResumeLayout(false);
            tblActionButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblContacts;
        private TableLayoutPanel tblActionButtons;
        private Button btnCancel;
        private Button btnCreate;
        private ListBox lstContacts;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtGroupName;
        private Label lblGroupName;
    }
}