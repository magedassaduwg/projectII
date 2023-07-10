namespace TeaLeaves.Views
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
            SuspendLayout();
            // 
            // cbSurveyOptions
            // 
            cbSurveyOptions.BackColor = Color.PapayaWhip;
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
            btnVote.Location = new Point(384, 116);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(75, 23);
            btnVote.TabIndex = 2;
            btnVote.Text = "Vote";
            btnVote.UseVisualStyleBackColor = true;
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
            // VoteSurveyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 286);
            Controls.Add(lblSeletedVote);
            Controls.Add(btnVote);
            Controls.Add(lblSurveyQuestion);
            Controls.Add(cbSurveyOptions);
            Name = "VoteSurveyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VoteSurveyForm";
            Load += VoteSurveyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSurveyOptions;
        private Label lblSurveyQuestion;
        private Button btnVote;
        private Label lblSeletedVote;
    }
}