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
using System.Security.Cryptography; 


namespace SkyBook_Final_Project
{
    public partial class AddUsers : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb;";
        public AddUsers()
        {
            InitializeComponent();
            LoadAdminChoices();
            InitializeDataGridViewProperties();
            LoadUsersIntoDataGridView(); 
        }
        private void LoadAdminChoices()
        {
            cmbAdmin.Items.Add("Yes");
            cmbAdmin.Items.Add("No");
        }
        private void InitializeDataGridViewProperties()
        {
            // Set AutoSizeRowsMode and AutoSizeColumnsMode for dgvUser
            dgvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadUsersIntoDataGridView()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, Username, [Password], Email, IsAdmin FROM tblUser";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvUser.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMain adminMainForm = new AdminMain();

            adminMainForm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            bool isAdmin = cmbAdmin.SelectedItem != null && cmbAdmin.SelectedItem.ToString() == "Yes";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || cmbAdmin.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields and select 'Yes' or 'No' for Admin.");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tblUser (Username, [Password], Email, IsAdmin) VALUES (?, ?, ?, ?)";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    command.Parameters.AddWithValue("?", username);
                    command.Parameters.AddWithValue("?", hashedPassword); 
                    command.Parameters.AddWithValue("?", email);
                    command.Parameters.AddWithValue("?", isAdmin);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully!");

                        LoadUsersIntoDataGridView();

                        txtName.Clear();
                        txtPassword.Clear();
                        txtEmail.Clear();
                        cmbAdmin.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int selectedId = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["ID"].Value);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM tblUser WHERE ID = ?";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("?", selectedId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!");

                        LoadUsersIntoDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); 
                }
                return builder.ToString();
            }
        }
    }
}
