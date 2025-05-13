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
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Defaults;
using System.Globalization;


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
            chartSalesAnalytics.Series = Array.Empty<ISeries>();

            var columnSeries = new ColumnSeries<double>
            {
                Values = salesData.AsEnumerable().Select(row => Convert.ToDouble(row["TotalSales"])).ToArray(),
                Name = "Sales"
            };

            var labels = salesData.AsEnumerable()
                .Select(row => Convert.ToDateTime(row["SaleDate"]).ToString("MM/dd/yyyy"))
                .ToArray();

            chartSalesAnalytics.Series = new ISeries[] { columnSeries };
            chartSalesAnalytics.XAxes = new Axis[]
            {
                new Axis
                {
                    Labels = labels,
                    Name = "Date"
                }
            };
            chartSalesAnalytics.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Total Sales"
                }
            };
        }
    }
 }
