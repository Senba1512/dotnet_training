using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Number
    {
        static void Main(string[] args)
        {
            int[] num = { 7, 2, 30 };

            var sq = num
                .Where(n => n*n > 20)
                .Select(n => new { Number = n, Square = n * n });
                
            foreach(var n in sq)
            {
                Console.WriteLine("Number and its square greater than 20" + n);
            }
            Console.Read();
        }
    }
}
