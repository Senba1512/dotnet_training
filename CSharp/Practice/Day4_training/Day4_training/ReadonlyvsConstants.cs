using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_training
{
    internal class ReadonlyvsConstants
    {
        //readonly fields
        readonly int myvar1 = 5;
        readonly int myvar2;
        float f;

        //create constructor

        public ReadonlyvsConstants(int a,int b) {
            Console.WriteLine(myvar1 + " " + myvar2);
            myvar1 = a;
            myvar2 = b;
            Console.WriteLine(myvar1 + " " + myvar2);

        }
        static void Main()
        {
            ReadonlyvsConstants rc = new ReadonlyvsConstants(10,20);
            Console.Read();
        }


    }
}
