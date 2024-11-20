using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
    internal class Score
    
        {
            public void PointCount(int MatchCount)
            {
                List<int> Points = new List<int>();


                for (int i = 0; i < MatchCount; i++)
                {

                    Console.WriteLine($"Match Score {i + 1} : ");
                    int score = Convert.ToInt32(Console.ReadLine());
                    Points.Add(score);

                }


                Console.WriteLine("Total Score: {0} ", Points.Sum());
                Console.WriteLine("Average Score : {0}", Points.Average());
            }

        }
        class CricketMatch
        {
            static void Main(string[] args)
            {
                int Match;
                Console.Write("Enter the no. of matches : ");
                Match = Convert.ToInt32(Console.ReadLine());
                Score cricket = new Score();
                cricket.PointCount(Match);
                Console.ReadLine();

            }
        }
    }

