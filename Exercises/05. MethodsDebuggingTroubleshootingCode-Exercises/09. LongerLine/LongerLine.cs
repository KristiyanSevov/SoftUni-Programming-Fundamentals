using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongerLine
{
    class Program
    {
        static void Main()
        {
            double fX1 = double.Parse(Console.ReadLine());
            double fY1 = double.Parse(Console.ReadLine());
            double fX2 = double.Parse(Console.ReadLine());
            double fY2 = double.Parse(Console.ReadLine());
            double sX1 = double.Parse(Console.ReadLine());
            double sY1 = double.Parse(Console.ReadLine());
            double sX2 = double.Parse(Console.ReadLine());
            double sY2 = double.Parse(Console.ReadLine());

            string longer = LongerLength(fX1, fY1, fX2, fY2, sX1, sY1, sX2, sY2);
            if (longer == "first")
            {
                string closestPoint = FindClosest(fX1, fY1, fX2, fY2);
                if (closestPoint == "first")
                {
                    Console.WriteLine($"({fX1}, {fY1})({fX2}, {fY2})");
                }
                else
                {
                    Console.WriteLine($"({fX2}, {fY2})({fX1}, {fY1})");
                }
            }
            else
            {
                string closestPoint = FindClosest(sX1, sY1, sX2, sY2);
                if (closestPoint == "first")
                {
                    Console.WriteLine($"({sX1}, {sY1})({sX2}, {sY2})");
                }
                else
                {
                    Console.WriteLine($"({sX2}, {sY2})({sX1}, {sY1})");
                }
            }

        }

        private static string LongerLength(double fX1, double fY1, double fX2, double fY2,
            double sX1, double sY1, double sX2, double sY2)
        {
            double firstLength = Math.Sqrt((fX2 - fX1) * (fX2 - fX1) + (fY2 - fY1) * (fY2 - fY1));
            double secondLength = Math.Sqrt((sX2 - sX1) * (sX2 - sX1) + (sY2 - sY1) * (sY2 - sY1));
            if (firstLength >= secondLength)
            {
                return "first";
            }
            else
            {
                return "second";
            }
        }

        private static string FindClosest(double x1, double y1, double x2, double y2)
        {
            double firstDistance = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondDistance = Math.Sqrt(x2 * x2 + y2 * y2);
            if (firstDistance <= secondDistance)
            {
                return "first";
            }
            else
            {
                return "second";
            }
        }
    }
}