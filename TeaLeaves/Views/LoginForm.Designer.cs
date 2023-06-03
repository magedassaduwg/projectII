namespace TeaLeaves
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelImg=new Panel();
            panelLogin=new Panel();
            pictureBoxLogo=new PictureBox();
            labelLogin=new Label();
            pictureBoxUser=new PictureBox();
            pictureBox2=new PictureBox();
            textBoxUsername=new TextBox();
            textBoxPassword=new TextBox();
            panel1=new Panel();
            panel2=new Panel();
            buttonLogin=new Button();
            panelImg.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelImg
            // 
            panelImg.BackColor=Color.Orange;
            panelImg.Controls.Add(pictureBoxLogo);
            panelImg.Dock=DockStyle.Left;
            panelImg.Location=new Point(0, 0);
            panelImg.Name="panelImg";
            panelImg.Size=new Size(309, 450);
            panelImg.TabIndex=0;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(panel2);
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(labelLogin);
            panelLogin.Dock=DockStyle.Fill;
            panelLogin.Location=new Point(309, 0);
            panelLogin.Name="panelLogin";
            panelLogin.Size=new Size(491, 450);
            panelLogin.TabIndex=1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock=DockStyle.Fill;
            pictureBoxLogo.Image=Properties.Resources.tealeaves_logo;
            pictureBoxLogo.Location=new Point(0, 0);
            pictureBoxLogo.Name="pictureBoxLogo";
            pictureBoxLogo.Size=new Size(309, 450);
            pictureBoxLogo.SizeMode=PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex=0;
            pictureBoxLogo.TabStop=false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize=true;
            labelLogin.Font=new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            labelLogin.ForeColor=Color.DarkOrange;
            labelLogin.Location=new Point(128, 43);
            labelLogin.Name="labelLogin";
            labelLogin.Size=new Size(218, 30);
            labelLogin.TabIndex=0;
            labelLogin.Text="Login to your account";
            labelLogin.TextAlign=ContentAlignment.TopCenter;
            labelLogin.Click+=label1_Click;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image=Properties.Resources.user;
            pictureBoxUser.Location=new Point(17, 9);
            pictureBoxUser.Name="pictureBoxUser";
            pictureBoxUser.Size=new Size(30, 30);
            pictureBoxUser.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex=1;
            pictureBoxUser.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources._lock;
            pictureBox2.Location=new Point(17, 6);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(30, 30);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=2;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            textBoxUsername.Location=new Point(67, 16);
            textBoxUsername.Name="textBoxUsername";
            textBoxUsername.Size=new Size(279, 23);
            textBoxUsername.TabIndex=3;
            textBoxUsername.TextChanged+=textBoxUsername_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            textBoxPassword.Location=new Point(67, 13);
            textBoxPassword.Name="textBoxPassword";
            textBoxPassword.Size=new Size(279, 23);
            textBoxPassword.TabIndex=4;
            textBoxPassword.TextChanged+=textBoxPassword_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxUser);
            panel1.Controls.Add(textBoxUsername);
            panel1.Location=new Point(0, 115);
            panel1.Name="panel1";
            panel1.Size=new Size(491, 44);
            panel1.TabIndex=5;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBoxPassword);
            panel2.Location=new Point(0, 165);
            panel2.Name="panel2";
            panel2.Size=new Size(491, 44);
            panel2.TabIndex=6;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor=Color.Orange;
            buttonLogin.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            buttonLogin.ForeColor=Color.OliveDrab;
            buttonLogin.Location=new Point(190, 248);
            buttonLogin.Name="buttonLogin";
            buttonLogin.Size=new Size(111, 47);
            buttonLogin.TabIndex=7;
            buttonLogin.Text="Login";
            buttonLogin.UseVisualStyleBackColor=false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(panelLogin);
            Controls.Add(panelImg);
            Name="LoginForm";
            Text="Login-TeaLeaves";
            panelImg.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImg;
        private PictureBox pictureBoxLogo;
        private Panel panelLogin;
        private Label labelLogin;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBox2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Panel panel1;
        private Panel panel2;
        private Button buttonLogin;
    }
}