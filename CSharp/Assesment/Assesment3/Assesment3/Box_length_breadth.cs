using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
    internal class Box_length_breadth
   
        {
            public int Length { get; set; }
            public int Breadth { get; set; }

            public Box_length_breadth(int len, int brd)
            {
                Length = len;
                Breadth = brd;
            }

            public static Box_length_breadth AddBoxes(Box_length_breadth b1, Box_length_breadth b2)
            {
                int newl = b1.Length + b2.Length;
                int newb = b1.Breadth + b2.Breadth;
                return new Box_length_breadth(newl, newb);
            }

            public void view()
            {
                Console.WriteLine($" Length:{Length}, Breadth : {Breadth}");
            }
        }

        class TestCase
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Box 1 values:");
                Console.Write("Enter Length for Box 1: ");
                int box1len = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Breadth for Box 1: ");
                int box1brd = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Box 2 values:");
                Console.Write("Enter Length for Box 2: ");
                int box2len = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Breadth for Box 2: ");
                int box2brd = Convert.ToInt32(Console.ReadLine());

                Box_length_breadth Box1 = new Box_length_breadth(box1len, box1brd);
                Box_length_breadth Box2 = new Box_length_breadth(box2len, box2brd);

                Console.WriteLine("1st box");
                Box1.view();

                Console.WriteLine("2nd box");
                Box2.view();

                Box_length_breadth Box3 = Box_length_breadth.AddBoxes(Box1, Box2);

                Console.WriteLine("3rd Box");
                Box3.view();

                Console.ReadLine();
            }
        }
    }
