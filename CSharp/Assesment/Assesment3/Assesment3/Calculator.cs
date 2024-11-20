using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
    public delegate int Number(int m,int n);
   public class Calculator
    {
        static int ans = 0;
        public  int Addition(int m,int n)
        {
             ans=m+n;
            return ans;
        }
        public int Subtraction(int m, int n)
        {
            ans = m - n;
            return ans;
        }
        public int Multiplication(int m, int n)
        {
            ans = m * n;
            return ans;
        }
        static void Main(string[] args)
        {
              Calculator Display = new Calculator();
            Number sum = new Number(Display.Addition);
            Number diff= new Number(Display.Subtraction);
            Number prod = new Number(Display.Multiplication);
            Console.WriteLine("Enter the numbers");
            Console.Write("Enter the 1 st input : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd input : ");
            int n2 = int.Parse(Console.ReadLine());
            int add = sum(n1, n2);
            Console.WriteLine("Addition: " + add);
            int sub = diff(n1, n2);
            Console.WriteLine("Subtraction: " + sub);
            int mul = prod(n1, n2);
            Console.WriteLine("Multiplication " + mul);
            Console.ReadLine();

        }
    }
}
