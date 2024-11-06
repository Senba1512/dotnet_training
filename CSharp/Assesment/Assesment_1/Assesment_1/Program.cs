using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1
{
    internal class Program
    {
        static void Char()
        {

            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the Position number need to be removed from the string:");
            int num = int.Parse(Console.ReadLine());
            if (num < 0 || num >= s.Length)
            {
                Console.WriteLine("Invalid Position");
            }
            string n= s.Remove(num,1);
            Console.WriteLine(n);
        }



        // exchange first and last characters 
        static void exchange()
        {
            
            Console.Write("Enter the string: ");
            string w = Console.ReadLine();

            
            if (w.Length < 2)
            {
                Console.WriteLine("The Perform exchange operation,need atleast 2 letters");
                return;
            }

            
            char Char1 = w[0];
            char Char2 = w[w.Length - 1];

            
            string w2 = Char2 + w.Substring(1, w.Length - 2) + Char1;

            
            Console.WriteLine("After exchange:" +w2 );
        }



        //larger number

        static void number()
        {
            Console.WriteLine("Enter 1st number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number:");
            int n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 || n1 > n3)
            {
                Console.WriteLine(n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n3);
            }

        }




        //occurance of character
        static void Occurance()
        {
            
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();

            
            Console.Write("Enter the character to count: ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            
            int count = 0;
            foreach (char c in word)
            {
                if (c == letter)
                {
                    count++;
                }
            }

            Console.WriteLine($"The character '{letter}' appears {count} times in the string.");
        }
    
    static void Main(String[] args)
        {
            Console.WriteLine("To remove the Char from a string");
            Char();
                Console.WriteLine("Largest number:");
                number();
            Console.WriteLine("Exchanging Characters");
            exchange();
            Console.WriteLine("Occurance of Character");
            Occurance();
            Console.ReadLine();

        }
    }
}
