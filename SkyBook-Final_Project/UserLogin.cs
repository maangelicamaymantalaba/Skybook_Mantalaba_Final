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
    public partial class UserLogin : Form
    {
        private User user;

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asus Tuf Gaming F15\Documents\Skybook_FINALProjectMantalaba.accdb;";
        public UserLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            User user = User.Authenticate(username, password, connectionString);

            if (user != null)
            {
                this.Hide();
                Form nextForm = user.IsAdmin ? new AdminMain() : new main();
                nextForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void chckbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chckbxShowPass.Checked ? '\0' : '*';

        }
 

        private void LnkChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.Show();
            this.Hide();
        }
    }
}
