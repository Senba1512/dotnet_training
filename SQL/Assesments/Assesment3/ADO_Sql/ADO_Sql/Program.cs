using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        using (SqlConnection connection = new SqlConnection("Data source = ICS-LT-3XTMQ73\\SQLEXPRESS;Database=Assesment3;Trusted_Connection=True"))
        {
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Insert_ProdDetails", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductName", "TV");
                    cmd.Parameters.AddWithValue("@Price", 40000);
                    SqlParameter productIdParam = new SqlParameter("@GeneratedProductId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(productIdParam);
                    SqlParameter discountedPriceParam = new SqlParameter("@DiscountedPrice", SqlDbType.Decimal)
                    {
                        Precision = 10,
                        Scale = 2,
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(discountedPriceParam);
                    cmd.ExecuteNonQuery();
                    int generatedProductId = (int)productIdParam.Value;
                    decimal discountedPrice = (decimal)discountedPriceParam.Value;
                    Console.WriteLine($"ProductId: {generatedProductId}");
                    Console.WriteLine($"Discounted Price: {discountedPrice}");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}