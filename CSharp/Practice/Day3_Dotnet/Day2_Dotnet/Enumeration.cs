using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    enum cities
    {
        Agra,Bangalore,Chennai,Hyerabad,Kerala,karnataka
    }
    internal class Enumeration
    {
        enum Days { Mon,Tue,wed,Thur,Fri,Sat,Sun}
     
        public static void EnumOps()
        {
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                if (x == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities), x)+ " "+ "is a beautiful place");
                else if (x==2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + "is a Wonderful place");
                else if(x==3)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + "is a Nice place");

            }
            foreach(var v in Enum.GetNames(typeof(cities))){
                Console.WriteLine(v);
            }
            int wks = (int)Days.Mon;
            int wke = (int)Days.Tue;

        }

    }
}
