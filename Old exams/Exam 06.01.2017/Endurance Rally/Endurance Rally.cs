using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            string[] track = Console.ReadLine().Split(' ');
            List<string> checkpoints = Console.ReadLine().Split(' ').ToList();

            foreach (var driver in names)
            {
                double fuel = driver[0];
                bool reachedEnd = true;
                for (int i = 0; i < track.Length; i++)
                {
                    if (checkpoints.Contains(i.ToString()))
                    {
                        fuel += double.Parse(track[i]);
                    }
                    else
                    {
                        fuel -= double.Parse(track[i]);
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", driver, i);
                        reachedEnd = false;
                        break;
                    }
                }
                if (reachedEnd)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", driver, fuel);
                }
            }
        }
    }
}
