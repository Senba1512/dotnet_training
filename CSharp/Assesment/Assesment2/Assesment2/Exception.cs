using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    internal class Exception
    {
     static void Number(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Negative number!");
            }
            else
            {
                Console.WriteLine("The Positive Number:" + num);
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Number:");
                int num = Convert.ToInt32(Console.ReadLine());
                Number(num);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
