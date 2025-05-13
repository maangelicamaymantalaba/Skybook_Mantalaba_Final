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
    public partial class List : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb;";
        public List()
        {
            InitializeComponent();
            LoadAllPassengers();
            InitializeDataGridViewProperties();
            LoadAllCrew();
        }
        private void InitializeDataGridViewProperties()
        {
            dgvPassengers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPassengers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCrew.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCrew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            main form1 = new main();
            form1.Show();

            this.Close();
        }

        private void btnSearchPassengers_Click(object sender, EventArgs e)
        {
            string customerName = txtPassenger.Text.Trim();

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter a customer name to search.");
                return;
            }

            SearchPassenger(customerName);
        }
        private void LoadAllPassengers()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, CostumerName, Airline, CostumerDestination, SeatClass, SeatNumber, DepartureTime, Price, FlightNum FROM tblReservation";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvPassengers.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading passengers: " + ex.Message);
                }
            }
        }

        private void SearchPassenger(string customerName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, CostumerName, Airline, CostumerDestination, SeatClass, SeatNumber, DepartureTime, Price, FlightNum FROM tblReservation WHERE CostumerName LIKE @CustomerName";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", "%" + customerName + "%");

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvPassengers.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No passengers found with that name.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for passengers: " + ex.Message);
                }
            }
        }

        private void btnSearchCrew_Click(object sender, EventArgs e)
        {
            string crewName = txtCrew.Text.Trim();

            if (string.IsNullOrEmpty(crewName))
            {
                MessageBox.Show("Please enter a crew name to search.");
                return;
            }

            SearchCrew(crewName);
        }

        private void LoadAllCrew()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, CrewName, CrewType, FlightCrewPosition, CabinCrewPosition FROM tblCrewList";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvCrew.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading crew members: " + ex.Message);
                }
            }
        }
        private void SearchCrew(string crewName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, CrewName, CrewType, FlightCrewPosition, CabinCrewPosition FROM tblCrewList WHERE CrewName LIKE @CrewName";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CrewName", "%" + crewName + "%");

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvCrew.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No crew members found with that name.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for crew members: " + ex.Message);
                }
            }
        }

        private void btnSearchFlightNo_Click(object sender, EventArgs e)
        {
            string flightNumber = txtFlightNo.Text.Trim();

            if (string.IsNullOrEmpty(flightNumber))
            {
                MessageBox.Show("Please enter a flight number to search.");
                return;
            }

            SearchByFlightNumber(flightNumber);
        }
        private void SearchByFlightNumber(string flightNumber)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, CostumerName, Airline, CostumerDestination, SeatClass, SeatNumber, DepartureTime, Price, FlightNum FROM tblReservation WHERE FlightNum LIKE @FlightNumber";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FlightNumber", "%" + flightNumber + "%");

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvPassengers.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No passengers found for that flight number.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching by flight number: " + ex.Message);
                }
            }
        }
    }
}
