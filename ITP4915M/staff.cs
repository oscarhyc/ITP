using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M
{
    using System.Data;
    using System.Xml.Linq;
    using MySql.Data.MySqlClient;

    public class Staff
    {
        public string Name { get; set; }
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public int FailedLoginAttempts { get; set; }
        public bool Authenticate(string username, string password)
        {
            // Database connection string
            string connectionString = DatabaseConfig.ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve staff details
                string query = "SELECT * FROM staff WHERE Username = @Username AND Password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Name = reader.GetString("Name");
                            StaffID = reader.GetInt32("Staff ID");
                            Username = reader.GetString("Username");
                            Department = reader.GetString("DepartmentDeptCode");
                            Position = reader.GetString("PositionPositionCode");

                            FailedLoginAttempts = reader.GetInt32("FailedLoginAttempts");

                            return true; // Authentication successful
                        }
                    }
                }
            }

            return false; // Authentication failed
        }
    }
}
