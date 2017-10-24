using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main()
        {
            {
                int power = int.Parse(Console.ReadLine());
                int distance = int.Parse(Console.ReadLine());
                int exhaustion = int.Parse(Console.ReadLine());
                int counter = 0;
                int powerOriginal = power;

                while (power >= distance)
                {
                    power -= distance;
                    counter++;
                    if (exhaustion != 0)
                    {
                        if (power == powerOriginal * 0.5)
                        {
                            power = power / exhaustion;
                        }
                    }
                }
                Console.WriteLine(power);
                Console.WriteLine(counter);
            }
        }
    }
}
