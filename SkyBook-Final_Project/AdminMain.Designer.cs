namespace SkyBook_Final_Project
{
    partial class AdminMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            panel1 = new Panel();
            btnHam = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            flpSidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            btnAddUsers = new Button();
            panel2 = new Panel();
            btnSales = new Button();
            panel6 = new Panel();
            btnBack = new Button();
            panel8 = new Panel();
            btnExit = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            flpSidebar.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnHam);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(skyLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 32);
            panel1.TabIndex = 1;
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(12, 0);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(31, 32);
            btnHam.TabIndex = 3;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
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
            nightControlBox1.Location = new Point(761, 0);
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
            skyLabel1.Location = new Point(54, 9);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(286, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "SkyBook - Flight Reservation System";
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = SystemColors.ActiveCaption;
            flpSidebar.Controls.Add(panel3);
            flpSidebar.Controls.Add(panel2);
            flpSidebar.Controls.Add(panel6);
            flpSidebar.Controls.Add(panel8);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.Location = new Point(0, 32);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(52, 518);
            flpSidebar.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnAddUsers);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 81);
            panel3.TabIndex = 9;
            // 
            // btnAddUsers
            // 
            btnAddUsers.BackColor = SystemColors.ActiveCaption;
            btnAddUsers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUsers.ForeColor = SystemColors.ButtonHighlight;
            btnAddUsers.Image = (Image)resources.GetObject("btnAddUsers.Image");
            btnAddUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUsers.Location = new Point(-6, -23);
            btnAddUsers.Name = "btnAddUsers";
            btnAddUsers.Size = new Size(260, 110);
            btnAddUsers.TabIndex = 1;
            btnAddUsers.Text = "           Add Crew Users";
            btnAddUsers.UseVisualStyleBackColor = false;
            btnAddUsers.Click += btnAddUsers_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnSales);
            panel2.Location = new Point(3, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 64);
            panel2.TabIndex = 6;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.Transparent;
            btnSales.BackgroundImage = (Image)resources.GetObject("btnSales.BackgroundImage");
            btnSales.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = SystemColors.ButtonHighlight;
            btnSales.Location = new Point(-10, -7);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(273, 85);
            btnSales.TabIndex = 1;
            btnSales.Text = "            Sales Report";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(btnBack);
            panel6.Location = new Point(3, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(247, 64);
            panel6.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(-19, -22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(273, 109);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(btnExit);
            panel8.Location = new Point(3, 230);
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
            btnExit.Location = new Point(-6, -24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(280, 109);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 1;
            sidebarTransition.Tick += sidebarTransition_Tick_1;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 550);
            Controls.Add(flpSidebar);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMain";
            Text = "AdminMain";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            flpSidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private FlowLayoutPanel flpSidebar;
        private Panel panel6;
        private Panel panel8;
        private Button btnExit;
        private Button btnSales;
        private Panel panel2;
        private Button btnAddUsers;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel3;
        private Button btnBack;
    }
}