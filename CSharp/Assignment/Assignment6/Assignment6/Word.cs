using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Word
    {
        static void Main() { 
        List<string> w = new List<string> { "num", "amsterdam", "bloom" };

        var s = w
               .Where(x=> x.StartsWith("a") && x.EndsWith("m"));

            Console.WriteLine("Words start with 'a' and ending with 'm':");
            foreach(var x in s)
            {
                Console.WriteLine(x);
            }
            Console.Read();
    }
    }
}
