using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Sales
    {
        class Saledetails
        {
            private int SalesNo;
            private int ProductNo;
            private double Price;
            private DateTime DateOfSale;
            private int Qty;
            private double TotalAmount;

          
            public Saledetails(int SalesNo, int ProductNo, double Price, int Qty, DateTime DateOfSale)
            {
                this.SalesNo = SalesNo;
                this.ProductNo = ProductNo;
                this.Price = Price;
                this.Qty = Qty;
                this.DateOfSale = DateOfSale;
                Sales(); 
            }

           
            public void Sales()
            {
                TotalAmount = Qty * Price;
            }

            
            public void ShowData()
            {
                Console.WriteLine("------------Sale Details------------");
                Console.WriteLine($"Sales No: {SalesNo}");
                Console.WriteLine($"Product No: {ProductNo}");
                Console.WriteLine($"Price: {Price :Rs.}"); 
                Console.WriteLine($"Quantity: {Qty}");
                Console.WriteLine($"Date of Sale: {DateOfSale:dd/MM/yyyy}");
                Console.WriteLine($"Total Amount: {TotalAmount :Rs.}"); 
                Console.Read();
            }
        }

        class Product
        {
            static void Main()
            {

                Console.Write("Enter Sales No: ");
                int salesNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Product No: ");
                int productNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Enter Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                Console.Write("Enter Date of Sale (yyyy-mm-dd): ");
                DateTime dateOfSale = DateTime.Parse(Console.ReadLine());


                Saledetails sale = new Saledetails(salesNo, productNo, price, qty, dateOfSale);
                sale.ShowData();
            }
        }
    }
}