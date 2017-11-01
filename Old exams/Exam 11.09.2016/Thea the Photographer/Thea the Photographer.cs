using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int photos = int.Parse(Console.ReadLine());
            BigInteger seconds = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            BigInteger uploadSeconds = int.Parse(Console.ReadLine());

            int filteredPics = (int)Math.Ceiling(photos*(filterFactor/100.0));
            BigInteger totalTime = photos * seconds + filteredPics * uploadSeconds;
            int sec = (int)(totalTime % 60);
            totalTime /= 60;
            int min = (int)(totalTime % 60);
            totalTime /= 60;
            int hr = (int)(totalTime % 24);
            BigInteger days = totalTime /= 24;
            Console.WriteLine("{0}:{1:d2}:{2:d2}:{3:d2}", days, hr, min, sec);
        }
    }
}
