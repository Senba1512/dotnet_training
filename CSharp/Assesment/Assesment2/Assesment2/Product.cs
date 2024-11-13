using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    internal class Product
    {
        public int Pid { get; set; }
        public string PName { get; set; }
        public double Price { get; set; }


        public Product(int ProdId, string ProdName, double ProdPrice) {

            Pid = ProdId;
            PName = ProdName;
            Price = ProdPrice;
        } 
    
   
        static void Main()
        {

        List<Product> Products = new List<Product>();
            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("Enter the ProductID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Product Name:");
                string Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Price");
                double price = Convert.ToDouble(Console.ReadLine());

                Products.Add(new Product(Id, Name, price));
            }
            var sorteditems = Products.OrderBy(pro => pro.Price).ToList();

            Console.WriteLine("Products are sorted by Price:");
            foreach (var product in sorteditems)
            {
                Console.WriteLine($" Product ID: {product.Pid}, Product Name: {product.PName}, Product Price: {product.Price}");
            }

               Console.Read();
        }
        }
    
}
