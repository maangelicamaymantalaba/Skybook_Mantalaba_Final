using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBook_Final_Project
{
    public partial class AirAsiaPhilippinesSeatMap : Form
    {

        private Dictionary<string, Button> seatButtons = new Dictionary<string, Button>();
        private string selectedSeat = "";
        private string currentClass = "";
        private readonly SeatMapHelper seatMapHelper;

        public string SelectedClass { get; private set; }
        public string SelectedSeat => selectedSeat;


        public AirAsiaPhilippinesSeatMap(string travelClass, string airline, string dest, string flightNumber, string pointA, string pointB)
        {
            InitializeComponent();
            InitializeSeatMap();
            seatMapHelper = new SeatMapHelper(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb");

            txtFlightNo.Text = flightNumber;

            cmbClass.SelectedIndexChanged += CmbClass_SelectedIndexChanged;

            SelectedClass = travelClass;
            currentClass = travelClass;
            cmbClass.SelectedItem = travelClass;
            CmbClass_SelectedIndexChanged(null, null);

            seatMapHelper.CheckBookedSeats(seatButtons, flightNumber);
        }
        private void InitializeSeatMap()
        {
            seatButtons.Add("A1", A1);
            seatButtons.Add("B1", B1);
            seatButtons.Add("C1", C1);
            seatButtons.Add("D1", D1);

            seatButtons.Add("A2", A2);
            seatButtons.Add("B2", B2);
            seatButtons.Add("C2", C2);
            seatButtons.Add("A3", A3);
            seatButtons.Add("B3", B3);
            seatButtons.Add("C3", C3);

            seatButtons.Add("A4", A4);
            seatButtons.Add("B4", B4);
            seatButtons.Add("C4", C4);
            seatButtons.Add("D4", D4);
            seatButtons.Add("E4", E4);
            seatButtons.Add("F4", F4);

            seatButtons.Add("A5", A5);
            seatButtons.Add("B5", B5);
            seatButtons.Add("C5", C5);
            seatButtons.Add("D5", D5);
            seatButtons.Add("E5", E5);
            seatButtons.Add("F5", F5);

            seatButtons.Add("A6", A6);
            seatButtons.Add("B6", B6);
            seatButtons.Add("C6", C6);
            seatButtons.Add("D6", D6);
            seatButtons.Add("E6", E6);
            seatButtons.Add("F6", F6);

            seatButtons.Add("A7", A7);
            seatButtons.Add("B7", B7);
            seatButtons.Add("C7", C7);
            seatButtons.Add("D7", D7);
            seatButtons.Add("E7", E7);
            seatButtons.Add("F7", F7);

            seatButtons.Add("A8", A8);
            seatButtons.Add("B8", B8);
            seatButtons.Add("C8", C8);
            seatButtons.Add("D8", D8);
            seatButtons.Add("E8", E8);
            seatButtons.Add("F8", F8);

            seatButtons.Add("A9", A9);
            seatButtons.Add("B9", B9);
            seatButtons.Add("C9", C9);
            seatButtons.Add("D9", D9);
            seatButtons.Add("E9", E9);
            seatButtons.Add("F9", F9);

            seatButtons.Add("A10", A10);
            seatButtons.Add("B10", B10);
            seatButtons.Add("C10", C10);
            seatButtons.Add("D10", D10);
            seatButtons.Add("E10", E10);
            seatButtons.Add("F10", F10);

            seatButtons.Add("A11", A11);
            seatButtons.Add("B11", B11);
            seatButtons.Add("C11", C11);
            seatButtons.Add("D11", D11);
            seatButtons.Add("E11", E11);
            seatButtons.Add("F11", F11);

            seatButtons.Add("A13", A13);
            seatButtons.Add("B13", B13);
            seatButtons.Add("C13", C13);
            seatButtons.Add("D13", D13);
            seatButtons.Add("E13", E13);
            seatButtons.Add("F13", F13);

            seatButtons.Add("A14", A14);
            seatButtons.Add("B14", B14);
            seatButtons.Add("C14", C14);
            seatButtons.Add("D14", D14);
            seatButtons.Add("E14", E14);
            seatButtons.Add("F14", F14);

            foreach (var button in seatButtons.Values)
            {
                button.Click += SeatButton_Click;
                button.MouseEnter += (s, e) => { if (button.BackColor != Color.Red) button.BackColor = Color.Blue; };
                button.MouseLeave += (s, e) => { if (button.BackColor != Color.Red) button.BackColor = Color.LightGreen; };
            }

            cmbClass.Items.AddRange(new string[] { "First Class", "Business", "Economy" });
            DisableAllSeats();
        }
        private void DisableAllSeats()
        {
            foreach (var button in seatButtons.Values)
            {
                button.Enabled = false;
                button.BackColor = SystemColors.Control;
            }
        }
        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedItem == null) return;

            currentClass = cmbClass.SelectedItem.ToString();
            selectedSeat = "";
            txtSeatNumber.Text = "";
            DisableAllSeats();

            switch (currentClass)
            {
                case "First Class":
                    EnableSeats(new List<string> { "A1", "B1", "C1", "D1" });
                    break;
                case "Business":
                    EnableSeats(new List<string> { "A2", "B2", "C2", "A3", "B3", "C3", "A13", "B13", "C13", "D13", "E13", "F13" });
                    break;
                case "Economy":
                    var economySeats = new List<string>();
                    for (int i = 4; i <= 11; i++)
                    {
                        economySeats.Add($"{i}A");
                        economySeats.Add($"B{i}");
                        economySeats.Add($"C{i}");
                        economySeats.Add($"D{i}");
                        economySeats.Add($"E{i}");
                        economySeats.Add($"F{i}");
                    }
                    economySeats.AddRange(new[] { "A4", "B4", "C4", "D4", "E4", "F4" });
                    economySeats.AddRange(new[] { "A5", "B5", "C5", "D5", "E5", "F5" });
                    economySeats.AddRange(new[] { "A6", "B6", "C6", "D6", "E6", "F6" });
                    economySeats.AddRange(new[] { "A7", "B7", "C7", "D7", "E7", "F7" });
                    economySeats.AddRange(new[] { "A8", "B8", "C8", "D8", "E8", "F8" });
                    economySeats.AddRange(new[] { "A9", "B9", "C9", "D9", "E9", "F9" });
                    economySeats.AddRange(new[] { "A10", "B10", "C10", "D10", "E10", "F10" });
                    economySeats.AddRange(new[] { "A11", "B11", "C11", "D11", "E11", "F11" });
                    economySeats.AddRange(new[] { "A14", "B14", "C14", "D14", "E14", "F14" });

                    EnableSeats(economySeats.Distinct().ToList());
                    break;
            }
        }
        private void EnableSeats(List<string> seatCodes)
        {
            foreach (var seat in seatCodes)
            {
                if (seatButtons.ContainsKey(seat))
                {
                    seatButtons[seat].Enabled = true;
                    seatButtons[seat].BackColor = Color.LightGreen;
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string seatCode = button.Text;

            if (button.BackColor == Color.Red)
            {
                MessageBox.Show("This seat is already booked, choose another seat.", "Seat Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(selectedSeat) && seatButtons.ContainsKey(selectedSeat))
            {
                seatButtons[selectedSeat].BackColor = Color.LightGreen;
            }

            selectedSeat = seatCode;
            button.BackColor = Color.Blue;

            UpdateSeatNumberText();
        }

        private void UpdateSeatNumberText()
        {
            txtSeatNumber.Text = selectedSeat;
        }

     
        private void btnConfirmSeat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedSeat))
            {
                MessageBox.Show("Please select a seat.", "No Seat Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedSeat))
            {
                MessageBox.Show("Please select a seat before submitting.", "No Seat Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string message = $"Successfully booked seat: {selectedSeat}";
            MessageBox.Show(message, "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
