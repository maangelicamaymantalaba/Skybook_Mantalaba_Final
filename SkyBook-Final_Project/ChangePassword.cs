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
    public partial class ChangePassword : Form
    {
        private User user;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb;";
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin userLoginForm = new UserLogin();

            userLoginForm.Show();

            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string oldPassword = txtOldPass.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = User.ChangePassword(username, oldPassword, newPassword, connectionString);

            if (success)
            {
                MessageBox.Show("Password changed successfully!");
                txtUsername.Clear();
                txtOldPass.Clear();
                txtNewPass.Clear();
            }
            else
            {
                MessageBox.Show("Invalid username or old password.");
            }
        }
  

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
