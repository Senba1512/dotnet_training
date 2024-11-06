using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static  void length()
        {
            Console.Write("Enter the String:");
            string l = Console.ReadLine();
            int count=0;
            Console.WriteLine(l.Length);

        }
        static void reverse()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            Console.WriteLine(rev);
        }


        static void samestring()
        {
            Console.WriteLine("Enter the first word:");
            string w1 = Console.ReadLine();
            Console.WriteLine("Enter the second word:");
            string w2 = Console.ReadLine();

            if (w1 == w2)
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Both are not same");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("The Length of a String is");
            length();
            Console.WriteLine("The Reverse of a String:");
            reverse();
            Console.WriteLine("To check whether the string is equal or not");
            samestring();


            Console.ReadLine();
        }
    }
}
