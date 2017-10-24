using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = Console.ReadLine().Split(':');
            long hours = long.Parse(times[0]);
            int minutes = int.Parse(times[1]);
            int seconds = int.Parse(times[2]);
            int steps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());

            BigInteger secondsWalked = (BigInteger)steps * secondsPerStep;
            BigInteger secondsLeft = secondsWalked % 60;
            secondsWalked /= 60;
            BigInteger minutesLeft = secondsWalked % 60;
            secondsWalked /= 60;
            BigInteger hoursLeft = secondsWalked % 24;
            seconds += (int)secondsLeft;
            if (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            minutes += (int)minutesLeft;
            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }
            hours += (long)hoursLeft;
            if (hours >= 24)
            {
                hours = hours % 24;
            }
            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", hours, minutes, seconds);
        }
    }
}
