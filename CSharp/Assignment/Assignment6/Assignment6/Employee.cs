using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public int EmpSalary { get; set; }

       
    }
    class query
    {
        static void Main()
        {

            List<Employee> Emplist = new List<Employee>()
            {
                new Employee{EmpID=001,EmpName="Sai",EmpCity="Delhi",EmpSalary= 45345},
                new Employee{EmpID=002,EmpName="Saara",EmpCity="Mumbai",EmpSalary= 47566},
                new Employee{EmpID=003,EmpName="Krish",EmpCity="Kerala",EmpSalary= 33345},
                new Employee{EmpID=004,EmpName="Anish",EmpCity="Bangalore",EmpSalary= 19005},
            };

            var  e =from Emp in Emplist
                    select Emp;

            var s = from sal in Emplist
                    where sal.EmpSalary > 45000
                    select sal;
            var c = from city in Emplist
                    where city.EmpCity == "Bangalore"
                    select city;


            IEnumerable<Employee> sortbyname = Emplist.OrderBy(n => n.EmpName);

           

            Console.WriteLine("------------All Employee details-----------");
            foreach(var x in e)
            {
                Console.WriteLine($"\nEmpId:{x.EmpID}, EmpName:{x.EmpName}, EmpCity:{x.EmpCity}, EmpSalary:{x.EmpSalary}");
            }


            Console.WriteLine("____________________Employee Details whose salary is greater than 45000_________________");
            foreach (var salary in s)
            {
                Console.WriteLine($"\nEmpId:{salary.EmpID}, EmpName:{salary.EmpName}, EmpCity:{salary.EmpCity}, EmpSalary:{salary.EmpSalary}");
            }



            Console.WriteLine("_________________Employee Belongs to bangalore Region________________");
            foreach (var city in c)
            {
                Console.WriteLine($"\nEmpId:{city.EmpID}, EmpName:{city.EmpName}, EmpCity:{city.EmpCity}, EmpSalary:{city.EmpSalary}");
            }

            Console.WriteLine("=====================Employee Name sorted in Ascending order=================");
            foreach (var name in sortbyname)
            {
                Console.WriteLine($"\n EmpId:{name.EmpID}, EmpName:{name.EmpName}, EmpCity:{name.EmpCity}, EmpSalary:{name.EmpSalary}");
            }
            Console.Read();
        }
    }
}