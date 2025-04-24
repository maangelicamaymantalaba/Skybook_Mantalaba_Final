using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyBook_Final_Project
{
    class SeatMapHelper : User
    {
        public SeatMapHelper(string username, string password, bool isAdmin, string connectionString)
            : base(username, password, isAdmin)
        {
            _connectionString = connectionString;
        }
        public SeatMapHelper(string connectionString)
        : base("guest", "", false) 
        {
            _connectionString = connectionString;
        }


        private readonly string _connectionString;
        public void CheckBookedSeats(Dictionary<string, Button> seatButtons, string flightNumber)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(_connectionString))
                {
                    conn.Open();
                    foreach (var seatCode in seatButtons.Keys)
                    {
                        string query = @"SELECT COUNT(*) FROM tblReservation 
                                     WHERE SeatNumber = @SeatNumber 
                                     AND FlightNum = @FlightNum";

                        using (OleDbCommand command = new OleDbCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@SeatNumber", seatCode);
                            command.Parameters.AddWithValue("@FlightNum", flightNumber);

                            int count = (int)command.ExecuteScalar();
                            if (count > 0)
                            {
                                var button = seatButtons[seatCode];
                                button.Enabled = false;
                                button.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking booked seats: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
    
}
