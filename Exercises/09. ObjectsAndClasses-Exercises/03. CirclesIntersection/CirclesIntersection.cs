using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    class Test
    {
        static void Main()
        {
            Circle firstCircle = ReadCircle();
            Circle secondCircle = ReadCircle();
            bool result = CircleIntersect(firstCircle, secondCircle);
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool CircleIntersect(Circle firstCircle, Circle secondCircle)
        {

            double distance = Math.Sqrt(Math.Pow(firstCircle.point.X - secondCircle.point.X, 2) + 
                                        Math.Pow(firstCircle.point.Y - secondCircle.point.Y, 2));
            if (distance <= firstCircle.radius + secondCircle.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static Circle ReadCircle()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point point = new Point() { X = input[0], Y = input[1] };
            Circle circle = new Circle() { point = point, radius = input[2] };
            return circle;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public class Circle
    {
        public Point point { get; set; }
        public double radius { get; set; }
    }
}
