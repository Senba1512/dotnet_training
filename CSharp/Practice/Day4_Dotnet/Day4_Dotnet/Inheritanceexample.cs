using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class student
    {
        private string RollNo;
        private string Name;
        private string Class;


        public void GetData()
        {
            Console.WriteLine("Enter Roll No:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class:");
            Class = Console.ReadLine();
        }
        public void PutData()
        {
            Console.WriteLine("Name of the Student:{0}", Name);
            Console.WriteLine("Roll No:{0}", RollNo);
            Console.WriteLine("Class of the student:{0}", Class);
        }
        class Marks : student
        {
            protected int[] scores = new int[5];
            public void getMarks()
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine("ENter Subject{0} Marks", i + 1);
                    scores[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            public void putMarks()
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine("Marks in subject{0}:{1}", i + 1, scores[i]);
                }
            }
        }
        class Results : Marks
        {
            int TotalMarks = 0;
            public void GetResults()
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    TotalMarks = TotalMarks + scores[i];
                }
            }
            public void DisplayResults()
            {
                Console.WriteLine("___________Results________");
                PutData();
                putMarks();
                Console.WriteLine("Total Marks :{0}", TotalMarks);
            }

        }
        internal class Inheritanceexample
        {

            static void Main(string[] args)
            {
                Results results = new Results();
                results.GetData();
                results.getMarks();
                results.GetResults();
                results.DisplayResults();
                Console.ReadKey();
            }
        }
    }
}