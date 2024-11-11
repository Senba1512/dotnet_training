using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
    internal class cexception
    {

        static int maxint = 2147483647;

        public static int CheckOverFlow()
        {
            int a = 0;
            try
            {
                a = checked(maxint + 10);
            }
            catch (System.OverflowException ofe)
            {
                Console.WriteLine("Checked:" + " " + ofe.ToString());
            }
            return a;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Checked and unchecked exceptions");
            cexception.CheckOverFlow();
            Console.ReadLine();

        }
    }
}
