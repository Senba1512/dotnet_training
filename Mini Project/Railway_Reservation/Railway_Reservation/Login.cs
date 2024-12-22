using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Reservation
{
    public  class LoginOperations
    {
        public   void Login()
        {
            Console.Clear();
            Console.WriteLine("-----------------------Login------------------------------");
            Console.Write("Enter Username: ");
            var username = Console.ReadLine();

            Console.Write("Enter Password: ");
            var password = Console.ReadLine();

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
                    Console.WriteLine("Please enter a valid role (A for Admin, U for User).");
                }
            }

            string query = role == "A" ?
                "SELECT AdminId FROM Admins WHERE Username = @Username AND Password = @Password" :
                "SELECT UserId FROM Users WHERE Username = @Username AND Password = @Password";

            var parameters = new[]
            {
             new SqlParameter("@Username", username),
             new SqlParameter("@Password", password)
             };

            try
            {
                var table = DBConnector.ExecuteQuery(query, parameters);

                if (table != null && table.Rows.Count > 0)
                {
                    if (role == "A")
                    {
                        AdminOperations.AdminAction(); 
                    }
                    else
                    {
                        var userId = (int)table.Rows[0]["UserId"];
                        UserOperations.UserAction(userId); 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid credentials.");
                }
            }
         
           
            catch (SqlException ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

    }
}
