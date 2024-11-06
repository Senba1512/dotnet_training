using Day2_Dotnet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day2_Dotnet
{
    internal class Program
    {
        //if else 
        public void CheckGrade()
        {
            char grade;
            Console.WriteLine("Enter your Grade:");
            grade = Convert.ToChar(Console.ReadLine());

            if (grade == 'O' || grade == 'o')
                Console.WriteLine("Outstanding");
            else if (grade == 'A' || grade == 'a')
                Console.WriteLine("Excellent");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine(" Need Improvement");
            else
                Console.WriteLine("Invalid");

               
        }
    //swtich
    public void Checkswitch() {
            char grade;
        Console.WriteLine("Enter Your Grade:");
        grade=Convert.ToChar(Console.ReadLine());

        switch(grade)
            {
            case 'O':
            case 'o':
                Console.WriteLine("Outstanding");
                break;
            case 'A':
            case 'a':
                 Console.WriteLine("Excellent");
                 break;
             case 'B':
             case 'b':
                    Console.WriteLine("Very Good");
                    break;
             case 'C':
             case 'c':
                    Console.WriteLine("Need improvement");
                    break;

            default:
                Console.WriteLine("Invalid");
                break;
            }
    }
}
      class Loops
    {
        public void Forloop()
        {
            int total = 0;
            for(int i = 0; i <= 7; i++)
            {
                total += i;
                Console.WriteLine(total);
            }
        }
        public void whileloop()
        {
             int i = 1;
            while (i < 10)
            {
                Console.WriteLine(i);
                i= i + 2;
            }

        }
    }
        class Decision
        {
            static void Main(string[] args)
            {
        Program sc = new Program();
        sc.CheckGrade();
        sc.Checkswitch();
       


         Loops loop = new Loops();
         loop.Forloop();
         loop.whileloop();
         Console.ReadLine();
        }
        }
    }

