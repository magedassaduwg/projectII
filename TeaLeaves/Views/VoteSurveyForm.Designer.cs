﻿namespace TeaLeaves.Views
{
    partial class VoteSurveyForm
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
            cbSurveyOptions = new ComboBox();
            lblSurveyQuestion = new Label();
            btnVote = new Button();
            lblSeletedVote = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // cbSurveyOptions
            // 
            cbSurveyOptions.BackColor = Color.PapayaWhip;
            cbSurveyOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSurveyOptions.FormattingEnabled = true;
            cbSurveyOptions.Location = new Point(61, 116);
            cbSurveyOptions.Name = "cbSurveyOptions";
            cbSurveyOptions.Size = new Size(297, 23);
            cbSurveyOptions.TabIndex = 0;
            // 
            // lblSurveyQuestion
            // 
            lblSurveyQuestion.AutoSize = true;
            lblSurveyQuestion.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSurveyQuestion.ForeColor = Color.DarkGreen;
            lblSurveyQuestion.Location = new Point(61, 33);
            lblSurveyQuestion.Name = "lblSurveyQuestion";
            lblSurveyQuestion.Size = new Size(77, 28);
            lblSurveyQuestion.TabIndex = 1;
            lblSurveyQuestion.Text = "Survey";
            // 
            // btnVote
            // 
            btnVote.BackColor = Color.YellowGreen;
            btnVote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVote.ForeColor = Color.DarkGreen;
            btnVote.Location = new Point(384, 116);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(75, 23);
            btnVote.TabIndex = 1;
            btnVote.Text = "Vote";
            btnVote.UseVisualStyleBackColor = false;
            btnVote.Click += btnVote_Click;
            // 
            // lblSeletedVote
            // 
            lblSeletedVote.AutoSize = true;
            lblSeletedVote.BackColor = SystemColors.Control;
            lblSeletedVote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeletedVote.ForeColor = Color.DarkOrange;
            lblSeletedVote.Location = new Point(61, 156);
            lblSeletedVote.Name = "lblSeletedVote";
            lblSeletedVote.Size = new Size(0, 21);
            lblSeletedVote.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DarkGreen;
            btnBack.Location = new Point(12, 231);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 43);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // VoteSurveyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 286);
            Controls.Add(btnBack);
            Controls.Add(lblSeletedVote);
            Controls.Add(btnVote);
            Controls.Add(lblSurveyQuestion);
            Controls.Add(cbSurveyOptions);
            Name = "VoteSurveyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VoteSurveyForm";
            FormClosed += VoteSurveyForm_FormClosed;
            Load += VoteSurveyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSurveyOptions;
        private Label lblSurveyQuestion;
        private Button btnVote;
        private Label lblSeletedVote;
        private Button btnBack;
    }
}