using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{

    public class NameException : Exception
    {
        public NameException(string message) : base(message)
        {

        }
    }
    class exception
    {
        public static void nameEx()
        {
            try
            {
                Console.WriteLine("Enter the name:");
                string n = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(n))
                {
                    throw new NameException("Name Cannot be empty");
                }
                else
                {
                    string UpperName = n.ToUpper();
                    Console.WriteLine("Name in uppercase:" + UpperName);
                }
            }
            catch (NameException nx)
            {
                Console.WriteLine("Error:" + nx.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name Exceptions");
            exception.nameEx();
            Console.ReadLine();
        }


    }
}

