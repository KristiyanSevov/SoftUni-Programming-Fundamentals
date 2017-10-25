using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Point point = readPoint();
                points[i] = point;
            }
            double minDistance = double.MaxValue;
            Point[] result = new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        result[0] = points[i];
                        result[1] = points[j];
                    }
                }
            }
            Console.WriteLine("{0:f3}", minDistance);
            Console.WriteLine("({0}, {1})", result[0].X, result[0].Y);
            Console.WriteLine("({0}, {1})", result[1].X, result[1].Y);
        }

        private static Point readPoint()
        {
            string[] input = Console.ReadLine().Split(' ');
            Point point = new Point() { X = int.Parse(input[0]), Y = int.Parse(input[1]) };
            return point;
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
