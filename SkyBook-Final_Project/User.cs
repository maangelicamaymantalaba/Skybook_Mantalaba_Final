using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SkyBook_Final_Project
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; } 
        public bool IsAdmin { get; private set; }

        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = HashPassword(password); 
            IsAdmin = isAdmin;
        }

        public static string HashPassword(string password)
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

        public bool ValidatePassword(string password)
        {
            string hashedPassword = HashPassword(password);
            return Password == hashedPassword;
        }

        public static User Authenticate(string username, string password, string connectionString)
        {
            string hashedPassword = HashPassword(password);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT Username, Password, IsAdmin FROM tblUser WHERE Username = ? AND Password = ?";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("?", username);
                command.Parameters.AddWithValue("?", hashedPassword);

                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bool isAdmin = reader.GetBoolean(2);
                        return new User(username, password, isAdmin);
                    }
                }
            }

            return null; 
        }

        public static bool ChangePassword(string username, string oldPassword, string newPassword, string connectionString)
        {
            string hashedOldPassword = HashPassword(oldPassword);
            string hashedNewPassword = HashPassword(newPassword);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM tblUser WHERE Username = ? AND Password = ?";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("?", username);
                command.Parameters.AddWithValue("?", hashedOldPassword);

                connection.Open();
                int userExists = (int)command.ExecuteScalar();

                if (userExists > 0)
                {
                    string updateQuery = "UPDATE tblUser SET [Password] = ? WHERE Username = ?";
                    OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("?", hashedNewPassword);
                    updateCommand.Parameters.AddWithValue("?", username);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

            return false; 
        }
    }
}
