namespace SkyBook_Final_Project
{
    partial class AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            flpSidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            btnBack = new Button();
            panel8 = new Panel();
            btnExit = new Button();
            dgvUser = new DataGridView();
            label3 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            cmbAdmin = new ReaLTaiizor.Controls.DungeonComboBox();
            btnSubmit = new ReaLTaiizor.Controls.SkyButton();
            btnDelete = new ReaLTaiizor.Controls.SkyButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flpSidebar.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(skyLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 32);
            panel1.TabIndex = 19;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = SystemColors.ButtonHighlight;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(914, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(12, 9);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(117, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "Add new users";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 185);
            panel2.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(26, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 156);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // flpSidebar
            // 
            flpSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpSidebar.BackColor = SystemColors.ActiveCaption;
            flpSidebar.Controls.Add(panel3);
            flpSidebar.Controls.Add(panel8);
            flpSidebar.Location = new Point(0, 200);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(234, 396);
            flpSidebar.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnBack);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 60);
            panel3.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(-17, -32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(278, 124);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(btnExit);
            panel8.Location = new Point(3, 69);
            panel8.Name = "panel8";
            panel8.Size = new Size(247, 64);
            panel8.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(-17, -24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(294, 109);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgvUser
            // 
            dgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.BackgroundColor = SystemColors.ActiveCaption;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(570, 30);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(483, 566);
            dgvUser.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(279, 252);
            label3.Name = "label3";
            label3.Size = new Size(76, 26);
            label3.TabIndex = 26;
            label3.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(355, 253);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(240, 307);
            label1.Name = "label1";
            label1.Size = new Size(115, 26);
            label1.TabIndex = 36;
            label1.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(355, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(209, 27);
            txtPassword.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(312, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 177);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(282, 357);
            label2.Name = "label2";
            label2.Size = new Size(73, 26);
            label2.TabIndex = 50;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(355, 356);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 27);
            txtEmail.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(275, 405);
            label4.Name = "label4";
            label4.Size = new Size(80, 26);
            label4.TabIndex = 52;
            label4.Text = "Admin:";
            // 
            // cmbAdmin
            // 
            cmbAdmin.BackColor = SystemColors.ActiveCaption;
            cmbAdmin.ColorA = SystemColors.ActiveCaption;
            cmbAdmin.ColorB = SystemColors.GradientActiveCaption;
            cmbAdmin.ColorC = Color.FromArgb(242, 241, 240);
            cmbAdmin.ColorD = Color.FromArgb(253, 252, 252);
            cmbAdmin.ColorE = Color.FromArgb(239, 237, 236);
            cmbAdmin.ColorF = Color.FromArgb(64, 64, 64);
            cmbAdmin.ColorG = Color.DimGray;
            cmbAdmin.ColorH = Color.FromArgb(224, 222, 220);
            cmbAdmin.ColorI = Color.FromArgb(250, 249, 249);
            cmbAdmin.DrawMode = DrawMode.OwnerDrawFixed;
            cmbAdmin.DropDownHeight = 100;
            cmbAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdmin.Font = new Font("Segoe UI", 10F);
            cmbAdmin.ForeColor = SystemColors.ActiveCaptionText;
            cmbAdmin.FormattingEnabled = true;
            cmbAdmin.HoverSelectionColor = Color.Empty;
            cmbAdmin.IntegralHeight = false;
            cmbAdmin.ItemHeight = 20;
            cmbAdmin.Location = new Point(355, 405);
            cmbAdmin.Name = "cmbAdmin";
            cmbAdmin.Size = new Size(209, 26);
            cmbAdmin.StartIndex = 0;
            cmbAdmin.TabIndex = 73;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnSubmit.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnSubmit.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnSubmit.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnSubmit.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnSubmit.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSubmit.DownForeColor = Color.White;
            btnSubmit.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSubmit.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.FromArgb(27, 94, 137);
            btnSubmit.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnSubmit.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnSubmit.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnSubmit.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnSubmit.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnSubmit.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSubmit.HoverForeColor = Color.White;
            btnSubmit.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSubmit.Location = new Point(355, 446);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnSubmit.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnSubmit.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnSubmit.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnSubmit.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnSubmit.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnSubmit.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnSubmit.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnSubmit.Size = new Size(99, 32);
            btnSubmit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmit.TabIndex = 76;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnDelete.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnDelete.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnDelete.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnDelete.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnDelete.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnDelete.DownForeColor = Color.White;
            btnDelete.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnDelete.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(27, 94, 137);
            btnDelete.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnDelete.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnDelete.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnDelete.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnDelete.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnDelete.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnDelete.HoverForeColor = Color.White;
            btnDelete.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnDelete.Location = new Point(460, 446);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnDelete.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnDelete.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnDelete.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnDelete.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnDelete.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnDelete.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnDelete.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnDelete.Size = new Size(104, 32);
            btnDelete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDelete.TabIndex = 77;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // AddUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ui__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1053, 592);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            Controls.Add(cmbAdmin);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(flpSidebar);
            Controls.Add(dgvUser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUsers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flpSidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flpSidebar;
        private Panel panel3;
        private Button btnBack;
        private Panel panel8;
        private Button btnExit;
        private DataGridView dgvUser;
        private Label label3;
        private TextBox txtName;
        private Label label1;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtEmail;
        private Label label4;
        private ReaLTaiizor.Controls.DungeonComboBox cmbAdmin;
        private ReaLTaiizor.Controls.SkyButton btnSubmit;
        private ReaLTaiizor.Controls.SkyButton btnDelete;
    }
}