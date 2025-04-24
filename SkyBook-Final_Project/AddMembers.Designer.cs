namespace SkyBook_Final_Project
{
    partial class AddMembers
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
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtname = new TextBox();
            cmbCrewType = new ReaLTaiizor.Controls.DungeonComboBox();
            label1 = new Label();
            label5 = new Label();
            cmbFlightCrew = new ReaLTaiizor.Controls.DungeonComboBox();
            cmbCabinCrew = new ReaLTaiizor.Controls.DungeonComboBox();
            btnSubmit = new ReaLTaiizor.Controls.SkyButton();
            label2 = new Label();
            label7 = new Label();
            dgvCrewMembers = new DataGridView();
            btnClear = new Button();
            btnBackToForm1 = new Button();
            btnDelete = new ReaLTaiizor.Controls.SkyButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCrewMembers).BeginInit();
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
            panel1.Size = new Size(887, 32);
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
            nightControlBox1.Location = new Point(748, 0);
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
            skyLabel1.Size = new Size(271, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "Crew Management – Add Members";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.logo_najud__1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(128, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 166);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 270);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 22;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 317);
            label4.Name = "label4";
            label4.Size = new Size(116, 26);
            label4.TabIndex = 23;
            label4.Text = "Crew Type:";
            // 
            // txtname
            // 
            txtname.Location = new Point(152, 271);
            txtname.Name = "txtname";
            txtname.Size = new Size(246, 27);
            txtname.TabIndex = 34;
            // 
            // cmbCrewType
            // 
            cmbCrewType.BackColor = SystemColors.ActiveCaption;
            cmbCrewType.ColorA = SystemColors.ActiveCaption;
            cmbCrewType.ColorB = SystemColors.GradientActiveCaption;
            cmbCrewType.ColorC = Color.FromArgb(242, 241, 240);
            cmbCrewType.ColorD = Color.FromArgb(253, 252, 252);
            cmbCrewType.ColorE = Color.FromArgb(239, 237, 236);
            cmbCrewType.ColorF = Color.FromArgb(64, 64, 64);
            cmbCrewType.ColorG = Color.DimGray;
            cmbCrewType.ColorH = Color.FromArgb(224, 222, 220);
            cmbCrewType.ColorI = Color.FromArgb(250, 249, 249);
            cmbCrewType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCrewType.DropDownHeight = 100;
            cmbCrewType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCrewType.Font = new Font("Segoe UI", 10F);
            cmbCrewType.ForeColor = SystemColors.ActiveCaptionText;
            cmbCrewType.FormattingEnabled = true;
            cmbCrewType.HoverSelectionColor = Color.Empty;
            cmbCrewType.IntegralHeight = false;
            cmbCrewType.ItemHeight = 20;
            cmbCrewType.Items.AddRange(new object[] { "Flight Crew", "Cabin Crew" });
            cmbCrewType.Location = new Point(152, 317);
            cmbCrewType.Name = "cmbCrewType";
            cmbCrewType.Size = new Size(246, 26);
            cmbCrewType.StartIndex = 0;
            cmbCrewType.TabIndex = 35;
            cmbCrewType.SelectedIndexChanged += cmbCrewType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(152, 355);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 36;
            label1.Text = "Flight Crew";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuText;
            label5.Location = new Point(152, 410);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 37;
            label5.Text = "Cabin Crew";
            // 
            // cmbFlightCrew
            // 
            cmbFlightCrew.BackColor = SystemColors.ActiveCaption;
            cmbFlightCrew.ColorA = SystemColors.ActiveCaption;
            cmbFlightCrew.ColorB = SystemColors.GradientActiveCaption;
            cmbFlightCrew.ColorC = Color.FromArgb(242, 241, 240);
            cmbFlightCrew.ColorD = Color.FromArgb(253, 252, 252);
            cmbFlightCrew.ColorE = Color.FromArgb(239, 237, 236);
            cmbFlightCrew.ColorF = Color.FromArgb(64, 64, 64);
            cmbFlightCrew.ColorG = Color.DimGray;
            cmbFlightCrew.ColorH = Color.FromArgb(224, 222, 220);
            cmbFlightCrew.ColorI = Color.FromArgb(250, 249, 249);
            cmbFlightCrew.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFlightCrew.DropDownHeight = 100;
            cmbFlightCrew.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFlightCrew.Font = new Font("Segoe UI", 10F);
            cmbFlightCrew.ForeColor = SystemColors.ActiveCaptionText;
            cmbFlightCrew.FormattingEnabled = true;
            cmbFlightCrew.HoverSelectionColor = Color.Empty;
            cmbFlightCrew.IntegralHeight = false;
            cmbFlightCrew.ItemHeight = 20;
            cmbFlightCrew.Items.AddRange(new object[] { "Captain", "First Officer", "Second Officer" });
            cmbFlightCrew.Location = new Point(152, 381);
            cmbFlightCrew.Name = "cmbFlightCrew";
            cmbFlightCrew.Size = new Size(246, 26);
            cmbFlightCrew.StartIndex = 0;
            cmbFlightCrew.TabIndex = 38;
            // 
            // cmbCabinCrew
            // 
            cmbCabinCrew.BackColor = SystemColors.ActiveCaption;
            cmbCabinCrew.ColorA = SystemColors.ActiveCaption;
            cmbCabinCrew.ColorB = SystemColors.GradientActiveCaption;
            cmbCabinCrew.ColorC = Color.FromArgb(242, 241, 240);
            cmbCabinCrew.ColorD = Color.FromArgb(253, 252, 252);
            cmbCabinCrew.ColorE = Color.FromArgb(239, 237, 236);
            cmbCabinCrew.ColorF = Color.FromArgb(64, 64, 64);
            cmbCabinCrew.ColorG = Color.DimGray;
            cmbCabinCrew.ColorH = Color.FromArgb(224, 222, 220);
            cmbCabinCrew.ColorI = Color.FromArgb(250, 249, 249);
            cmbCabinCrew.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCabinCrew.DropDownHeight = 100;
            cmbCabinCrew.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCabinCrew.Font = new Font("Segoe UI", 10F);
            cmbCabinCrew.ForeColor = SystemColors.ActiveCaptionText;
            cmbCabinCrew.FormattingEnabled = true;
            cmbCabinCrew.HoverSelectionColor = Color.Empty;
            cmbCabinCrew.IntegralHeight = false;
            cmbCabinCrew.ItemHeight = 20;
            cmbCabinCrew.Items.AddRange(new object[] { "Flight Attendant", "Lead Flight Attendant" });
            cmbCabinCrew.Location = new Point(152, 436);
            cmbCabinCrew.Name = "cmbCabinCrew";
            cmbCabinCrew.Size = new Size(246, 26);
            cmbCabinCrew.StartIndex = 0;
            cmbCabinCrew.TabIndex = 39;
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
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnSubmit.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnSubmit.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnSubmit.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnSubmit.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnSubmit.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnSubmit.HoverForeColor = Color.White;
            btnSubmit.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSubmit.Location = new Point(152, 468);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnSubmit.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnSubmit.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnSubmit.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnSubmit.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnSubmit.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnSubmit.NormalForeColor = Color.Black;
            btnSubmit.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmit.TabIndex = 40;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 381);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 41;
            label2.Text = "Crew Position:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(106, 225);
            label7.Name = "label7";
            label7.Size = new Size(206, 27);
            label7.TabIndex = 42;
            label7.Text = "CREW MEMBERS";
            // 
            // dgvCrewMembers
            // 
            dgvCrewMembers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCrewMembers.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvCrewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCrewMembers.Location = new Point(404, 28);
            dgvCrewMembers.Name = "dgvCrewMembers";
            dgvCrewMembers.RowHeadersWidth = 51;
            dgvCrewMembers.Size = new Size(483, 532);
            dgvCrewMembers.TabIndex = 43;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 462);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 45;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackToForm1
            // 
            btnBackToForm1.Location = new Point(12, 497);
            btnBackToForm1.Name = "btnBackToForm1";
            btnBackToForm1.Size = new Size(94, 29);
            btnBackToForm1.TabIndex = 44;
            btnBackToForm1.Text = "Back";
            btnBackToForm1.UseVisualStyleBackColor = true;
            btnBackToForm1.Click += btnBackToForm1_Click;
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
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnDelete.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnDelete.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnDelete.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnDelete.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnDelete.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnDelete.HoverForeColor = Color.White;
            btnDelete.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnDelete.Location = new Point(252, 468);
            btnDelete.Name = "btnDelete";
            btnDelete.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnDelete.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnDelete.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnDelete.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnDelete.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnDelete.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnDelete.NormalForeColor = Color.Black;
            btnDelete.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnDelete.Size = new Size(94, 29);
            btnDelete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // AddMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ui__3_;
            ClientSize = new Size(887, 561);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnBackToForm1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(cmbCabinCrew);
            Controls.Add(cmbFlightCrew);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(cmbCrewType);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(dgvCrewMembers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCrewMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private TextBox txtname;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCrewType;
        private Label label1;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonComboBox cmbFlightCrew;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCabinCrew;
        private ReaLTaiizor.Controls.SkyButton btnSubmit;
        private Label label2;
        private Label label7;
        private DataGridView dgvCrewMembers;
        private Button btnClear;
        private Button btnBackToForm1;
        private ReaLTaiizor.Controls.SkyButton btnDelete;
    }
}