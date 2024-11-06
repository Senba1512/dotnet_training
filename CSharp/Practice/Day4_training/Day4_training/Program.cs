using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day4_training
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "abc";
            //Console.WriteLine(str);
            StringOps();
            Console.Read();
        }
        public static void StringOps() {
            string s = "Hello";
            Console.WriteLine("s for the first time is:{0}",s.GetHashCode());
            //strings are immutable
            string s1 = "CSharp";
            Console.WriteLine("S1 is at :{0} ",s1.GetHashCode());
            Console.WriteLine(s1);
            string s2 = s1;  //reference of s1 is assigned to s2 

            Console.WriteLine("S2 is at :{0}", s2.GetHashCode());
            Console.WriteLine(s2);

            string s3 = "Hello";
            Console.WriteLine("S3 is at :{0}",s3.GetHashCode());
            Console.WriteLine(s3);

            //checking by instantiating a string object
            char[] car = new char[] { 'H', 'E', 'L', 'L', 'O' };
            string s4 = new string(car);
            Console.WriteLine("S4's hash code is {0}", s4.GetHashCode());

            Console.WriteLine("---------String Builder--------");

            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("sb's hasg code is {0}", sb.GetHashCode());
            sb.Append("CSharp from Microsoft");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);



        }
    }
} 
