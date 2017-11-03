using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubeProperties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
            {
                Console.WriteLine("{0:f2}", CubeFace(side));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:f2}", CubeSpace(side));
            }
            else if (parameter == "volume")
            {
                Console.WriteLine("{0:f2}", CubeVolume(side));
            }
            else if (parameter == "area")
            {
                Console.WriteLine("{0:f2}", CubeArea(side));
            }
        }

        private static double CubeArea(double side)
        {
            return 6 * side * side;
        }

        private static double CubeVolume(double side)
        {
            return side * side * side;
        }

        private static double CubeSpace(double side)
        {
            return Math.Sqrt(CubeFace(side) * CubeFace(side) + side * side);
        }

        private static double CubeFace(double side)
        {
            return Math.Sqrt(side * side + side * side);
        }
    }
}