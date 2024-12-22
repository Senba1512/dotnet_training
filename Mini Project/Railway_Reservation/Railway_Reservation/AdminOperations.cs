﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Reservation
{
    public class AdminOperations
    {
        public static void AdminAction()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------Admin Menu--------------------");
                    Console.WriteLine("1. Add Train");
                    Console.WriteLine("2. Update Train");
                    Console.WriteLine("3. Delete Train");
                    Console.WriteLine("4. View All Bookings");
                    Console.WriteLine("5. View All Cancellations");
                    Console.WriteLine("6. Manage Users");
                    Console.WriteLine("7. Logout");
                    Console.Write("Choose an option: ");
                    var choice = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(choice))
                    {
                        Console.WriteLine("Invalid input! Please choose a valid option.");
                        continue;
                    }

                    if (choice == "1")
                    {
                        AddTrain();
                    }
                    else if (choice == "2")
                    {
                        UpdateTrain();
                    }
                    else if (choice == "3")
                    {
                        DeleteTrain();
                    }
                    else if (choice == "4")
                    {
                        ViewAllBookings();
                    }
                    else if (choice == "5")
                    {
                        ViewAllCancellations();
                    }
                    else if (choice == "6")
                    {
                        ManageUsers();
                    }
                    else if (choice == "7")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                    }
                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"An error occurred: {ex.Message}");

                    Console.WriteLine("Please try again.");
                }
            }
        }

        private static void AddTrain()
        {
            Console.Clear();

            try
            {
                Console.Write("Enter Train Number: ");
                var tno = int.Parse(Console.ReadLine());

                Console.Write("Enter Train Name: ");
                var tname = Console.ReadLine();

                Console.Write("Enter Source Station: ");
                var fromStation = Console.ReadLine();

                Console.Write("Enter Destination Station: ");
                var destStation = Console.ReadLine();

                Console.Write("Enter Class of Travel: ");
                var classOfTravel = Console.ReadLine();


                DateTime dateOfTravel=DateTime.UtcNow;
                Console.Write("Enter Date of Travel (yyyy-mm-dd): ");
                try
                {
                    dateOfTravel = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: Invalid date format. {ex.Message}. Please use yyyy-mm-dd.");
                }


                int seatsAvailable=0;
                Console.Write("Enter Number of Seats Available: ");
                try
                {
                    seatsAvailable = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: Invalid number of seats. {ex.Message}. Please enter a valid integer.");
                    
                }

               
                Console.Write("Enter Ticket Price: ");
                   decimal price = decimal.Parse(Console.ReadLine());

               
                Console.Write("Enter Train Status (Active/Inactive): ");
                var trainStatus = Console.ReadLine();

                if (trainStatus == null || (trainStatus.ToLower() != "active" && trainStatus.ToLower() != "inactive"))
                {
                    Console.WriteLine("Error: Invalid train status. Please enter 'Active' or 'Inactive'.");
                    return; 
                }

                
                var query = "INSERT INTO Trains (Tno, ClassOfTravel, Tname, FromStation, DestStation, DateOfTravel, SeatsAvailable, Price, TrainStatus) VALUES (@Tno, @ClassOfTravel, @Tname, @FromStation, @DestStation, @DateOfTravel, @SeatsAvailable, @Price, @TrainStatus)";

                var parameters = new[]
                {
                                new SqlParameter("@Tno", tno),
                                new SqlParameter("@ClassOfTravel", classOfTravel),
                                new SqlParameter("@Tname", tname),
                                new SqlParameter("@FromStation", fromStation),
                                new SqlParameter("@DestStation", destStation),
                                new SqlParameter("@DateOfTravel", dateOfTravel),
                                new SqlParameter("@SeatsAvailable", seatsAvailable),
                                new SqlParameter("@Price", price),
                                new SqlParameter("@TrainStatus", trainStatus)
                 };

                
                DBConnector.ExecuteNonQuery(query, parameters);
                Console.WriteLine("Train added successfully.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }


        private static void UpdateTrain()
        {
            Console.Clear();
            int tno;
         
            Console.Write("Enter Train Number to Update: ");
            tno = int.Parse(Console.ReadLine());
            
            Console.Write("Enter New Train Name (or leave blank to keep current): ");
            var tname = Console.ReadLine();

            Console.Write("Enter New Source Station (or leave blank to keep current): ");
            var fromStation = Console.ReadLine();

            Console.Write("Enter New Destination Station (or leave blank to keep current): ");
            var destStation = Console.ReadLine();

            Console.Write("Enter New Price (or leave blank to keep current): ");
            var priceInput = Console.ReadLine();
            decimal? price = string.IsNullOrEmpty(priceInput) ? (decimal?)null : decimal.Parse(priceInput);

            Console.Write("Enter New Seats Available (or leave blank to keep current): ");
            var seatsInput = Console.ReadLine();
            int? seatsAvailable = string.IsNullOrEmpty(seatsInput) ? (int?)null : int.Parse(seatsInput);

            var updates = new List<string>();
            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(tname))
            {
                updates.Add("Tname = @Tname");
                parameters.Add(new SqlParameter("@Tname", tname));
            }
            if (!string.IsNullOrEmpty(fromStation))
            {
                updates.Add("FromStation = @FromStation");
                parameters.Add(new SqlParameter("@FromStation", fromStation));
            }
            if (!string.IsNullOrEmpty(destStation))
            {
                updates.Add("DestStation = @DestStation");
                parameters.Add(new SqlParameter("@DestStation", destStation));
            }
            if (price.HasValue)
            {
                updates.Add("Price = @Price");
                parameters.Add(new SqlParameter("@Price", price.Value));
            }
            if (seatsAvailable.HasValue)
            {
                updates.Add("SeatsAvailable = @SeatsAvailable");
                parameters.Add(new SqlParameter("@SeatsAvailable", seatsAvailable.Value));
            }

            if (updates.Count == 0)
            {
                Console.WriteLine("No updates provided.");
                Console.ReadLine();
                return;
            }

            var updateQuery = $"UPDATE Trains SET {string.Join(", ", updates)} WHERE Tno = @Tno";
            parameters.Add(new SqlParameter("@Tno", tno));
            
            try
            {
                DBConnector.ExecuteNonQuery(updateQuery, parameters.ToArray());
                Console.WriteLine("Train updated successfully.");
            }

            catch (SqlException ex)
            {
                
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        private static void DeleteTrain()
        {
            Console.Clear();

            int tno=0;

            try
            {
                Console.Write("Enter Train Number to Deleted ");
                tno = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid train number. Please enter a valid integer.");
  
            }

            var deleteCancellationsQuery = "DELETE FROM Cancellations WHERE BookingId IN (SELECT BookingId FROM Bookings WHERE Tno = @Tno)";
            var deleteBookingsQuery = "DELETE FROM Bookings WHERE Tno = @Tno";
            var deleteTrainQuery = "DELETE FROM Trains WHERE Tno = @Tno";

            try
            {
                using (var connection = new SqlConnection(DBConnector.GetConnectionString()))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        
                            
                            using (var deleteCancellationsCommand = new SqlCommand(deleteCancellationsQuery, connection, transaction))
                            {
                                deleteCancellationsCommand.Parameters.Add(new SqlParameter("@Tno", tno));
                                int rowsAffectedCancellations = deleteCancellationsCommand.ExecuteNonQuery();
                                Console.WriteLine($"{rowsAffectedCancellations} cancellation(s) deleted.");
                            }

                          
                            using (var deleteBookingsCommand = new SqlCommand(deleteBookingsQuery, connection, transaction))
                            {
                                deleteBookingsCommand.Parameters.Add(new SqlParameter("@Tno", tno));
                                int rowsAffectedBookings = deleteBookingsCommand.ExecuteNonQuery();
                                Console.WriteLine($"{rowsAffectedBookings} booking(s) deleted.");
                            }

                            
                            using (var deleteTrainCommand = new SqlCommand(deleteTrainQuery, connection, transaction))
                            {
                                deleteTrainCommand.Parameters.Add(new SqlParameter("@Tno", tno));
                                int rowsAffectedTrain = deleteTrainCommand.ExecuteNonQuery();
                                Console.WriteLine($"{rowsAffectedTrain} train(s) deleted.");
                            }

                            transaction.Commit();

                            Console.WriteLine("Train deleted successfully.");
                       
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database connection error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
        private static void ViewAllBookings()
        {
            Console.Clear();
            var query = "SELECT * FROM Bookings";

            try
            {
                var table = DBConnector.ExecuteQuery(query);

                if (table != null && table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine($"Booking ID: {row["BookingId"]}, Train No: {row["Tno"]}, User ID: {row["UserId"]}, Seats: {row["NumberOfSeats"]}, Date: {row["BookingDate"]}");
                    }
                }
                else
                {
                    Console.WriteLine("No bookings found.");
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        private static void ViewAllCancellations()
        {
            Console.Clear();
            var query = "SELECT C.CancellationId, C.BookingId, C.NumberOfSeatsCancelled, C.CancellationDate, B.Tno, B.UserId " +
                        "FROM Cancellations C " +
                        "JOIN Bookings B ON C.BookingId = B.BookingId";

            try
            {
                var table = DBConnector.ExecuteQuery(query);

                if (table != null && table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine($"Cancellation ID: {row["CancellationId"]}, Booking ID: {row["BookingId"]}, Train No: {row["Tno"]}, User ID: {row["UserId"]}, Seats Cancelled: {row["NumberOfSeatsCancelled"]}, Date: {row["CancellationDate"]}");
                    }
                }
                else
                {
                    Console.WriteLine("No cancellations found.");
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        public static void ManageUsers()
        {
            Console.Clear();
            Console.WriteLine("1. View All Users");
            Console.WriteLine("2. Delete User");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                ViewAllUsers();

            }
            else if (choice == "2")
            {
                DeleteUser();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }

       
        private static void ViewAllUsers()
        {
            Console.Clear();
            var query = "SELECT * FROM Users";

            try
            {
                var table = DBConnector.ExecuteQuery(query); 

                if (table != null && table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine($"User ID: {row["UserId"]}, Username: {row["Username"]}");
                    }
                }
                else
                {
                    Console.WriteLine("No users found.");
                }
            }

            catch (SqlException ex)
            { 
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        private static void DeleteUser()
        {
            Console.Clear();          
            Console.Write("Enter User ID to Delete: ");
            int userId = int.Parse(Console.ReadLine());

            var deleteBookingsQuery = "DELETE FROM Bookings WHERE UserId = @UserId";
            var deleteUserQuery = "DELETE FROM Users WHERE UserId = @UserId";

            try
            {
                using (var connection = new SqlConnection(DBConnector.connectionString)) 
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {

                        
                        using (var deleteBookingsCommand = new SqlCommand(deleteBookingsQuery, connection, transaction))
                        {
                            deleteBookingsCommand.Parameters.Add(new SqlParameter("@UserId", userId));
                            int rowsAffectedBookings = deleteBookingsCommand.ExecuteNonQuery();
                            Console.WriteLine($"{rowsAffectedBookings} booking(s) deleted.");
                        }

                      
                        using (var deleteUserCommand = new SqlCommand(deleteUserQuery, connection, transaction))
                        {
                            deleteUserCommand.Parameters.Add(new SqlParameter("@UserId", userId));
                            int rowsAffectedUser = deleteUserCommand.ExecuteNonQuery();
                            Console.WriteLine($"{rowsAffectedUser} user(s) deleted.");
                        }

                      
                        transaction.Commit();
                        Console.WriteLine("User deleted successfully.");
                    }
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
