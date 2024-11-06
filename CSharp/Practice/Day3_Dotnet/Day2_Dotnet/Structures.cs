using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    struct Student
    {
        public float mathsmarks;
        public float sciencemarks;
    }
    internal class Structures
    {
        static void Main() 
        { 
         Student s1 =  new Student();
            s1.mathsmarks = 98.44f;
            s1.sciencemarks = 80.77f;
            Console.WriteLine(s1.mathsmarks + s1.sciencemarks);

            Student s2 = s1; //assigning s1 mark to s2
            Console.WriteLine(s2.mathsmarks + s2.sciencemarks);

            s1.mathsmarks = 99.7f;
            Console.WriteLine(s1.mathsmarks + s1.sciencemarks);
            Console.WriteLine(s2.mathsmarks + s2.sciencemarks);
            Console.Read();
        
        
        }
    }
}
