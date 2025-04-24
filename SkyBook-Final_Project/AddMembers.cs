using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.OleDb;

namespace SkyBook_Final_Project
{
    public partial class AddMembers : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataTable dataTable;

        public AddMembers()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridViewProperties();
            LoadCrewMembers();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb;";
            connection = new OleDbConnection(connectionString);
        }
        private void InitializeDataGridViewProperties()
        {
            dgvCrewMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Automatically adjusts row heights
            dgvCrewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Automatically adjusts column widths
        }
        private void LoadCrewMembers()
        {
            try
            {
                connection.Open();
                string query = "SELECT ID, CrewName, CrewType, FlightCrewPosition, CabinCrewPosition FROM tblCrewList";
                adapter = new OleDbDataAdapter(query, connection);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvCrewMembers.DataSource = dataTable;

                // Ensure AutoSize settings are applied even after data binding
                dgvCrewMembers.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                dgvCrewMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading crew members: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            main form1 = new main();
            form1.Show();

            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            cmbCrewType.SelectedIndex = -1;
            cmbFlightCrew.SelectedIndex = -1;
            cmbCabinCrew.SelectedIndex = -1;
            cmbFlightCrew.Enabled = false;
            cmbCabinCrew.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            cmbCrewType.Items.Clear();
            cmbCrewType.Items.Add("Flight Crew");
            cmbCrewType.Items.Add("Cabin Crew");
            cmbCrewType.SelectedIndex = -1;

            cmbFlightCrew.Enabled = false;
            cmbCabinCrew.Enabled = false;

            LoadCrewMembers();
        }


        private void cmbCrewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCrewType.SelectedItem == null) return;

            string selectedType = cmbCrewType.SelectedItem.ToString();

            cmbFlightCrew.Items.Clear();
            cmbCabinCrew.Items.Clear();
            cmbFlightCrew.Enabled = false;
            cmbCabinCrew.Enabled = false;
            cmbFlightCrew.SelectedIndex = -1;
            cmbCabinCrew.SelectedIndex = -1;

            if (selectedType == "Flight Crew")
            {
                cmbFlightCrew.Enabled = true;
                cmbFlightCrew.Items.Add("Pilot");
                cmbFlightCrew.Items.Add("Co-Pilot");
                cmbFlightCrew.Items.Add("Flight Engineer");
            }
            else if (selectedType == "Cabin Crew")
            {
                cmbCabinCrew.Enabled = true;
                cmbCabinCrew.Items.Add("Flight Attendant");
                cmbCabinCrew.Items.Add("Purser");
                cmbCabinCrew.Items.Add("Chief Purser");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter crew member name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }

            if (cmbCrewType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select crew type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCrewType.Focus();
                return;
            }

            string crewType = cmbCrewType.SelectedItem.ToString();
            string flightPosition = "";
            string cabinPosition = "";

            if (crewType == "Flight Crew" && cmbFlightCrew.SelectedIndex == -1)
            {
                MessageBox.Show("Please select flight crew position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbFlightCrew.Focus();
                return;
            }
            else if (crewType == "Cabin Crew" && cmbCabinCrew.SelectedIndex == -1)
            {
                MessageBox.Show("Please select cabin crew position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCabinCrew.Focus();
                return;
            }

            flightPosition = crewType == "Flight Crew" ? cmbFlightCrew.SelectedItem.ToString() : "";
            cabinPosition = crewType == "Cabin Crew" ? cmbCabinCrew.SelectedItem.ToString() : "";

            try
            {
                connection.Open();

                string insertQuery = "INSERT INTO tblCrewList (CrewName, CrewType, FlightCrewPosition, CabinCrewPosition) " +
                                   "VALUES (@CrewName, @CrewType, @FlightCrewPosition, @CabinCrewPosition)";

                using (OleDbCommand cmd = new OleDbCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CrewName", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@CrewType", crewType);
                    cmd.Parameters.AddWithValue("@FlightCrewPosition", flightPosition);
                    cmd.Parameters.AddWithValue("@CabinCrewPosition", cabinPosition);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Crew member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // RELOAD DATA - THREE DIFFERENT METHODS TO ENSURE IT WORKS

                        // Method 1: Clear and rebind
                        dataTable.Clear();
                        adapter.Fill(dataTable);
                        dgvCrewMembers.DataSource = null;
                        dgvCrewMembers.DataSource = dataTable;

                        // Method 3: Refresh the grid directly
                        dgvCrewMembers.Refresh();

                        // Clear form
                        txtname.Clear();
                        cmbCrewType.SelectedIndex = -1;
                        cmbFlightCrew.SelectedIndex = -1;
                        cmbCabinCrew.SelectedIndex = -1;
                        cmbFlightCrew.Enabled = false;
                        cmbCabinCrew.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add crew member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter crew member name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }

            if (cmbCrewType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select crew type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCrewType.Focus();
                return;
            }

            string crewType = cmbCrewType.SelectedItem.ToString();

            string deleteQuery = "DELETE FROM tblCrewList WHERE CrewName = @CrewName AND CrewType = @CrewType";

            try
            {
                connection.Open();

                using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CrewName", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@CrewType", crewType);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Crew member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No crew member found with the specified name and type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            LoadCrewMembers();
        }
    }
}

