using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main()
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');
            Point firstPoint = new Point();
            firstPoint.X = int.Parse(first[0]);
            firstPoint.Y = int.Parse(first[1]);
            Point secondPoint = new Point();
            secondPoint.X = int.Parse(second[0]);
            secondPoint.Y = int.Parse(second[1]);
            Console.WriteLine("{0:f3}", CalculateDistance(firstPoint, secondPoint));
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(firstPoint.X - secondPoint.X), 2) +
                Math.Pow(Math.Abs(firstPoint.Y - secondPoint.Y), 2));
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
