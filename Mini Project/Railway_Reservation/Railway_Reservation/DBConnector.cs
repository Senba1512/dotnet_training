using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Reservation
{
    public  class DBConnector
    {
        public static string connectionString = "Data source = ICS-LT-3XTMQ73\\SQLEXPRESS;Database=RailwayReservationDB;Trusted_Connection=True;";

        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                try
                {
                    adapter.Fill(table);
                }
               
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL error occurred: {ex.Message}");
                   
                }
                return table;
            }
        }
        public static object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteScalar(); 
            }
        }
        public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Invalid operation error: {ex.Message}");
                }       
            }
        }
    }
}
