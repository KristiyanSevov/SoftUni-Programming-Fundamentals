using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());

            int totalRunners = Math.Min(length*capacity, runners);
            long totalMeters = totalRunners * laps * lapLength;
            long totalKm = totalMeters / 1000;
            decimal totalMoney = totalKm * money;
            Console.WriteLine("Money raised: {0:f2}", totalMoney);
        }
    }
}
