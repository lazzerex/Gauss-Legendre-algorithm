using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussLegendre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of iterations (more iterations give more precision): ");
            if (int.TryParse(Console.ReadLine(), out int iterations) && iterations > 0)
            {
                double pi = CalculatePi(iterations);
                Console.WriteLine($"Pi calculated to approximately {iterations * 2} decimal places: ");
                Console.WriteLine(pi);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            Console.ReadLine();
        }

        static double CalculatePi(int iterations)
        {
            // Initial values setting
            double a = 1.0;
            double b = 1.0 / Math.Sqrt(2);
            double t = 0.25;
            double p = 1.0;

            for (int i = 0; i < iterations; i++)
            {
                double aNext = (a + b) / 2;
                double bNext = Math.Sqrt(a * b);
                double tNext = t - p * Math.Pow(a - aNext, 2);
                double pNext = 2 * p;

                a = aNext;
                b = bNext;
                t = tNext;
                p = pNext;
            }

            // Calculate pi
            double pi = Math.Pow(a + b, 2) / (4 * t);

            return pi;
        }
    }
}

