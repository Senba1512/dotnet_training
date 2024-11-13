using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assesment2
{
    public abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;


        public abstract bool IsPassed(double grade);
    }


    public class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }


    public class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Undergraduate undergrad = new Undergraduate();
            Graduate grad = new Graduate();


            Console.WriteLine("Enter UG Student Details:");
            Console.Write("Name: ");
            undergrad.Name = Console.ReadLine();
            Console.Write("Student ID: ");
            undergrad.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade: ");
            undergrad.Grade = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Graduate Student Details:");
            Console.Write("Name: ");
            grad.Name = Console.ReadLine();
            Console.Write("Student ID: ");
            grad.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade: ");
            grad.Grade = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"{undergrad.Name}  Passed: {undergrad.IsPassed(undergrad.Grade)}");
            Console.WriteLine($"{grad.Name} Passed: {grad.IsPassed(grad.Grade)}");


            Console.WriteLine("Test with new grades:");
            Console.Write("Enter new grade for UG student: ");
            undergrad.Grade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter new grade for Graduate student: ");
            grad.Grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{undergrad.Name} Passed: {undergrad.IsPassed(undergrad.Grade)}");
            Console.WriteLine($"{grad.Name} Passed: {grad.IsPassed(grad.Grade)}");

            Console.ReadLine();
        }
    }
}