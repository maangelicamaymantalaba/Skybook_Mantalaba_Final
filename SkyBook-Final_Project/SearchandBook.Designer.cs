namespace SkyBook_Final_Project
{
    partial class SearchandBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchandBook));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            label4 = new Label();
            label2 = new Label();
            cmbDestination = new ReaLTaiizor.Controls.DungeonComboBox();
            btnPrintReceipt = new ReaLTaiizor.Controls.SkyButton();
            btnSubmit = new ReaLTaiizor.Controls.SkyButton();
            dgvFlights = new DataGridView();
            label1 = new Label();
            btnClear = new Button();
            btnBackToForm1 = new Button();
            txtname = new TextBox();
            lblPrice = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            chartFlights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvReservation = new DataGridView();
            label8 = new Label();
            cmbClass = new ReaLTaiizor.Controls.DungeonComboBox();
            label3 = new Label();
            cmbAirlines = new ReaLTaiizor.Controls.DungeonComboBox();
            btnCheckSeat = new ReaLTaiizor.Controls.SkyButton();
            txtSeatNumber = new TextBox();
            label9 = new Label();
            label6 = new Label();
            cmbPointA = new ReaLTaiizor.Controls.DungeonComboBox();
            label7 = new Label();
            cmbPointB = new ReaLTaiizor.Controls.DungeonComboBox();
            label10 = new Label();
            txtFlightNo = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFlights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
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
            panel1.Size = new Size(1268, 32);
            panel1.TabIndex = 18;
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
            nightControlBox1.Location = new Point(1129, 0);
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
            skyLabel1.Size = new Size(193, 18);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "Search and Book a Flight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(328, 44);
            label4.Name = "label4";
            label4.Size = new Size(72, 26);
            label4.TabIndex = 19;
            label4.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 112);
            label2.Name = "label2";
            label2.Size = new Size(176, 26);
            label2.TabIndex = 21;
            label2.Text = "Enter destination:";
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
            cmbDestination.Location = new Point(413, 112);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Size = new Size(387, 26);
            cmbDestination.StartIndex = 0;
            cmbDestination.TabIndex = 25;
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
            btnPrintReceipt.Location = new Point(643, 285);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnPrintReceipt.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnPrintReceipt.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnPrintReceipt.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnPrintReceipt.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnPrintReceipt.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnPrintReceipt.NormalForeColor = Color.Black;
            btnPrintReceipt.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnPrintReceipt.Size = new Size(124, 29);
            btnPrintReceipt.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnPrintReceipt.TabIndex = 35;
            btnPrintReceipt.Text = "Print receipt";
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
            btnSubmit.Location = new Point(543, 285);
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
            btnSubmit.TabIndex = 36;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dgvFlights
            // 
            dgvFlights.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFlights.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlights.Location = new Point(0, 344);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.RowHeadersWidth = 51;
            dgvFlights.Size = new Size(758, 459);
            dgvFlights.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(0, 315);
            label1.Name = "label1";
            label1.Size = new Size(246, 26);
            label1.TabIndex = 38;
            label1.Text = "List of Available Flights";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1062, 301);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackToForm1
            // 
            btnBackToForm1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBackToForm1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackToForm1.Location = new Point(1162, 301);
            btnBackToForm1.Name = "btnBackToForm1";
            btnBackToForm1.Size = new Size(94, 29);
            btnBackToForm1.TabIndex = 43;
            btnBackToForm1.Text = "Back";
            btnBackToForm1.UseVisualStyleBackColor = true;
            btnBackToForm1.Click += btnBackToForm1_Click;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(413, 40);
            txtname.Name = "txtname";
            txtname.Size = new Size(387, 30);
            txtname.TabIndex = 22;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Location = new Point(622, 259);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(83, 20);
            lblPrice.TabIndex = 46;
            lblPrice.Text = "Price: $0.00";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(9, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 156);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(324, 183);
            label5.Name = "label5";
            label5.Size = new Size(76, 26);
            label5.TabIndex = 49;
            label5.Text = "Airline:";
            // 
            // chartFlights
            // 
            chartFlights.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFlights.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFlights.Legends.Add(legend1);
            chartFlights.Location = new Point(806, 40);
            chartFlights.Name = "chartFlights";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFlights.Series.Add(series1);
            chartFlights.Size = new Size(450, 255);
            chartFlights.TabIndex = 63;
            chartFlights.Text = "chart1";
            // 
            // dgvReservation
            // 
            dgvReservation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvReservation.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservation.Location = new Point(764, 345);
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RowHeadersWidth = 51;
            dgvReservation.Size = new Size(504, 458);
            dgvReservation.TabIndex = 64;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(764, 317);
            label8.Name = "label8";
            label8.Size = new Size(195, 27);
            label8.TabIndex = 65;
            label8.Text = "RESERVATIONS";
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
            cmbClass.Location = new Point(413, 211);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(387, 26);
            cmbClass.StartIndex = 0;
            cmbClass.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 212);
            label3.Name = "label3";
            label3.Size = new Size(172, 26);
            label3.TabIndex = 73;
            label3.Text = "Select seat class:";
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
            cmbAirlines.Location = new Point(413, 179);
            cmbAirlines.Name = "cmbAirlines";
            cmbAirlines.Size = new Size(387, 26);
            cmbAirlines.StartIndex = 0;
            cmbAirlines.TabIndex = 74;
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
            btnCheckSeat.Location = new Point(543, 247);
            btnCheckSeat.Name = "btnCheckSeat";
            btnCheckSeat.NormalBGColorA = Color.FromArgb(245, 245, 245);
            btnCheckSeat.NormalBGColorB = Color.FromArgb(230, 230, 230);
            btnCheckSeat.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            btnCheckSeat.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            btnCheckSeat.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            btnCheckSeat.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            btnCheckSeat.NormalForeColor = Color.FromArgb(27, 94, 137);
            btnCheckSeat.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            btnCheckSeat.Size = new Size(73, 32);
            btnCheckSeat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCheckSeat.TabIndex = 75;
            btnCheckSeat.Text = "CHECK SEAT";
            btnCheckSeat.Click += btnCheckSeat_Click;
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSeatNumber.Location = new Point(413, 249);
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Size = new Size(124, 30);
            txtSeatNumber.TabIndex = 76;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(260, 253);
            label9.Name = "label9";
            label9.Size = new Size(140, 26);
            label9.TabIndex = 77;
            label9.Text = "Seat Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(200, 77);
            label6.Name = "label6";
            label6.Size = new Size(200, 26);
            label6.TabIndex = 78;
            label6.Text = "Departure (Point A):";
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
            cmbPointA.Location = new Point(413, 76);
            cmbPointA.Name = "cmbPointA";
            cmbPointA.Size = new Size(387, 26);
            cmbPointA.StartIndex = 0;
            cmbPointA.TabIndex = 79;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(186, 148);
            label7.Name = "label7";
            label7.Size = new Size(214, 26);
            label7.TabIndex = 80;
            label7.Text = "Destination (Point B):";
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
            cmbPointB.Location = new Point(413, 147);
            cmbPointB.Name = "cmbPointB";
            cmbPointB.Size = new Size(387, 26);
            cmbPointB.StartIndex = 0;
            cmbPointB.TabIndex = 81;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(260, 289);
            label10.Name = "label10";
            label10.Size = new Size(150, 26);
            label10.TabIndex = 82;
            label10.Text = "Flight Number:";
            // 
            // txtFlightNo
            // 
            txtFlightNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFlightNo.Location = new Point(413, 285);
            txtFlightNo.Name = "txtFlightNo";
            txtFlightNo.Size = new Size(124, 30);
            txtFlightNo.TabIndex = 83;
            // 
            // SearchandBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1268, 815);
            Controls.Add(txtFlightNo);
            Controls.Add(label10);
            Controls.Add(cmbPointB);
            Controls.Add(label7);
            Controls.Add(cmbPointA);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(txtSeatNumber);
            Controls.Add(btnCheckSeat);
            Controls.Add(cmbAirlines);
            Controls.Add(label3);
            Controls.Add(cmbClass);
            Controls.Add(label8);
            Controls.Add(dgvReservation);
            Controls.Add(chartFlights);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(lblPrice);
            Controls.Add(btnClear);
            Controls.Add(btnBackToForm1);
            Controls.Add(label1);
            Controls.Add(dgvFlights);
            Controls.Add(btnSubmit);
            Controls.Add(btnPrintReceipt);
            Controls.Add(cmbDestination);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchandBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFlights).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Label label4;
        private Label label2;
        private ReaLTaiizor.Controls.DungeonComboBox cmbDestination;
        private ReaLTaiizor.Controls.SkyButton btnPrintReceipt;
        private ReaLTaiizor.Controls.SkyButton btnSubmit;
        private DataGridView dgvFlights;
        private Label label1;
        private Button btnClear;
        private Button btnBackToForm1;
        private TextBox txtname;
        private Label lblPrice;
        private PictureBox pictureBox2;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlights;
        private DataGridView dgvReservation;
        private Label label8;
        private ReaLTaiizor.Controls.DungeonComboBox cmbClass;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonComboBox cmbAirlines;
        private ReaLTaiizor.Controls.SkyButton btnCheckSeat;
        private TextBox txtSeatNumber;
        private Label label9;
        private Label label6;
        private ReaLTaiizor.Controls.DungeonComboBox cmbPointA;
        private Label label7;
        private ReaLTaiizor.Controls.DungeonComboBox cmbPointB;
        private Label label10;
        private TextBox txtFlightNo;
    }
}