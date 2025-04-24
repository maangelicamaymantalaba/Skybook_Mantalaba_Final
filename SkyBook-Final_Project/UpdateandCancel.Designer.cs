namespace SkyBook_Final_Project
{
    partial class UpdateandCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateandCancel));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtname = new TextBox();
            cmbDestination = new ReaLTaiizor.Controls.DungeonComboBox();
            cmbClass = new ReaLTaiizor.Controls.DungeonComboBox();
            label7 = new Label();
            dgvReservation = new DataGridView();
            btnPrintReceipt = new ReaLTaiizor.Controls.SkyButton();
            btnSubmit = new ReaLTaiizor.Controls.SkyButton();
            label6 = new Label();
            dgvFlights = new DataGridView();
            btnClear = new Button();
            btnBackToForm1 = new Button();
            lblPrice = new Label();
            pictureBox2 = new PictureBox();
            btnCancel = new Button();
            label8 = new Label();
            label9 = new Label();
            txtSeatNumber = new TextBox();
            btnCheckSeat = new ReaLTaiizor.Controls.SkyButton();
            cmbAirlines = new ReaLTaiizor.Controls.DungeonComboBox();
            chartFlights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            cmbPointA = new ReaLTaiizor.Controls.DungeonComboBox();
            label10 = new Label();
            cmbPointB = new ReaLTaiizor.Controls.DungeonComboBox();
            txtFlightNo = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFlights).BeginInit();
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
            panel1.Size = new Size(1401, 32);
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
            nightControlBox1.Location = new Point(1262, 0);
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
            skyLabel1.Size = new Size(364, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "Manage Reservations – View, Update, or Cancel\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(176, 35);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 21;
            label2.Text = "UPDATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 61);
            label4.Name = "label4";
            label4.Size = new Size(240, 26);
            label4.TabIndex = 22;
            label4.Text = "Name of the reservation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(230, 125);
            label3.Name = "label3";
            label3.Size = new Size(176, 26);
            label3.TabIndex = 23;
            label3.Text = "Enter destination:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(234, 221);
            label5.Name = "label5";
            label5.Size = new Size(172, 26);
            label5.TabIndex = 24;
            label5.Text = "Select seat class:";
            // 
            // txtname
            // 
            txtname.Location = new Point(412, 59);
            txtname.Name = "txtname";
            txtname.Size = new Size(313, 27);
            txtname.TabIndex = 25;
            // 
            // cmbDestination
            // 
            cmbDestination.BackColor = SystemColors.ActiveCaption;
            cmbDestination.ColorA = SystemColors.ActiveCaption;
            cmbDestination.ColorB = SystemColors.GradientActiveCaption;
            cmbDestination.ColorC = Color.FromArgb(242, 241, 240);
            cmbDestination.ColorD = Color.FromArgb(253, 252, 252);
            cmbDestination.ColorE = Color.FromArgb(239, 237, 236);
            cmbDestination.ColorF = Color.FromArgb(180, 180, 180);
            cmbDestination.ColorG = Color.FromArgb(119, 119, 118);
            cmbDestination.ColorH = Color.FromArgb(224, 222, 220);
            cmbDestination.ColorI = Color.FromArgb(250, 249, 249);
            cmbDestination.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDestination.DropDownHeight = 100;
            cmbDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestination.Font = new Font("Segoe UI", 10F);
            cmbDestination.ForeColor = SystemColors.ActiveCaptionText;
            cmbDestination.FormattingEnabled = true;
            cmbDestination.HoverSelectionColor = Color.Empty;
            cmbDestination.IntegralHeight = false;
            cmbDestination.ItemHeight = 20;
            cmbDestination.Location = new Point(412, 124);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Size = new Size(313, 26);
            cmbDestination.StartIndex = 0;
            cmbDestination.TabIndex = 26;
            // 
            // cmbClass
            // 
            cmbClass.BackColor = SystemColors.ActiveCaption;
            cmbClass.ColorA = SystemColors.ActiveCaption;
            cmbClass.ColorB = SystemColors.GradientActiveCaption;
            cmbClass.ColorC = Color.FromArgb(242, 241, 240);
            cmbClass.ColorD = Color.FromArgb(253, 252, 252);
            cmbClass.ColorE = Color.FromArgb(239, 237, 236);
            cmbClass.ColorF = Color.FromArgb(64, 64, 64);
            cmbClass.ColorG = Color.DimGray;
            cmbClass.ColorH = Color.FromArgb(224, 222, 220);
            cmbClass.ColorI = Color.FromArgb(250, 249, 249);
            cmbClass.DrawMode = DrawMode.OwnerDrawFixed;
            cmbClass.DropDownHeight = 100;
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.Font = new Font("Segoe UI", 10F);
            cmbClass.ForeColor = SystemColors.ActiveCaptionText;
            cmbClass.FormattingEnabled = true;
            cmbClass.HoverSelectionColor = Color.Empty;
            cmbClass.IntegralHeight = false;
            cmbClass.ItemHeight = 20;
            cmbClass.Location = new Point(412, 220);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(313, 26);
            cmbClass.StartIndex = 0;
            cmbClass.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(0, 349);
            label7.Name = "label7";
            label7.Size = new Size(195, 27);
            label7.TabIndex = 28;
            label7.Text = "RESERVATIONS";
            // 
            // dgvReservation
            // 
            dgvReservation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvReservation.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservation.Location = new Point(0, 385);
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RowHeadersWidth = 51;
            dgvReservation.Size = new Size(752, 368);
            dgvReservation.TabIndex = 29;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.Transparent;
            btnPrintReceipt.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnPrintReceipt.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnPrintReceipt.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnPrintReceipt.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnPrintReceipt.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnPrintReceipt.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnPrintReceipt.DownForeColor = Color.White;
            btnPrintReceipt.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnPrintReceipt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReceipt.ForeColor = Color.Black;
            btnPrintReceipt.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnPrintReceipt.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnPrintReceipt.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnPrintReceipt.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnPrintReceipt.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnPrintReceipt.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnPrintReceipt.HoverForeColor = Color.White;
            btnPrintReceipt.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnPrintReceipt.Location = new Point(643, 288);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnPrintReceipt.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnPrintReceipt.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnPrintReceipt.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnPrintReceipt.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnPrintReceipt.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnPrintReceipt.NormalForeColor = Color.Black;
            btnPrintReceipt.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnPrintReceipt.Size = new Size(109, 29);
            btnPrintReceipt.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnPrintReceipt.TabIndex = 36;
            btnPrintReceipt.Text = "Print reciept";
            btnPrintReceipt.Click += btnPrintReceipt_Click;
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
            btnSubmit.Location = new Point(542, 288);
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
            btnSubmit.TabIndex = 37;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(758, 442);
            label6.Name = "label6";
            label6.Size = new Size(215, 23);
            label6.TabIndex = 40;
            label6.Text = "AVAILABLE FLIGHTS";
            // 
            // dgvFlights
            // 
            dgvFlights.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFlights.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlights.Location = new Point(758, 468);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.RowHeadersWidth = 51;
            dgvFlights.Size = new Size(636, 285);
            dgvFlights.TabIndex = 41;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(512, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 43;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackToForm1
            // 
            btnBackToForm1.Location = new Point(616, 351);
            btnBackToForm1.Name = "btnBackToForm1";
            btnBackToForm1.Size = new Size(94, 29);
            btnBackToForm1.TabIndex = 42;
            btnBackToForm1.Text = "Back";
            btnBackToForm1.UseVisualStyleBackColor = true;
            btnBackToForm1.Click += btnBackToForm1_Click;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.FlatStyle = FlatStyle.Popup;
            lblPrice.Location = new Point(627, 256);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(83, 20);
            lblPrice.TabIndex = 47;
            lblPrice.Text = "Price: $0.00";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(169, 161);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(412, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 48;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(326, 188);
            label8.Name = "label8";
            label8.Size = new Size(76, 26);
            label8.TabIndex = 54;
            label8.Text = "Airline:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(266, 256);
            label9.Name = "label9";
            label9.Size = new Size(140, 26);
            label9.TabIndex = 55;
            label9.Text = "Seat Number:";
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSeatNumber.Location = new Point(412, 252);
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Size = new Size(124, 30);
            txtSeatNumber.TabIndex = 57;
            txtSeatNumber.TextChanged += txtSeatNumber_TextChanged;
            // 
            // btnCheckSeat
            // 
            btnCheckSeat.BackColor = Color.Transparent;
            btnCheckSeat.DownBGColorA = Color.FromArgb(70, 153, 205);
            btnCheckSeat.DownBGColorB = Color.FromArgb(53, 124, 170);
            btnCheckSeat.DownBorderColorA = Color.FromArgb(88, 168, 221);
            btnCheckSeat.DownBorderColorB = Color.FromArgb(76, 149, 194);
            btnCheckSeat.DownBorderColorC = Color.FromArgb(38, 93, 131);
            btnCheckSeat.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnCheckSeat.DownForeColor = Color.White;
            btnCheckSeat.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnCheckSeat.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            btnCheckSeat.ForeColor = Color.FromArgb(27, 94, 137);
            btnCheckSeat.HoverBGColorA = Color.FromArgb(70, 153, 205);
            btnCheckSeat.HoverBGColorB = Color.FromArgb(53, 124, 170);
            btnCheckSeat.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            btnCheckSeat.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            btnCheckSeat.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            btnCheckSeat.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            btnCheckSeat.HoverForeColor = Color.White;
            btnCheckSeat.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnCheckSeat.Location = new Point(542, 252);
            btnCheckSeat.Name = "btnCheckSeat";
            btnCheckSeat.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnCheckSeat.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnCheckSeat.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnCheckSeat.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnCheckSeat.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnCheckSeat.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnCheckSeat.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnCheckSeat.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnCheckSeat.Size = new Size(70, 32);
            btnCheckSeat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCheckSeat.TabIndex = 58;
            btnCheckSeat.Text = "CHECK SEAT";
            btnCheckSeat.Click += btnCheckSeat_Click;
            // 
            // cmbAirlines
            // 
            cmbAirlines.BackColor = SystemColors.ActiveCaption;
            cmbAirlines.ColorA = SystemColors.ActiveCaption;
            cmbAirlines.ColorB = SystemColors.GradientActiveCaption;
            cmbAirlines.ColorC = Color.FromArgb(242, 241, 240);
            cmbAirlines.ColorD = Color.FromArgb(253, 252, 252);
            cmbAirlines.ColorE = Color.FromArgb(239, 237, 236);
            cmbAirlines.ColorF = Color.FromArgb(180, 180, 180);
            cmbAirlines.ColorG = Color.FromArgb(119, 119, 118);
            cmbAirlines.ColorH = Color.FromArgb(224, 222, 220);
            cmbAirlines.ColorI = Color.FromArgb(250, 249, 249);
            cmbAirlines.DrawMode = DrawMode.OwnerDrawFixed;
            cmbAirlines.DropDownHeight = 100;
            cmbAirlines.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAirlines.Font = new Font("Segoe UI", 10F);
            cmbAirlines.ForeColor = SystemColors.ActiveCaptionText;
            cmbAirlines.FormattingEnabled = true;
            cmbAirlines.HoverSelectionColor = Color.Empty;
            cmbAirlines.IntegralHeight = false;
            cmbAirlines.ItemHeight = 20;
            cmbAirlines.Location = new Point(412, 188);
            cmbAirlines.Name = "cmbAirlines";
            cmbAirlines.Size = new Size(313, 26);
            cmbAirlines.StartIndex = 0;
            cmbAirlines.TabIndex = 60;
            // 
            // chartFlights
            // 
            chartFlights.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFlights.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFlights.Legends.Add(legend1);
            chartFlights.Location = new Point(758, 61);
            chartFlights.Name = "chartFlights";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFlights.Series.Add(series1);
            chartFlights.Size = new Size(631, 378);
            chartFlights.TabIndex = 62;
            chartFlights.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 92);
            label1.Name = "label1";
            label1.Size = new Size(200, 26);
            label1.TabIndex = 79;
            label1.Text = "Departure (Point A):";
            // 
            // cmbPointA
            // 
            cmbPointA.BackColor = SystemColors.ActiveCaption;
            cmbPointA.ColorA = SystemColors.ActiveCaption;
            cmbPointA.ColorB = SystemColors.GradientActiveCaption;
            cmbPointA.ColorC = Color.FromArgb(242, 241, 240);
            cmbPointA.ColorD = Color.FromArgb(253, 252, 252);
            cmbPointA.ColorE = Color.FromArgb(239, 237, 236);
            cmbPointA.ColorF = Color.FromArgb(180, 180, 180);
            cmbPointA.ColorG = Color.FromArgb(119, 119, 118);
            cmbPointA.ColorH = Color.FromArgb(224, 222, 220);
            cmbPointA.ColorI = Color.FromArgb(250, 249, 249);
            cmbPointA.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPointA.DropDownHeight = 100;
            cmbPointA.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPointA.Font = new Font("Segoe UI", 10F);
            cmbPointA.ForeColor = SystemColors.ActiveCaptionText;
            cmbPointA.FormattingEnabled = true;
            cmbPointA.HoverSelectionColor = Color.Empty;
            cmbPointA.IntegralHeight = false;
            cmbPointA.ItemHeight = 20;
            cmbPointA.Location = new Point(412, 92);
            cmbPointA.Name = "cmbPointA";
            cmbPointA.Size = new Size(313, 26);
            cmbPointA.StartIndex = 0;
            cmbPointA.TabIndex = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(192, 157);
            label10.Name = "label10";
            label10.Size = new Size(214, 26);
            label10.TabIndex = 81;
            label10.Text = "Destination (Point B):";
            // 
            // cmbPointB
            // 
            cmbPointB.BackColor = SystemColors.ActiveCaption;
            cmbPointB.ColorA = SystemColors.ActiveCaption;
            cmbPointB.ColorB = SystemColors.GradientActiveCaption;
            cmbPointB.ColorC = Color.FromArgb(242, 241, 240);
            cmbPointB.ColorD = Color.FromArgb(253, 252, 252);
            cmbPointB.ColorE = Color.FromArgb(239, 237, 236);
            cmbPointB.ColorF = Color.FromArgb(180, 180, 180);
            cmbPointB.ColorG = Color.FromArgb(119, 119, 118);
            cmbPointB.ColorH = Color.FromArgb(224, 222, 220);
            cmbPointB.ColorI = Color.FromArgb(250, 249, 249);
            cmbPointB.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPointB.DropDownHeight = 100;
            cmbPointB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPointB.Font = new Font("Segoe UI", 10F);
            cmbPointB.ForeColor = SystemColors.ActiveCaptionText;
            cmbPointB.FormattingEnabled = true;
            cmbPointB.HoverSelectionColor = Color.Empty;
            cmbPointB.IntegralHeight = false;
            cmbPointB.ItemHeight = 20;
            cmbPointB.Location = new Point(412, 156);
            cmbPointB.Name = "cmbPointB";
            cmbPointB.Size = new Size(313, 26);
            cmbPointB.StartIndex = 0;
            cmbPointB.TabIndex = 82;
            // 
            // txtFlightNo
            // 
            txtFlightNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFlightNo.Location = new Point(412, 288);
            txtFlightNo.Name = "txtFlightNo";
            txtFlightNo.Size = new Size(124, 30);
            txtFlightNo.TabIndex = 84;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(256, 288);
            label11.Name = "label11";
            label11.Size = new Size(150, 26);
            label11.TabIndex = 85;
            label11.Text = "Flight Number:";
            // 
            // UpdateandCancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1401, 755);
            Controls.Add(label11);
            Controls.Add(txtFlightNo);
            Controls.Add(cmbPointB);
            Controls.Add(label10);
            Controls.Add(cmbPointA);
            Controls.Add(label1);
            Controls.Add(chartFlights);
            Controls.Add(cmbAirlines);
            Controls.Add(btnCheckSeat);
            Controls.Add(txtSeatNumber);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnCancel);
            Controls.Add(lblPrice);
            Controls.Add(btnClear);
            Controls.Add(btnBackToForm1);
            Controls.Add(dgvFlights);
            Controls.Add(label6);
            Controls.Add(btnSubmit);
            Controls.Add(btnPrintReceipt);
            Controls.Add(dgvReservation);
            Controls.Add(label7);
            Controls.Add(cmbClass);
            Controls.Add(cmbDestination);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateandCancel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFlights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtname;
        private ReaLTaiizor.Controls.DungeonComboBox cmbDestination;
        private ReaLTaiizor.Controls.DungeonComboBox cmbClass;
        private Label label7;
        private DataGridView dgvReservation;
        private ReaLTaiizor.Controls.SkyButton btnPrintReceipt;
        private ReaLTaiizor.Controls.SkyButton btnSubmit;
        private Label label6;
        private DataGridView dgvFlights;
        private Button btnClear;
        private Button btnBackToForm1;
        private Label lblPrice;
        private PictureBox pictureBox2;
        private Button btnCancel;
        private Label label8;
        private Label label9;
        private TextBox txtSeatNumber;
        private ReaLTaiizor.Controls.SkyButton btnCheckSeat;
        private ReaLTaiizor.Controls.DungeonComboBox cmbAirlines;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlights;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonComboBox cmbPointA;
        private Label label10;
        private ReaLTaiizor.Controls.DungeonComboBox cmbPointB;
        private TextBox txtFlightNo;
        private Label label11;
    }
}