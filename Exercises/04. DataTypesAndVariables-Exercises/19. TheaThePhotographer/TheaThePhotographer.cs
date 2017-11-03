using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            long totalPictures = long.Parse(Console.ReadLine());
            long filterSeconds = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadSeconds = long.Parse(Console.ReadLine());

            long filteredPictures = (long)Math.Ceiling((double)totalPictures * filterFactor/100);
            long totalSeconds = totalPictures * filterSeconds;

            totalSeconds += filteredPictures * uploadSeconds;

            long seconds = totalSeconds % 60;
            totalSeconds /= 60;
            long minutes = totalSeconds % 60;
            totalSeconds /= 60;
            long hours = totalSeconds % 24;
            totalSeconds /= 24;
            long days = totalSeconds;
            Console.WriteLine("{0}:{1:d02}:{2:d02}:{3:d02}", days, hours, minutes, seconds);
        }
    }
}
