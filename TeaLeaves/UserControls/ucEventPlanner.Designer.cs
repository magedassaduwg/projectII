﻿namespace TeaLeaves.UserControls
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
            dataGridViewEvent=new DataGridView();
            eventBindingSource=new BindingSource(components);
            buttonAdd=new Button();
            buttonView=new Button();
            buttonDelete=new Button();
            idDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            eventDateTimeDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            streetNumberDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            tableLayoutPanelEvent.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvent).BeginInit();
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
            tableLayoutPanelEvent.Controls.Add(dataGridViewEvent, 0, 1);
            tableLayoutPanelEvent.Controls.Add(buttonAdd, 1, 2);
            tableLayoutPanelEvent.Controls.Add(buttonView, 2, 2);
            tableLayoutPanelEvent.Controls.Add(buttonDelete, 3, 2);
            tableLayoutPanelEvent.Dock=DockStyle.Fill;
            tableLayoutPanelEvent.Location=new Point(0, 0);
            tableLayoutPanelEvent.Name="tableLayoutPanelEvent";
            tableLayoutPanelEvent.RowCount=4;
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelEvent.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelEvent.Size=new Size(571, 376);
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
            panelHeader.Size=new Size(565, 50);
            panelHeader.TabIndex=0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize=true;
            labelHeader.Font=new Font("Segoe UI Semibold", 20F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            labelHeader.Location=new Point(192, 0);
            labelHeader.Name="labelHeader";
            labelHeader.Size=new Size(186, 37);
            labelHeader.TabIndex=0;
            labelHeader.Text="Event Planner";
            labelHeader.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // dataGridViewEvent
            // 
            dataGridViewEvent.AutoGenerateColumns=false;
            dataGridViewEvent.BackgroundColor=Color.PapayaWhip;
            dataGridViewEvent.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvent.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, eventDateTimeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, streetNumberDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn });
            tableLayoutPanelEvent.SetColumnSpan(dataGridViewEvent, 5);
            dataGridViewEvent.DataSource=eventBindingSource;
            dataGridViewEvent.Dock=DockStyle.Fill;
            dataGridViewEvent.Location=new Point(3, 59);
            dataGridViewEvent.Name="dataGridViewEvent";
            dataGridViewEvent.RowTemplate.Height=25;
            dataGridViewEvent.Size=new Size(565, 219);
            dataGridViewEvent.TabIndex=1;
            dataGridViewEvent.CellContentClick+=dataGridViewEvent_CellContentClick;
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource=typeof(Models.Event);
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonAdd.BackColor=Color.Orange;
            buttonAdd.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor=Color.DarkGreen;
            buttonAdd.Location=new Point(117, 307);
            buttonAdd.Name="buttonAdd";
            buttonAdd.Size=new Size(108, 23);
            buttonAdd.TabIndex=2;
            buttonAdd.Text="Add";
            buttonAdd.UseVisualStyleBackColor=false;
            buttonAdd.Click+=buttonAdd_Click;
            // 
            // buttonView
            // 
            buttonView.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonView.BackColor=Color.Orange;
            buttonView.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonView.ForeColor=Color.DarkGreen;
            buttonView.Location=new Point(231, 307);
            buttonView.Name="buttonView";
            buttonView.Size=new Size(108, 23);
            buttonView.TabIndex=3;
            buttonView.Text="View";
            buttonView.UseVisualStyleBackColor=false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            buttonDelete.BackColor=Color.Orange;
            buttonDelete.Font=new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor=Color.DarkGreen;
            buttonDelete.Location=new Point(345, 307);
            buttonDelete.Name="buttonDelete";
            buttonDelete.Size=new Size(108, 23);
            buttonDelete.TabIndex=4;
            buttonDelete.Text="Delete";
            buttonDelete.UseVisualStyleBackColor=false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName="Id";
            idDataGridViewTextBoxColumn.HeaderText="Id";
            idDataGridViewTextBoxColumn.Name="idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName="Name";
            nameDataGridViewTextBoxColumn.HeaderText="Name";
            nameDataGridViewTextBoxColumn.Name="nameDataGridViewTextBoxColumn";
            // 
            // eventDateTimeDataGridViewTextBoxColumn
            // 
            eventDateTimeDataGridViewTextBoxColumn.DataPropertyName="EventDateTime";
            eventDateTimeDataGridViewTextBoxColumn.HeaderText="Date & Time";
            eventDateTimeDataGridViewTextBoxColumn.Name="eventDateTimeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName="Description";
            descriptionDataGridViewTextBoxColumn.HeaderText="Description";
            descriptionDataGridViewTextBoxColumn.Name="descriptionDataGridViewTextBoxColumn";
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            streetNumberDataGridViewTextBoxColumn.DataPropertyName="StreetNumber";
            streetNumberDataGridViewTextBoxColumn.HeaderText="StreetNumber";
            streetNumberDataGridViewTextBoxColumn.Name="streetNumberDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName="City";
            cityDataGridViewTextBoxColumn.HeaderText="City";
            cityDataGridViewTextBoxColumn.Name="cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName="State";
            stateDataGridViewTextBoxColumn.HeaderText="State";
            stateDataGridViewTextBoxColumn.Name="stateDataGridViewTextBoxColumn";
            // 
            // ucEventPlanner
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelEvent);
            Name="ucEventPlanner";
            Size=new Size(571, 376);
            tableLayoutPanelEvent.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvent).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelEvent;
        private Panel panelHeader;
        private Label labelHeader;
        private DataGridView dataGridViewEvent;
        private Button buttonAdd;
        private Button buttonView;
        private Button buttonDelete;
        private BindingSource eventBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}
