using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Reservation
{
    internal class Program
    {

        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("                       Welcome to Railway Reservation                    ");
                    Console.WriteLine();
                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");
                    Console.Write("Choose an option: ");
                    var choice = Console.ReadLine();

                    RegisterOperations reg = new RegisterOperations();
                    LoginOperations login = new LoginOperations();

                    if (choice == "1")
                    {
                        reg.Register();
                    }
                    else if (choice == "2")
                    {
                        login.Login();
                    }
                    else if (choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid choice! Please enter a valid option (1, 2, or 3).");
                    }
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                }
                Console.ReadLine(); 
            }

        }
    }
}
    
