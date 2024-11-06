using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Marks
    {  
        private int RollNo;
        private string Name;
        private string StudentClass;
        private string Semester;
        private string Branch;
        private int[] marks = new int[5];

        
        public Marks(int RollNo, string Name, string StudentClass, string Semester, string Branch)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.StudentClass = StudentClass;
            this.Semester = Semester;
            this.Branch = Branch;
        }

        
        public void GetMarks()
        {
            Console.WriteLine("Enter marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        
        public void Result()
        {
            double total = 0;
            bool Fail = false;

            
            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    Fail = true;
                    break;
                }
                total += mark;
            }

            double average = total / marks.Length;

            if (Fail)
            {
                Console.WriteLine("Result: Failed (One or more subjects have marks less than 35)");
            }
            else if (average < 50)
            {
                Console.WriteLine("Result: Failed (Average marks less than 50)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        
        public void Data()
        {
            Console.WriteLine("----------------------Student Details-------------------------");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {StudentClass}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine("Marks: " + string.Join(", ", marks));
            Console.Read();
        }
    }

    class Stu
    {
        static void Main()
        {
            
            Console.Write("Enter Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Class: ");
            string studentClass = Console.ReadLine();

            Console.Write("Enter Semester: ");
            string semester = Console.ReadLine();

            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();

            
            Marks student = new Marks(rollNo, name, studentClass, semester, branch);

            
            student.GetMarks();
            student.Result();
            student.Data();

        }
    }
}
