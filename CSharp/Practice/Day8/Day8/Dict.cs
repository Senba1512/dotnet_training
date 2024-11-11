using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Dict
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "green");
            d.Add(2, "pink");
            d.Add(3, "blue");
            foreach (int item in d.Keys)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("----------");
            foreach (string item in d.Values)
            {
                Console.WriteLine(item);
            }
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine(kvp.Key + " ");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }
            Console.WriteLine("Enter the Id to get the color:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (d.ContainsKey(c))
            {
                Console.Write(c + " represents" + d[c]);
            }
            else
            {
                Console.WriteLine("Enter a valid Id ");
            }
            SortedList<string, string> s1 = new SortedList<string, string>();
            s1.Add("sql", "DB");
            s1.Add("React", "Framework");
            foreach(string s in s1.Keys)
            {
                Console.WriteLine(s);
            }
        }
    }
}
