using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hornet_Wings
{
    class Program
    {
        static void Main()
        {
            int flaps = int.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double totalDistance = distanceM * (flaps / 1000.0);
            int seconds = flaps / 100;
            int rest = flaps / endurance * 5;
            seconds += rest;
            Console.WriteLine("{0:f2} m.", totalDistance);
            Console.WriteLine("{0} s.", seconds);
        }
    }
}
