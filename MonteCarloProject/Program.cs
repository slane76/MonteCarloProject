using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MonteCarloProject
{
    struct MonteCarloExercise
    {
        //public double x;
        //public double y;

        static double MonteCarlo(int n)
        {
            //int[] myXArray;
            //int[] myYArray;

            //Random myXArray = new Random();
            //Random myYArray = new Random();

            int pointsOnTarget = 0;
            Random random = new Random();


            for (int i = 0; i < n; i++)
            {
                if (Math.Pow(random.NextDouble(), 2) + Math.Pow(random.NextDouble(), 2) <= 1)
                {
                    pointsOnTarget++;
                }
            }

            return 4.0 * pointsOnTarget / n;
        }

        static void Main(string[] args)
        {
            double truePI = 3.141592653589793;
            int value = 1;
            for (int n = 0; n < 7; n++)
            {
                var watch = new Stopwatch();
                watch.Start();
                value *= 10;
                Console.WriteLine($"Your number of plotted points equals: {value}");
                Console.WriteLine("{0}"  + " " + "is your running value.", MonteCarlo(value));
                Console.WriteLine($"The difference between your value and True PI is: {truePI - MonteCarlo(value)}");
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                watch.Stop();
                Console.WriteLine("=================================================================================================");
            }
        }
    }
}
    


