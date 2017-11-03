using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            seconds += hours * 3600;
            seconds += minutes * 60;

            float metersPerSecond = (float)(meters / (double)(seconds));
            float kilometersPerHour = (float)((meters/1000.0) / (seconds/3600.0));
            float milesPerHour = (float)((meters/1609.0) / (seconds/3600.0));

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
