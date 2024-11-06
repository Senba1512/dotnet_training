using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{class Customer
    {
        public Customer()
        {
            Console.WriteLine("Customer Constructor 1...");
        }
        public Customer(int a):this()
        {
            Console.WriteLine("Customer Constructor 2..");
        }
        public Customer(string s,int x):this()
        {
            Console.WriteLine("Customer Constructor 3..");
        }
    }
    internal class Constructor_types
    {static void Main()
        {
            Customer c1 = new Customer();
            Console.Read();
        }
    }
}
