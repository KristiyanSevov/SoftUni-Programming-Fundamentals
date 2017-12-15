using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int regions = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < regions; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                double coefficient = double.Parse(inputs[0]) / int.Parse(inputs[1]);
                sum += coefficient;
            }
            Console.WriteLine("{0:f3}", density != 0 ? sum/density : sum);
        }
    }
}
