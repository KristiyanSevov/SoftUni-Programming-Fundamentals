using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenterPoint
{
    class Program
    {
        static void Main()
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            PrintClosest(X1, Y1, X2, Y2);
        }

        private static void PrintClosest(double x1, double y1, double x2, double y2)
        {
            double firstDistance = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondDistance = Math.Sqrt(x2 * x2 + y2 * y2);
            if (firstDistance <= secondDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}