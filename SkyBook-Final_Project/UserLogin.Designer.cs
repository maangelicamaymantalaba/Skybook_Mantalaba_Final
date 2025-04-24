namespace SkyBook_Final_Project
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            panel1 = new Panel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new ReaLTaiizor.Controls.SkyButton();
            LnkChangePass = new LinkLabel();
            chckbxShowPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(foreverClose1);
            panel1.Controls.Add(skyLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 32);
            panel1.TabIndex = 19;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = SystemColors.ButtonHighlight;
            foreverClose1.BaseColor = SystemColors.ActiveCaption;
            foreverClose1.DefaultLocation = false;
            foreverClose1.DownColor = SystemColors.ActiveCaption;
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.ForeColor = SystemColors.ActiveCaption;
            foreverClose1.Location = new Point(505, 7);
            foreverClose1.MaximumSize = new Size(20, 20);
            foreverClose1.MinimumSize = new Size(20, 20);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = SystemColors.ActiveCaption;
            foreverClose1.Size = new Size(20, 20);
            foreverClose1.TabIndex = 2;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = SystemColors.ButtonHighlight;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(12, 7);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(47, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(189, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 159);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(499, 129);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(202, 369);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 34);
            txtUsername.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(73, 374);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 23;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(82, 460);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 24;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(202, 451);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(241, 34);
            txtPassword.TabIndex = 25;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnLogin.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnLogin.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnLogin.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnLogin.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnLogin.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnLogin.DownForeColor = Color.White;
            btnLogin.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnLogin.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(27, 94, 137);
            btnLogin.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnLogin.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnLogin.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnLogin.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnLogin.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnLogin.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnLogin.HoverForeColor = Color.White;
            btnLogin.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnLogin.Location = new Point(102, 559);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnLogin.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnLogin.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnLogin.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnLogin.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnLogin.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnLogin.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnLogin.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnLogin.Size = new Size(94, 29);
            btnLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 26;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // LnkChangePass
            // 
            LnkChangePass.AutoSize = true;
            LnkChangePass.BackColor = Color.Transparent;
            LnkChangePass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LnkChangePass.LinkColor = Color.WhiteSmoke;
            LnkChangePass.Location = new Point(289, 563);
            LnkChangePass.Name = "LnkChangePass";
            LnkChangePass.Size = new Size(154, 25);
            LnkChangePass.TabIndex = 27;
            LnkChangePass.TabStop = true;
            LnkChangePass.Text = "Change password";
            LnkChangePass.LinkClicked += LnkChangePass_LinkClicked;
            // 
            // chckbxShowPass
            // 
            chckbxShowPass.AutoSize = true;
            chckbxShowPass.BackColor = Color.Transparent;
            chckbxShowPass.ForeColor = SystemColors.ButtonHighlight;
            chckbxShowPass.Location = new Point(202, 491);
            chckbxShowPass.Name = "chckbxShowPass";
            chckbxShowPass.Size = new Size(132, 24);
            chckbxShowPass.TabIndex = 28;
            chckbxShowPass.Text = "Show Password";
            chckbxShowPass.UseVisualStyleBackColor = false;
            chckbxShowPass.CheckedChanged += chckbxShowPass_CheckedChanged;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(537, 676);
            Controls.Add(chckbxShowPass);
            Controls.Add(LnkChangePass);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private ReaLTaiizor.Controls.SkyButton btnLogin;
        private LinkLabel LnkChangePass;
        private CheckBox chckbxShowPass;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
    }
}