namespace SkyBook_Final_Project
{
    partial class AdminSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSales));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            flpSidebar = new FlowLayoutPanel();
            panel3 = new Panel();
            btnBack = new Button();
            panel8 = new Panel();
            btnExit = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            cmbSales = new ReaLTaiizor.Controls.DungeonComboBox();
            btnSubmit = new ReaLTaiizor.Controls.SkyButton();
            chartSalesAnalytics = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1.SuspendLayout();
            flpSidebar.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(1154, 32);
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
            nightControlBox1.Location = new Point(1015, 0);
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
            skyLabel1.Size = new Size(102, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "Sales Report";
            // 
            // flpSidebar
            // 
            flpSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpSidebar.BackColor = SystemColors.ActiveCaption;
            flpSidebar.Controls.Add(panel3);
            flpSidebar.Controls.Add(panel8);
            flpSidebar.Location = new Point(0, 200);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(234, 540);
            flpSidebar.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnBack);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 67);
            panel3.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(-17, -16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(264, 109);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(btnExit);
            panel8.Location = new Point(3, 76);
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 181);
            panel2.TabIndex = 22;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(240, 185);
            label4.Name = "label4";
            label4.Size = new Size(142, 26);
            label4.TabIndex = 65;
            label4.Text = "Sales Period:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(276, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 65);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // cmbSales
            // 
            cmbSales.BackColor = SystemColors.ActiveCaption;
            cmbSales.ColorA = SystemColors.ActiveCaption;
            cmbSales.ColorB = SystemColors.GradientActiveCaption;
            cmbSales.ColorC = Color.FromArgb(242, 241, 240);
            cmbSales.ColorD = Color.FromArgb(253, 252, 252);
            cmbSales.ColorE = Color.FromArgb(239, 237, 236);
            cmbSales.ColorF = Color.FromArgb(64, 64, 64);
            cmbSales.ColorG = Color.DimGray;
            cmbSales.ColorH = Color.FromArgb(224, 222, 220);
            cmbSales.ColorI = Color.FromArgb(250, 249, 249);
            cmbSales.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSales.DropDownHeight = 100;
            cmbSales.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSales.Font = new Font("Segoe UI", 10F);
            cmbSales.ForeColor = SystemColors.ActiveCaptionText;
            cmbSales.FormattingEnabled = true;
            cmbSales.HoverSelectionColor = Color.Empty;
            cmbSales.IntegralHeight = false;
            cmbSales.ItemHeight = 20;
            cmbSales.Location = new Point(380, 184);
            cmbSales.Name = "cmbSales";
            cmbSales.Size = new Size(232, 26);
            cmbSales.StartIndex = 0;
            cmbSales.TabIndex = 74;
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
            btnSubmit.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.FromArgb(27, 94, 137);
            btnSubmit.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnSubmit.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnSubmit.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnSubmit.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnSubmit.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnSubmit.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSubmit.HoverForeColor = Color.White;
            btnSubmit.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSubmit.Location = new Point(380, 216);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnSubmit.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnSubmit.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnSubmit.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnSubmit.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnSubmit.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnSubmit.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnSubmit.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmit.TabIndex = 75;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chartSalesAnalytics
            // 
            chartSalesAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartSalesAnalytics.Location = new Point(634, 30);
            chartSalesAnalytics.MatchAxesScreenDataRatio = false;
            chartSalesAnalytics.Name = "chartSalesAnalytics";
            chartSalesAnalytics.Size = new Size(517, 667);
            chartSalesAnalytics.TabIndex = 76;
            // 
            // AdminSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ui__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 726);
            Controls.Add(chartSalesAnalytics);
            Controls.Add(btnSubmit);
            Controls.Add(cmbSales);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(flpSidebar);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSales";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flpSidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private FlowLayoutPanel flpSidebar;
        private Panel panel8;
        private Button btnExit;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button btnBack;
        private Label label4;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonComboBox cmbSales;
        private ReaLTaiizor.Controls.SkyButton btnSubmit;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartSalesAnalytics;
    }
}