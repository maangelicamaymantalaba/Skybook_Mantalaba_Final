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
    public partial class AdminSales : Form
    {

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb;";

        public AdminSales()
        {
            InitializeComponent();
            LoadSalesChoices(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMain adminMainForm = new AdminMain();

            adminMainForm.Show();

            this.Hide();
        }
        private void LoadSalesChoices()
        {
            cmbSales.Items.Add("Daily");
            cmbSales.Items.Add("Weekly");
            cmbSales.Items.Add("Monthly");
            cmbSales.Items.Add("Annually");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbSales.SelectedItem == null)
            {
                MessageBox.Show("Please select a sales range (Daily, Weekly, Monthly, Annually).");
                return;
            }

            string salesRange = cmbSales.SelectedItem.ToString();

            DataTable salesData = GetSalesData(salesRange);

            if (salesData.Rows.Count > 0)
            {
                // Bind the data to the chart
                BindDataToChart(salesData, salesRange);
            }
            else
            {
                MessageBox.Show($"No sales data found for the selected range: {salesRange}.");
            }
        }
        private DataTable GetSalesData(string salesRange)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = BuildSalesQuery(salesRange);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable salesData = new DataTable();
                    adapter.Fill(salesData);
                    return salesData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving sales data: {ex.Message}");
                    return new DataTable();
                }
            }
        }
        private string BuildSalesQuery(string salesRange)
        {
            // Build the SQL query based on the selected range
            string query = "SELECT FORMAT(DepartureTime, 'yyyy-mm-dd') AS SaleDate, SUM(Price) AS TotalSales FROM tblReservation ";
            switch (salesRange)
            {
                case "Daily":
                    query += "WHERE DepartureTime >= Date() GROUP BY FORMAT(DepartureTime, 'yyyy-mm-dd')";
                    break;
                case "Weekly":
                    query += "WHERE DepartureTime >= DateAdd('d', -7, Date()) GROUP BY FORMAT(DepartureTime, 'yyyy-mm-dd')";
                    break;
                case "Monthly":
                    query += "WHERE DepartureTime >= DateAdd('m', -1, Date()) GROUP BY FORMAT(DepartureTime, 'yyyy-mm-dd')";
                    break;
                case "Annually":
                    query += "WHERE DepartureTime >= DateAdd('yyyy', -1, Date()) GROUP BY FORMAT(DepartureTime, 'yyyy-mm-dd')";
                    break;
                default:
                    throw new ArgumentException("Invalid sales range selected.");
            }
            return query;
        }
        private void BindDataToChart(DataTable salesData, string salesRange)
        {

            chartSales.Series.Clear();

            var series = chartSales.Series.Add("Sales");

            chartSales.DataSource = salesData;

            series.XValueMember = "SaleDate";
            series.YValueMembers = "TotalSales";

            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chartSales.Titles.Clear();
            chartSales.Titles.Add($"Sales Analytics ({salesRange})");
            chartSales.ChartAreas[0].AxisX.Title = "Date";
            chartSales.ChartAreas[0].AxisY.Title = "Total Sales";
            chartSales.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";

            chartSales.DataBind();
        }

    }
}
