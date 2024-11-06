using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Practice
{
     class Program
    {
        
        
            public static int Calculator(int a, int b, out int sum, out int product,out int Division)
            {
                sum = a + b;  //addition
                product = a * b;  //multiplication
                Division = a / b;// Division
                return a - b; // difference
                
            }
        public int Addelements(params int[] arr)
        {
            int sum= 0;
            foreach(int i in arr){
                sum += i;
            }
            return sum;
        }
       static void Main(string[] args) { 
          

            int Total, Prod, Difference,Division;

            Difference = Program.Calculator(12, 6, out Total, out Prod,out Division);
            Console.WriteLine("Sum = {0} Product = {1},Difference = {2} Division ={3}", Total, Prod, Difference,Division);
            Console.Read();
          }
        
    }
}
