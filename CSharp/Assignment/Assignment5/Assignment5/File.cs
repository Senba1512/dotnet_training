using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5
{
    class FileCreation
    {
        static void Main(string[] args)
        {
            string[] arrstr = new string[]
            {
            "Hi",
            "I'm senbagam",
            "Doing C# Assignment",
          
            };

            string Path = "Result.txt";

            try
            {
                File.WriteAllLines(Path, arrstr);
                Console.WriteLine("File has been created and strings are written in the file");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.Read();
        }
    }
}