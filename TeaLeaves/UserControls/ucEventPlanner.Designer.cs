namespace TeaLeaves.UserControls
{
    partial class ucEventPlanner
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
            components=new System.ComponentModel.Container();
            tableLayoutPanelEvent=new TableLayoutPanel();
            panelHeader=new Panel();
            labelHeader=new Label();
            dgEvents=new DataGridView();
            eventBindingSource=new BindingSource(components);
            buttonAdd=new Button();
            btnEdit=new Button();
            btnDelete=new Button();
            btnInvites=new Button();
            EventName=new DataGridViewTextBoxColumn();
            Category=new DataGridViewTextBoxColumn();
            EventDateTime=new DataGridViewTextBoxColumn();
            Description=new DataGridViewTextBoxColumn();
            StreetNumber=new DataGridViewTextBoxColumn();
            City=new DataGridViewTextBoxColumn();
            State=new DataGridViewTextBoxColumn();
            Zipcode=new DataGridViewTextBoxColumn();
            tableLayoutPanelEvent.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelEvent
            // 
            tableLayoutPanelEvent.BackColor=Color.WhiteSmoke;
            tableLayoutPanelEvent.ColumnCount=5;
            tableLayoutPanelEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelEvent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelEvent.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanelEvent.Controls.Add(dgEvents, 0, 1);
            tableLayoutPanelEvent.Controls.Add(buttonAdd, 1, 2);
            tableLayoutPanelEvent.Controls.Add(btnEdit, 2, 2);
            tableLayoutPanelEvent.Controls.Add(btnDelete, 3, 2);
            tableLayoutPanelEvent.Controls.Add(btnInvites, 0, 2);
            tableLayoutPanelEvent.Dock=DockStyle.Fill;
            tableLayoutPanelEvent.Location=new Point(0, 0);
            tableLayoutPanelEvent.Name="tableLayoutPanelEvent";
            tableLayoutPanelEvent.RowCount=4;
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelEvent.Size=new Size(862, 376);
            tableLayoutPanelEvent.TabIndex=0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor=Color.DarkOrange;
            tableLayoutPanelEvent.SetColumnSpan(panelHeader, 5);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock=DockStyle.Fill;
            panelHeader.Font=new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            panelHeader.ForeColor=Color.DarkGreen;
            panelHeader.Location=new Point(3, 3);
            panelHeader.Name="panelHeader";
            panelHeader.Size=new Size(856, 50);
            panelHeader.TabIndex=0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize=true;
            labelHeader.Font=new Font("Segoe UI Semibold", 20F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            labelHeader.Location=new Point(16, 0);
            labelHeader.Name="labelHeader";
            labelHeader.Size=new Size(186, 37);
            labelHeader.TabIndex=0;
            labelHeader.Text="Event Planner";
            labelHeader.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // dgEvents
            // 
            dgEvents.AllowUserToAddRows=false;
            dgEvents.AllowUserToDeleteRows=false;
            dgEvents.AutoGenerateColumns=false;
            dgEvents.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgEvents.BackgroundColor=Color.PapayaWhip;
            dgEvents.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEvents.Columns.AddRange(new DataGridViewColumn[] { EventName, Category, EventDateTime, Description, StreetNumber, City, State, Zipcode });
            tableLayoutPanelEvent.SetColumnSpan(dgEvents, 5);
            dgEvents.DataSource=eventBindingSource;
            dgEvents.Dock=DockStyle.Fill;
            dgEvents.Location=new Point(3, 59);
            dgEvents.MultiSelect=false;
            dgEvents.Name="dgEvents";
            dgEvents.ReadOnly=true;
            dgEvents.RowTemplate.Height=25;
            dgEvents.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgEvents.Size=new Size(856, 219);
            dgEvents.TabIndex=1;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonAdd.BackColor=Color.Orange;
            buttonAdd.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor=Color.DarkGreen;
            buttonAdd.Location=new Point(175, 297);
            buttonAdd.Name="buttonAdd";
            buttonAdd.Size=new Size(166, 43);
            buttonAdd.TabIndex=1;
            buttonAdd.Text="Add";
            buttonAdd.UseVisualStyleBackColor=false;
            buttonAdd.Click+=buttonAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            btnEdit.BackColor=Color.Orange;
            btnEdit.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor=Color.DarkGreen;
            btnEdit.Location=new Point(347, 295);
            btnEdit.Name="btnEdit";
            btnEdit.Size=new Size(166, 46);
            btnEdit.TabIndex=2;
            btnEdit.Text="Edit";
            btnEdit.UseVisualStyleBackColor=false;
            btnEdit.Click+=btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            btnDelete.BackColor=Color.Orange;
            btnDelete.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor=Color.DarkGreen;
            btnDelete.Location=new Point(519, 295);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new Size(166, 46);
            btnDelete.TabIndex=3;
            btnDelete.Text="Delete";
            btnDelete.UseVisualStyleBackColor=false;
            btnDelete.Click+=btnDelete_Click;
            // 
            // btnInvites
            // 
            btnInvites.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            btnInvites.BackColor=Color.Orange;
            btnInvites.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvites.ForeColor=Color.DarkGreen;
            btnInvites.Location=new Point(3, 295);
            btnInvites.Name="btnInvites";
            btnInvites.Size=new Size(166, 46);
            btnInvites.TabIndex=4;
            btnInvites.Text="Invites";
            btnInvites.UseVisualStyleBackColor=false;
            btnInvites.Click+=btnInvites_Click;
            // 
            // EventName
            // 
            EventName.DataPropertyName="EventName";
            EventName.HeaderText="Event Name";
            EventName.Name="EventName";
            EventName.ReadOnly=true;
            // 
            // Category
            // 
            Category.DataPropertyName="Category";
            Category.HeaderText="Category";
            Category.Name="Category";
            Category.ReadOnly=true;
            // 
            // EventDateTime
            // 
            EventDateTime.DataPropertyName="EventDateTime";
            EventDateTime.HeaderText="Date";
            EventDateTime.Name="EventDateTime";
            EventDateTime.ReadOnly=true;
            // 
            // Description
            // 
            Description.DataPropertyName="Description";
            Description.HeaderText="Description";
            Description.Name="Description";
            Description.ReadOnly=true;
            // 
            // StreetNumber
            // 
            StreetNumber.DataPropertyName="StreetNumber";
            StreetNumber.HeaderText="Street Number";
            StreetNumber.Name="StreetNumber";
            StreetNumber.ReadOnly=true;
            // 
            // City
            // 
            City.DataPropertyName="City";
            City.HeaderText="City";
            City.Name="City";
            City.ReadOnly=true;
            // 
            // State
            // 
            State.DataPropertyName="State";
            State.HeaderText="State";
            State.Name="State";
            State.ReadOnly=true;
            // 
            // Zipcode
            // 
            Zipcode.DataPropertyName="Zipcode";
            Zipcode.HeaderText="Zipcode";
            Zipcode.Name="Zipcode";
            Zipcode.ReadOnly=true;
            // 
            // ucEventPlanner
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelEvent);
            Name="ucEventPlanner";
            Size=new Size(862, 376);
            Load+=ucEventPlanner_Load;
            tableLayoutPanelEvent.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelEvent;
        private Panel panelHeader;
        private Label labelHeader;
        private DataGridView dgEvents;
        private Button buttonAdd;
        private Button btnEdit;
        private Button btnDelete;
        private BindingSource eventBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private Button btnInvites;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn EventDateTime;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn StreetNumber;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn Zipcode;
    }
}
