using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Marks
    {  // Data members
        private int rollNo;
        private string name;
        private string studentClass;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        // Constructor to initialize student details
        public Marks(int rollNo, string name, string studentClass, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.studentClass = studentClass;
            this.semester = semester;
            this.branch = branch;
        }

        
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        
        public void DisplayResult()
        {
            double total = 0;
            bool hasFailedSubject = false;

            
            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    hasFailedSubject = true;
                    break;
                }
                total += mark;
            }

            double average = total / marks.Length;

            if (hasFailedSubject)
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

        
        public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {studentClass}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
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
            student.DisplayResult();
            student.DisplayData();

        }
    }
}
