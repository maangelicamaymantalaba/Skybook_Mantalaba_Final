using System.Data;
using System.Data.OleDb;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;

namespace SkyBook_Final_Project
{
    public partial class SearchandBook : Form
    {
        public string PassengerName { get; set; }
        public string TravelClass { get; set; }
        public string Destination { get; set; }
        public string AirlineName { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal TotalPrice { get; set; }
        public string SeatNumber { get; set; }
        public string PointA { get; set; }
        public string PointB { get; set; }
        public string FlightNo { get; set; }

        private Dictionary<string, Dictionary<string, (int min, int max)>> airlineSeatRanges;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb;";

        private DateTime currentDepartureTime;
        private System.Timers.Timer departureTimer;
        public SearchandBook()
        {
            InitializeComponent();
            InitializeFormComponents();
            InitializeDepartureTimer();
        }

        private void InitializeFormComponents()
        {
            cmbClass.Items.AddRange(new[] { "Economy", "Business", "First Class" });
            cmbDestination.Items.AddRange(new[] { "South Korea", "Japan", "United States", "Germany", "Canada",
                                                "United Kingdom", "France", "Australia", "Italy", "Singapore" });
            cmbAirlines.Items.AddRange(new[] { "Cebu Pacific Air", "AirAsia Philippines", "PAL Express" });
            cmbPointA.Items.AddRange(new[] { "Mactan-Cebu International Airport (MCIA)", "Ninoy Aquino International Airport (NAIA)" });

            cmbClass.SelectedIndexChanged += UpdatePrice;
            cmbDestination.SelectedIndexChanged += UpdatePrice;
            cmbDestination.SelectedIndexChanged += cmbDestination_SelectedIndexChanged;
            // btnSubmit.Click += btnSubmit_Click;
            //btnPrintReceipt.Click += btnPrintReceipt_Click;
            btnClear.Click += btnClear_Click;
            btnBackToForm1.Click += btnBackToForm1_Click;
            dgvFlights.SelectionChanged += DgvFlights_SelectionChanged;
            dgvFlights.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configure dgvFlights
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFlights.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFlights.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Enable text wrapping

            // Configure dgvReservation
            dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReservation.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Enable text wrapping

            lblPrice.Text = "Price: $0.00";

            InitializeSeatRanges();
            LoadFlightData();
            LoadReservationData();
            InitializeFlightChart();
        }
        private void InitializeDepartureTimer()
        {
            currentDepartureTime = DateTime.Now.AddMinutes(30 - DateTime.Now.Minute % 30);

            departureTimer = new System.Timers.Timer(30 * 60 * 1000);
            departureTimer.Elapsed += UpdateDepartureTimeAndRefresh;
            departureTimer.AutoReset = true;
            departureTimer.Enabled = true;
        }

        private void UpdateDepartureTimeAndRefresh(object sender, ElapsedEventArgs e)
        {
            currentDepartureTime = DateTime.Now.AddMinutes(30 - DateTime.Now.Minute % 30);

            RefreshSeatPlan();
        }

        private void RefreshSeatPlan()
        {
            Invoke(new Action(() =>
            {

                dgvFlights.DataSource = null;
                LoadFlightData();

                MessageBox.Show("Departure time updated. Seat plan refreshed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePointBAirports();
            UpdatePrice(sender, e);
            FilterFlightsByDestination();
        }
        private void UpdatePointBAirports()
        {
            cmbPointB.Items.Clear();

            if (cmbDestination.SelectedItem == null)
                return;

            string selectedDestination = cmbDestination.SelectedItem.ToString();

            switch (selectedDestination)
            {
                case "South Korea":
                    cmbPointB.Items.AddRange(new[] { "Incheon International Airport (ICN)", "Gimpo International Airport (GMP)" });
                    break;
                case "Japan":
                    cmbPointB.Items.AddRange(new[] { "Narita International Airport (NRT)", "Haneda Airport (HND)" });
                    break;
                case "United States":
                    cmbPointB.Items.AddRange(new[] { "Los Angeles International Airport (LAX)", "John F. Kennedy International Airport (JFK)" });
                    break;
                case "Germany":
                    cmbPointB.Items.AddRange(new[] { "Frankfurt Airport (FRA)", "Munich Airport (MUC)" });
                    break;
                case "Canada":
                    cmbPointB.Items.AddRange(new[] { "Toronto Pearson International Airport (YYZ)", "Vancouver International Airport (YVR)" });
                    break;
                case "United Kingdom":
                    cmbPointB.Items.AddRange(new[] { "Heathrow Airport (LHR)", "Gatwick Airport (LGW)" });
                    break;
                case "France":
                    cmbPointB.Items.AddRange(new[] { "Charles de Gaulle Airport (CDG)", "Orly Airport (ORY)" });
                    break;
                case "Australia":
                    cmbPointB.Items.AddRange(new[] { "Sydney Kingsford Smith Airport (SYD)", "Melbourne Airport (MEL)" });
                    break;
                case "Italy":
                    cmbPointB.Items.AddRange(new[] { "Fiumicino Airport (FCO)", "Malpensa Airport (MXP)" });
                    break;
                case "Singapore":
                    cmbPointB.Items.Add("Changi Airport (SIN)");
                    break;
            }
        }

        private void FilterFlightsByDestination()
        {
            if (cmbDestination.SelectedItem == null)
            {
                LoadFlightData();
                return;
            }

            string selectedDestination = cmbDestination.SelectedItem.ToString();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT FlightID, AirlineName, Destination 
                           FROM tblFlights
                           WHERE Destination = @Destination";

                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@Destination", selectedDestination);

                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns.Add("DepartureTime", typeof(DateTime));
                    dt.Columns.Add("ArrivalTime", typeof(DateTime));

                    DateTime baseTime = DateTime.Now.AddHours(2);
                    foreach (DataRow row in dt.Rows)
                    {
                        row["DepartureTime"] = baseTime;
                        row["ArrivalTime"] = baseTime.AddHours(GetFlightDuration(selectedDestination));
                        baseTime = baseTime.AddMinutes(30);
                    }

                    dgvFlights.DataSource = dt;
                    dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    if (dgvFlights.Columns.Contains("DepartureTime"))
                        dgvFlights.Columns["DepartureTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

                    if (dgvFlights.Columns.Contains("ArrivalTime"))
                        dgvFlights.Columns["ArrivalTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering flights: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetFlightDuration(string destination)
        {
            var durations = new Dictionary<string, int>
            {
                {"South Korea", 4},
                {"Japan", 4},
                {"United States", 14},
                {"Germany", 12},
                {"Canada", 13},
                {"United Kingdom", 13},
                {"France", 12},
                {"Australia", 8},
                {"Italy", 12},
                {"Singapore", 4}
            };
            return durations.ContainsKey(destination) ? durations[destination] : 4;
        }

        private void InitializeSeatRanges()
        {
            airlineSeatRanges = new Dictionary<string, Dictionary<string, (int min, int max)>>
            {
                {
                    "Cebu Pacific Air", new Dictionary<string, (int min, int max)>
                    {
                        { "Economy", (13, 180) },
                        { "Business", (5, 12) },
                        { "First Class", (1, 4) }
                    }
                },
                {
                    "AirAsia Philippines", new Dictionary<string, (int min, int max)>
                    {
                        { "Economy", (17, 184) },
                        { "Business", (5, 16) },
                        { "First Class", (1, 4) }
                    }
                },
                {
                    "PAL Express", new Dictionary<string, (int min, int max)>
                    {
                        { "Economy", (13, 180) },
                        { "Business", (5, 12) },
                        { "First Class", (1, 4) }
                    }
                }
            };
        }
        private void LoadFlightData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT FlightID, AirlineName, Destination FROM tblFlights";
                    connection.Open();

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns.Add("DepartureTime", typeof(DateTime));
                    dt.Columns.Add("ArrivalTime", typeof(DateTime));

                    DateTime baseTime = currentDepartureTime;
                    foreach (DataRow row in dt.Rows)
                    {
                        row["DepartureTime"] = baseTime;
                        row["ArrivalTime"] = baseTime.AddHours(GetFlightDuration(row["Destination"].ToString()));
                        baseTime = baseTime.AddMinutes(30);
                    }

                    dgvFlights.DataSource = dt;
                    dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvFlights.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Set AutoSize for rows

                    if (dgvFlights.Columns.Contains("DepartureTime"))
                        dgvFlights.Columns["DepartureTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

                    if (dgvFlights.Columns.Contains("ArrivalTime"))
                        dgvFlights.Columns["ArrivalTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flights: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadReservationData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT ID, CostumerName, Airline, CostumerDestination, 
                             SeatClass, SeatNumber, DepartureTime, ArrivalTime, Price, FlightNum 
                             FROM tblReservation";

                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No reservation data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvReservation.DataSource = dt;
                    dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvReservation.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    dgvReservation.DataSource = dt;
                    dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
                    dgvReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; 

                    if (dgvReservation.Columns.Contains("DepartureTime"))
                    {
                        dgvReservation.Columns["DepartureTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                    }
                    if (dgvReservation.Columns.Contains("ArrivalTime"))
                    {
                        dgvReservation.Columns["ArrivalTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                    }
                    if (dgvReservation.Columns.Contains("Price"))
                    {
                        dgvReservation.Columns["Price"].DefaultCellStyle.Format = "C";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InitializeFlightChart()
        {
            try
            {
                chartFlights.Series.Clear();
                chartFlights.Titles.Clear();
                chartFlights.ChartAreas.Clear();
                chartFlights.Legends.Clear();

                ChartArea chartArea = new ChartArea("MainArea")
                {
                    BackColor = Color.WhiteSmoke
                };
                chartFlights.ChartAreas.Add(chartArea);

                Series series = new Series("Bookings")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    LabelForeColor = Color.Black,
                    CustomProperties = "PieLabelStyle=Outside, PieDrawingStyle=SoftEdge",
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Int32,
                    IsVisibleInLegend = true
                };
                chartFlights.Series.Add(series);

                chartFlights.Titles.Add(new Title("Best Selling Fight",
                    Docking.Top,
                    new Font("Arial", 14, FontStyle.Bold),
                    Color.Black));

                Legend legend = new Legend
                {
                    Name = "DestinationsLegend",
                    Docking = Docking.Right,
                    Alignment = StringAlignment.Center,
                    LegendStyle = LegendStyle.Column,
                    Font = new Font("Arial", 9),
                    BorderColor = Color.LightGray
                };
                chartFlights.Legends.Add(legend);

                LoadChartData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing chart: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChartData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT CostumerDestination,  COUNT(*) AS BookingCount FROM tblReservation WHERE CostumerDestination IN ('South Korea', 'Japan', 'United States', 'Germany','Canada', 'United Kingdom', 'France', 'Australia', 'Italy', 'Singapore')GROUP BY CostumerDestination ORDER BY COUNT(*) DESC";

                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    chartFlights.Series["Bookings"].Points.Clear();

                    var allDestinations = new Dictionary<string, int>
                    {
                        {"South Korea", 0},
                        {"Japan", 0},
                        {"United States", 0},
                        {"Germany", 0},
                        {"Canada", 0},
                        {"United Kingdom", 0},
                        {"France", 0},
                        {"Australia", 0},
                        {"Italy", 0},
                        {"Singapore", 0}
                    };

                    while (reader.Read())
                    {
                        string destination = reader["CostumerDestination"].ToString();
                        int count = Convert.ToInt32(reader["BookingCount"]);
                        allDestinations[destination] = count;
                    }

                    foreach (var destination in allDestinations)
                    {
                        if (destination.Value > 0)
                        {
                            DataPoint point = new DataPoint
                            {
                                AxisLabel = destination.Key,
                                Label = $"{destination.Key}: {destination.Value}",
                                LegendText = destination.Key,
                                Color = GetDestinationColor(destination.Key),
                                YValues = new double[] { destination.Value }
                            };
                            chartFlights.Series["Bookings"].Points.Add(point);
                        }
                    }

                    chartFlights.Series["Bookings"]["PieLabelStyle"] = "Outside";
                    chartFlights.Series["Bookings"]["PieLineColor"] = "Black";
                    chartFlights.Series["Bookings"].Label = "#VALX: #VALY (#PERCENT{P0})";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart data: {ex.Message}", "Database Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Color GetDestinationColor(string destination)
        {
            var colorMap = new Dictionary<string, Color>
    {
        {"South Korea", Color.FromArgb(65, 105, 225)}, // Royal Blue
        {"Japan", Color.FromArgb(220, 20, 60)},       // Crimson
        {"United States", Color.FromArgb(0, 128, 0)}, // Green
        {"Germany", Color.FromArgb(128, 0, 0)},       // Maroon
        {"Canada", Color.FromArgb(255, 69, 0)},       // Orange-Red
        {"United Kingdom", Color.FromArgb(75, 0, 130)}, // Indigo
        {"France", Color.FromArgb(0, 0, 139)},        // Dark Blue
        {"Australia", Color.FromArgb(218, 165, 32)},  // Golden Rod
        {"Italy", Color.FromArgb(0, 139, 139)},       // Dark Cyan
        {"Singapore", Color.FromArgb(139, 0, 139)}    // Dark Magenta
    };

            return colorMap.ContainsKey(destination) ? colorMap[destination] : Color.SteelBlue;
        }
        private DateTime? GetSelectedFlightDepartureTime()
        {
            if (dgvFlights.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFlights.SelectedRows[0];
                if (selectedRow.Cells["DepartureTime"].Value != null)
                {
                    return (DateTime)selectedRow.Cells["DepartureTime"].Value;
                }
            }
            return null;
        }
        private void DgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFlights.SelectedRows[0];
                string airline = selectedRow.Cells["AirlineName"].Value?.ToString();
                string destination = selectedRow.Cells["Destination"].Value?.ToString();

                if (!string.IsNullOrEmpty(airline))
                    cmbAirlines.SelectedItem = airline;

                if (!string.IsNullOrEmpty(destination))
                    cmbDestination.SelectedItem = destination;
            }
        }


        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            main form1 = new main();
            form1.Show();
            this.Close();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Save Receipt",
                FileName = "FlightReceipt.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("===== Flight Booking Receipt =====");
                        writer.WriteLine($"Passenger Name: {PassengerName}");
                        writer.WriteLine($"Flight Number: {FlightNo}");
                        writer.WriteLine($"From: {PointA}");
                        writer.WriteLine($"To: {PointB}");
                        writer.WriteLine($"Destination Country: {Destination}");
                        writer.WriteLine($"Airline: {AirlineName}");
                        writer.WriteLine($"Class: {TravelClass}");
                        writer.WriteLine($"Seat Number: {SeatNumber}");
                        writer.WriteLine($"Departure: {DepartureTime:MM/dd/yyyy hh:mm tt}");
                        writer.WriteLine($"Arrival: {ArrivalTime:MM/dd/yyyy hh:mm tt}");
                        writer.WriteLine($"Total Price: ${TotalPrice:F2}");
                        writer.WriteLine("===================================");
                    }

                    MessageBox.Show("Receipt has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PassengerName = txtname.Text;
            TravelClass = cmbClass.SelectedItem?.ToString();
            Destination = cmbDestination.SelectedItem?.ToString();
            AirlineName = cmbAirlines.SelectedItem?.ToString();
            PointA = cmbPointA.SelectedItem?.ToString();
            PointB = cmbPointB.SelectedItem?.ToString();
            FlightNo = txtFlightNo.Text;

            if (string.IsNullOrWhiteSpace(FlightNo))
            {
                MessageBox.Show("Please enter a valid flight number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SeatNumber = txtSeatNumber.Text;
            if (string.IsNullOrWhiteSpace(SeatNumber) || !IsValidSeatNumber(SeatNumber))
            {
                MessageBox.Show("Please enter a valid seat number (e.g., A1, 10F).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var flightTimes = GetSelectedFlightTimes();
            if (!flightTimes.DepartureTime.HasValue || !flightTimes.ArrivalTime.HasValue)
            {
                MessageBox.Show("Please select a flight from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(PassengerName) || string.IsNullOrEmpty(TravelClass) ||
                string.IsNullOrEmpty(Destination) || string.IsNullOrEmpty(AirlineName) ||
                string.IsNullOrEmpty(PointA) || string.IsNullOrEmpty(PointB))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DepartureTime = flightTimes.DepartureTime.Value;
            ArrivalTime = flightTimes.ArrivalTime.Value;
            TotalPrice = CalculatePrice(Destination, TravelClass);

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO tblReservation 
               (CostumerName, Airline, CostumerDestination, SeatClass, DepartureTime, ArrivalTime, Price, PointA, PointB, SeatNumber, FlightNum) 
               VALUES (@Name, @Airline, @Destination, @Class, @DepartureTime, @ArrivalTime, @Price, @PointA, @PointB, @SeatNumber, @FlightNum)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Name", OleDbType.VarChar).Value = PassengerName;
                        cmd.Parameters.Add("@Airline", OleDbType.VarChar).Value = AirlineName;
                        cmd.Parameters.Add("@Destination", OleDbType.VarChar).Value = Destination;
                        cmd.Parameters.Add("@Class", OleDbType.VarChar).Value = TravelClass;
                        cmd.Parameters.Add("@DepartureTime", OleDbType.Date).Value = DepartureTime;
                        cmd.Parameters.Add("@ArrivalTime", OleDbType.Date).Value = ArrivalTime;
                        cmd.Parameters.Add("@Price", OleDbType.Currency).Value = TotalPrice;
                        cmd.Parameters.Add("@PointA", OleDbType.VarChar).Value = PointA;
                        cmd.Parameters.Add("@PointB", OleDbType.VarChar).Value = PointB;
                        cmd.Parameters.Add("@SeatNumber", OleDbType.VarChar).Value = SeatNumber;
                        cmd.Parameters.Add("@FlightNum", OleDbType.VarChar).Value = FlightNo;

                        cmd.ExecuteNonQuery();
                    }
                }

                string confirmationMessage = $"Booking Confirmed!\n\n" +
                                              $"Passenger Name: {PassengerName}\n" +
                                              $"Flight Number: {FlightNo}\n" +
                                              $"Departure Airport: {PointA}\n" +
                                              $"Arrival Airport: {PointB}\n" +
                                              $"Airline: {AirlineName}\n" +
                                              $"Travel Class: {TravelClass}\n" +
                                              $"Destination Country: {Destination}\n" +
                                              $"Departure Time: {DepartureTime:yyyy-MM-dd HH:mm}\n" +
                                              $"Arrival Time: {ArrivalTime:yyyy-MM-dd HH:mm}\n" +
                                              $"Seat Number: {SeatNumber}\n" +
                                              $"Total Price: {TotalPrice:C}\n\n" +
                                              "Thank you for choosing SkyBook!";

                MessageBox.Show(confirmationMessage, "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservationData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving booking: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidSeatNumber(string seatNumber)
        {
            var seatPattern = @"^[A-Z]\d{1,2}[A-F]?$";
            return System.Text.RegularExpressions.Regex.IsMatch(seatNumber, seatPattern);
        }


        private void UpdatePrice(object sender, EventArgs e)
        {
            if (cmbClass.SelectedItem != null && cmbDestination.SelectedItem != null)
            {
                string? selectedClass = cmbClass.SelectedItem.ToString();
                string? selectedDestination = cmbDestination.SelectedItem.ToString();
                decimal price = CalculatePrice(selectedDestination, selectedClass);

                lblPrice.Text = $"Price: {price:C}";
            }
            else
            {
                lblPrice.Text = "Price: $0.00";
            }
        }

        private decimal CalculatePrice(string destination, string travelClass)
        {
            Dictionary<string, Dictionary<string, decimal>> destinationPrices = new Dictionary<string, Dictionary<string, decimal>>
            {
                { "South Korea", new Dictionary<string, decimal> { { "Economy", 500 }, { "Business", 1000 }, { "First Class", 2000 } } },
                { "Japan", new Dictionary<string, decimal> { { "Economy", 600 }, { "Business", 1200 }, { "First Class", 2500 } } },
                { "United States", new Dictionary<string, decimal> { { "Economy", 400 }, { "Business", 800 }, { "First Class", 1500 } } },
                { "Germany", new Dictionary<string, decimal> { { "Economy", 700 }, { "Business", 1400 }, { "First Class", 3000 } } },
                { "Canada", new Dictionary<string, decimal> { { "Economy", 450 }, { "Business", 900 }, { "First Class", 1800 } } },
                { "United Kingdom", new Dictionary<string, decimal> { { "Economy", 800 }, { "Business", 1600 }, { "First Class", 3200 } } },
                { "France", new Dictionary<string, decimal> { { "Economy", 750 }, { "Business", 1500 }, { "First Class", 3000 } } },
                { "Australia", new Dictionary<string, decimal> { { "Economy", 900 }, { "Business", 1800 }, { "First Class", 3600 } } },
                { "Italy", new Dictionary<string, decimal> { { "Economy", 600 }, { "Business", 1200 }, { "First Class", 2400 } } },
                { "Singapore", new Dictionary<string, decimal> { { "Economy", 550 }, { "Business", 1100 }, { "First Class", 2200 } } }
            };

            if (destinationPrices.ContainsKey(destination) && destinationPrices[destination].ContainsKey(travelClass))
            {
                return destinationPrices[destination][travelClass];
            }

            return 0;
        }



        private void comboBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbAirlines.SelectedIndexChanged -= comboBoxAirlines_SelectedIndexChanged;
            cmbDestination.SelectedIndexChanged -= cmbDestination_SelectedIndexChanged;

            txtname.Clear();
            cmbClass.SelectedIndex = -1;
            cmbDestination.SelectedIndex = -1;
            cmbAirlines.SelectedIndex = -1;
            cmbPointA.SelectedIndex = -1;
            cmbPointB.Items.Clear();
            lblPrice.Text = "Price: $0.00";

            LoadFlightData();

            cmbAirlines.SelectedIndexChanged += comboBoxAirlines_SelectedIndexChanged;
            cmbDestination.SelectedIndexChanged += cmbDestination_SelectedIndexChanged;
        }
        private (DateTime? DepartureTime, DateTime? ArrivalTime) GetSelectedFlightTimes()
        {
            if (dgvFlights.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFlights.SelectedRows[0];
                DateTime? departureTime = selectedRow.Cells["DepartureTime"].Value as DateTime?;
                DateTime? arrivalTime = selectedRow.Cells["ArrivalTime"].Value as DateTime?;
                return (departureTime, arrivalTime);
            }
            return (null, null);
        }

        private void btnCheckSeat_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAirlines.SelectedItem == null || cmbClass.SelectedItem == null)
                {
                    MessageBox.Show("Please select an airline and a travel class first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedAirline = cmbAirlines.SelectedItem.ToString();
                string selectedClass = cmbClass.SelectedItem.ToString();
                string destination = cmbDestination.SelectedItem?.ToString();
                string flightNumber = txtFlightNo.Text;

                if (string.IsNullOrWhiteSpace(flightNumber))
                {
                    MessageBox.Show("Please enter a valid flight number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Form seatMapForm = null;

                switch (selectedAirline)
                {
                    case "Cebu Pacific Air":
                        seatMapForm = new CebuPacificAirSeatMap(selectedClass, selectedAirline, destination, flightNumber, "DefaultPointA", "DefaultPointB");
                        break;

                    case "AirAsia Philippines":
                        seatMapForm = new AirAsiaPhilippinesSeatMap(selectedClass, selectedAirline, destination, flightNumber, "DefaultPointA", "DefaultPointB");
                        break;

                    case "PAL Express":
                        seatMapForm = new PALExpressSeatMap(selectedClass, selectedAirline, destination, flightNumber, "DefaultPointA", "DefaultPointB");
                        break;
                }

                if (seatMapForm != null)
                {
                    var result = seatMapForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        txtSeatNumber.Text = ((dynamic)seatMapForm).SelectedSeat;
                    }
                }
                else
                {
                    MessageBox.Show("No seat map available for the selected airline.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the seat map: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
