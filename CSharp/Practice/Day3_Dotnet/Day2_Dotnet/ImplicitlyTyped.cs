using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    internal class ImplicitlyTyped
    {
        public void Implicittypes()
        {
            int x;
            x = 55;
            float f = 985.998f;

            var v1 = 5932.349;//declare and assign at same time

            dynamic d;   //reference type
            d = 2;
            d = 546.2;
            d = "hi all";
            var myanonymoustype = new { data1 = "CSharp",
                data2 = 5,
                data3 = true};

            Console.WriteLine(myanonymoustype.data3+" "+myanonymoustype.data2);
        }

        class Implicit
        {
            public static void Main(string[] args)
            {
                ImplicitlyTyped It = new ImplicitlyTyped();
                It.Implicittypes();
                Console.WriteLine(It);
            }
        }
    }
}
