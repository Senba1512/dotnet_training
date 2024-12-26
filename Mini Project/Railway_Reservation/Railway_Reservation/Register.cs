using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Reservation
{
    public class RegisterOperations
    {
        public void Register()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("           Registeration           ");
            Console.WriteLine("===================================");

            string username = string.Empty;
            string password = string.Empty;

           
            while (string.IsNullOrEmpty(username))
            {
                Console.Write("Enter Username: ");
                username = Console.ReadLine();

                if (string.IsNullOrEmpty(username))
                {
                    Console.WriteLine("Username cannot be empty. Please enter a valid username.");
                }
            }

            while (string.IsNullOrEmpty(password))
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Password cannot be empty. Please enter a valid password.");
                }
            }

            string role;
            while (true)
            {
                Console.Write("Are you registering as an Admin or User? (A/U): ");
                role = Console.ReadLine().ToUpper();

                if (role == "A" || role == "U")
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter a valid role (A for Admin, U for User)");
                }
            }
           
            string checkQuery = role == "A" ?
                "SELECT COUNT(*) FROM Admins WHERE Username = @Username" :
                "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            var checkParameters = new[] 
            {
                 new SqlParameter("@Username", username)
            };

            try
            {
                int userExists = (int)DBConnector.ExecuteScalar(checkQuery, checkParameters);

                if (userExists > 0)
                {
                    Console.WriteLine("This username is already Exists.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    return; 
                }
                string insertQuery = role == "A" ?
                    "INSERT INTO Admins (Username, Password) VALUES (@Username, @Password)" :
                    "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                var insertParameters = new[] {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
   
                DBConnector.ExecuteNonQuery(insertQuery, insertParameters);
                Console.WriteLine("Registration successful.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.WriteLine("Press Enter to continue.");      
        }
    }
}
