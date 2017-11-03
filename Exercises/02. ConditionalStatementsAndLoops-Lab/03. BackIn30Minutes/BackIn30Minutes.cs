using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;
            if (mins > 59)
            {
                mins -= 60;
                hours++;
                if (hours > 23)
                {
                    hours -= 24;
                }
            }
            Console.WriteLine("{0}:{1:d2}", hours, mins);
        }
    }
}
