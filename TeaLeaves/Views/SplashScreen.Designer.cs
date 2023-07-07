namespace TeaLeaves.Views
{
    partial class SplashScreen
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
            lblLoading = new Label();
            SuspendLayout();
            // 
            // lblLoading
            // 
            lblLoading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoading.Location = new Point(215, 148);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(279, 86);
            lblLoading.TabIndex = 0;
            lblLoading.Text = "Loading";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "SplashScreen";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoading;
    }
}