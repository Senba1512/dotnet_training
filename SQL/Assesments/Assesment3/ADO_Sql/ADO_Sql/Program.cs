using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        
        string connString = "Server=ICS-LT-3XTMQ73\\SQLEXPRESS;Database=Assesment3;Trusted_Connection=True;";

        using (SqlConnection connection = new SqlConnection(connString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection opened");

                using (SqlCommand command = new SqlCommand("InsertProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@ProductName", "Laptop");
                    command.Parameters.AddWithValue("@Price", 70000);

                    
                    SqlParameter productIdParam = new SqlParameter("@GeneratedProductId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(productIdParam);

                    SqlParameter discountedPriceParam = new SqlParameter("@DiscountedPrice", SqlDbType.Decimal)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(discountedPriceParam);

                    command.ExecuteNonQuery();

                    
                    int generatedProductId = (int)productIdParam.Value;
                    decimal discountedPrice = (decimal)discountedPriceParam.Value;

                   
                    Console.WriteLine($"Generated Product ID: {generatedProductId}");
                    Console.WriteLine($"Discounted Price: {discountedPrice}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}