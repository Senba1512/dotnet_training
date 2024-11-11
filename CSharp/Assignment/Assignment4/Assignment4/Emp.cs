using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Emp
    
    {
        
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        
        public Emp(int empid, string empname, float salary)
        {
            Empid = empid;
            Empname = empname;
            Salary = salary;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee ID: {Empid}");
            Console.WriteLine($"Employee Name: {Empname}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    
    public class ParttimeEmployee : Emp
    {
        
        public float Wages { get; set; }

        
        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary) 
        {
            Wages = wages;
        }

        
        public override void Display()
        {
            base.Display(); 
            Console.WriteLine($"Wages: {Wages}");
        }
    }

   
    public class Eprogram
    {
        public static void Main()
        {
           
            ParttimeEmployee parttimeEmployee = new ParttimeEmployee(101, "Alice Smith", 5000.0f, 1200.0f);

           
            Console.WriteLine("Part-Time Employee Details:");
            parttimeEmployee.Display();
            Console.Read();
        }
    }
}
