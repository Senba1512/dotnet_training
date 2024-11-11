using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Dotnet
{
     class Generics
    {
        static void ListEg()
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(789);
            lst.Add(34);
            List<string> lst2 = new List<string>();
            lst2.Add("Senba");
            lst2.Add("infinite");
        }
    
    }

    class Employee
    {
        int Empid;
        string EmpName;
        float Salary;
        string Company;

        public Employee(int id,string name,float sal,string comp)
        {
            Empid = id;
            EmpName = name;
            Salary = sal;
            Company = comp;
        }
        List<Employee> emplist = new List<Employee>();
        //emplist.Add(new Employee(200,"Nikil",50000,"Infinit"));
    }
}
