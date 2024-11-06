using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Dotnet
{
    internal class Array
    {
        public void TwoDimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(myarray[1, 1]);
            //we can use loops for assigning and retrieving values from an array
            //1st loop to iterate the rows
            for (int i = 0; i < 2; i++)
            {
                //loop 2 for column iteration within a row
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(myarray[i, j] + " ");
                }
                Console.WriteLine();
            } }

            public void jaggedAray()
            {
            //array of 2 rows
            int[][] jag = new int[2][];//1st square bracket refers to the rows
                                       //2nd refers to the columns of the rows
                                       //set the size for each row
            jag[0] = new int[3];
            jag[1] = new int[2];

            //initialise the array

            jag[0][0] = 2;
            jag[0][1] = 4;
            jag[0][2] = 9;

            jag[1][0] = 5;
            jag[1][1] = 7;
            jag[1][2] = 9;


            //another way
            int[][] jagg = { new int[] {5,10,15,20},
            new int[]{67,77},
            new int[]{35,90,32}};


            //to print the elements of the jagged array

            for(int i = 0; i < jag.Length; i++)
            {
                Console.WriteLine("Number of Elements ar Row: " + i + "is " + jagg[i].Length);

                //inner loop
                for(int j = 0; j < jagg[i].Length; j++)
                {
                    
                }
            }

            }
        }
        class Array2{ 
            public static void Main()
            {
                Array ar = new Array();
                
                
            }
        }
    } 

