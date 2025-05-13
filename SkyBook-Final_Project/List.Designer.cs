namespace SkyBook_Final_Project
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            label6 = new Label();
            dgvPassengers = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnBackToForm1 = new Button();
            pictureBox2 = new PictureBox();
            txtPassenger = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtCrew = new TextBox();
            btnSearchCrew = new ReaLTaiizor.Controls.SkyButton();
            dgvCrew = new DataGridView();
            btnSearchPassengers = new ReaLTaiizor.Controls.SkyButton();
            label3 = new Label();
            txtFlightNo = new TextBox();
            btnSearchFlightNo = new ReaLTaiizor.Controls.SkyButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCrew).BeginInit();
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
            panel1.Size = new Size(1186, 32);
            panel1.TabIndex = 20;
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
            nightControlBox1.Location = new Point(1047, 0);
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
            skyLabel1.Size = new Size(190, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "Passenger and Crew List";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(186, 48);
            label6.Name = "label6";
            label6.Size = new Size(147, 23);
            label6.TabIndex = 29;
            label6.Text = "PASSENGERS";
            // 
            // dgvPassengers
            // 
            dgvPassengers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPassengers.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPassengers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassengers.Location = new Point(186, 122);
            dgvPassengers.Name = "dgvPassengers";
            dgvPassengers.RowHeadersWidth = 51;
            dgvPassengers.Size = new Size(976, 298);
            dgvPassengers.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(186, 423);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 31;
            label2.Text = "CREW MEMBERS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-221, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 668);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // btnBackToForm1
            // 
            btnBackToForm1.BackColor = SystemColors.GradientInactiveCaption;
            btnBackToForm1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToForm1.ForeColor = SystemColors.Highlight;
            btnBackToForm1.Location = new Point(0, 205);
            btnBackToForm1.Name = "btnBackToForm1";
            btnBackToForm1.Size = new Size(177, 43);
            btnBackToForm1.TabIndex = 34;
            btnBackToForm1.Text = "Back";
            btnBackToForm1.UseVisualStyleBackColor = false;
            btnBackToForm1.Click += btnBackToForm1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.logo_najud__1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 161);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // txtPassenger
            // 
            txtPassenger.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassenger.Location = new Point(264, 84);
            txtPassenger.Name = "txtPassenger";
            txtPassenger.Size = new Size(291, 30);
            txtPassenger.TabIndex = 36;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(186, 88);
            label4.Name = "label4";
            label4.Size = new Size(72, 26);
            label4.TabIndex = 37;
            label4.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 468);
            label1.Name = "label1";
            label1.Size = new Size(72, 26);
            label1.TabIndex = 38;
            label1.Text = "Name:";
            // 
            // txtCrew
            // 
            txtCrew.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCrew.Location = new Point(264, 464);
            txtCrew.Name = "txtCrew";
            txtCrew.Size = new Size(291, 30);
            txtCrew.TabIndex = 39;
            // 
            // btnSearchCrew
            // 
            btnSearchCrew.BackColor = Color.Transparent;
            btnSearchCrew.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnSearchCrew.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnSearchCrew.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnSearchCrew.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnSearchCrew.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnSearchCrew.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSearchCrew.DownForeColor = Color.White;
            btnSearchCrew.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSearchCrew.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchCrew.ForeColor = Color.FromArgb(27, 94, 137);
            btnSearchCrew.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnSearchCrew.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnSearchCrew.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnSearchCrew.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnSearchCrew.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnSearchCrew.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSearchCrew.HoverForeColor = Color.White;
            btnSearchCrew.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSearchCrew.Location = new Point(561, 462);
            btnSearchCrew.Name = "btnSearchCrew";
            btnSearchCrew.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnSearchCrew.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnSearchCrew.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnSearchCrew.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnSearchCrew.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnSearchCrew.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnSearchCrew.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnSearchCrew.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnSearchCrew.Size = new Size(70, 32);
            btnSearchCrew.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearchCrew.TabIndex = 58;
            btnSearchCrew.Text = "SEARCH";
            btnSearchCrew.Click += btnSearchCrew_Click;
            // 
            // dgvCrew
            // 
            dgvCrew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCrew.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvCrew.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCrew.Location = new Point(186, 497);
            dgvCrew.Name = "dgvCrew";
            dgvCrew.RowHeadersWidth = 51;
            dgvCrew.Size = new Size(983, 236);
            dgvCrew.TabIndex = 59;
            // 
            // btnSearchPassengers
            // 
            btnSearchPassengers.BackColor = Color.Transparent;
            btnSearchPassengers.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnSearchPassengers.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnSearchPassengers.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnSearchPassengers.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnSearchPassengers.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnSearchPassengers.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSearchPassengers.DownForeColor = Color.White;
            btnSearchPassengers.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSearchPassengers.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchPassengers.ForeColor = Color.FromArgb(27, 94, 137);
            btnSearchPassengers.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnSearchPassengers.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnSearchPassengers.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnSearchPassengers.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnSearchPassengers.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnSearchPassengers.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSearchPassengers.HoverForeColor = Color.White;
            btnSearchPassengers.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSearchPassengers.Location = new Point(561, 84);
            btnSearchPassengers.Name = "btnSearchPassengers";
            btnSearchPassengers.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnSearchPassengers.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnSearchPassengers.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnSearchPassengers.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnSearchPassengers.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnSearchPassengers.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnSearchPassengers.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnSearchPassengers.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnSearchPassengers.Size = new Size(70, 32);
            btnSearchPassengers.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearchPassengers.TabIndex = 60;
            btnSearchPassengers.Text = "SEARCH";
            btnSearchPassengers.Click += btnSearchPassengers_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(637, 88);
            label3.Name = "label3";
            label3.Size = new Size(150, 26);
            label3.TabIndex = 61;
            label3.Text = "Flight Number:";
            // 
            // txtFlightNo
            // 
            txtFlightNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFlightNo.Location = new Point(793, 84);
            txtFlightNo.Name = "txtFlightNo";
            txtFlightNo.Size = new Size(291, 30);
            txtFlightNo.TabIndex = 62;
            // 
            // btnSearchFlightNo
            // 
            btnSearchFlightNo.BackColor = Color.Transparent;
            btnSearchFlightNo.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnSearchFlightNo.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnSearchFlightNo.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnSearchFlightNo.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnSearchFlightNo.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnSearchFlightNo.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSearchFlightNo.DownForeColor = Color.White;
            btnSearchFlightNo.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSearchFlightNo.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchFlightNo.ForeColor = Color.FromArgb(27, 94, 137);
            btnSearchFlightNo.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnSearchFlightNo.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnSearchFlightNo.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnSearchFlightNo.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnSearchFlightNo.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnSearchFlightNo.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSearchFlightNo.HoverForeColor = Color.White;
            btnSearchFlightNo.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSearchFlightNo.Location = new Point(1092, 82);
            btnSearchFlightNo.Name = "btnSearchFlightNo";
            btnSearchFlightNo.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnSearchFlightNo.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnSearchFlightNo.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnSearchFlightNo.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnSearchFlightNo.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnSearchFlightNo.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnSearchFlightNo.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnSearchFlightNo.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnSearchFlightNo.Size = new Size(70, 32);
            btnSearchFlightNo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearchFlightNo.TabIndex = 63;
            btnSearchFlightNo.Text = "SEARCH";
            btnSearchFlightNo.Click += btnSearchFlightNo_Click;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1186, 734);
            Controls.Add(btnSearchFlightNo);
            Controls.Add(txtFlightNo);
            Controls.Add(label3);
            Controls.Add(btnSearchPassengers);
            Controls.Add(dgvCrew);
            Controls.Add(btnSearchCrew);
            Controls.Add(txtCrew);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtPassenger);
            Controls.Add(pictureBox2);
            Controls.Add(btnBackToForm1);
            Controls.Add(dgvPassengers);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "List";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCrew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Label label6;
        private DataGridView dgvPassengers;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnBackToForm1;
        private PictureBox pictureBox2;
        private TextBox txtPassenger;
        private Label label4;
        private Label label1;
        private TextBox txtCrew;
        private ReaLTaiizor.Controls.SkyButton btnSearchCrew;
        private DataGridView dgvCrew;
        private ReaLTaiizor.Controls.SkyButton btnSearchPassengers;
        private Label label3;
        private TextBox txtFlightNo;
        private ReaLTaiizor.Controls.SkyButton btnSearchFlightNo;
    }
}