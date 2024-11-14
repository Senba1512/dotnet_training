using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment5
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            string Path = "Result.txt";

            try
            {
                string[] arr = File.ReadAllLines(Path);
                Console.WriteLine($"The file contains {arr.Length} lines.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.Read();
        }
    }
}
