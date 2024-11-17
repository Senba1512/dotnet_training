using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class TravelConcessionlibrary
    {
        private const int Fare = 2000;
        public static void CalculateConcession(string name,int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Free Ticket for children below age 5");
            }
            else if (age > 60)
            {
                double discount =  0.30 * Fare;
                Console.WriteLine($"Discount for senior citizen {discount} from original price");
            }
            else
            {
                Console.WriteLine($"Total Fare {Fare}");
            }
        }
    }

    class Details
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Name:");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter your Age:");
            int age;
            while(!int.TryParse(Console.ReadLine(),out age) || age < 0)
            {
                Console.WriteLine("Invalid Input");
            }
            TravelConcessionlibrary.CalculateConcession(name, age);

            Console.ReadLine();
        }
    }
}

