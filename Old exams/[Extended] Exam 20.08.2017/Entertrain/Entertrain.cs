using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();
            string input = Console.ReadLine();
            while (input != "All ofboard!")
            {
                int wagon = int.Parse(input);
                wagons.Add(wagon);
                if (wagons.Sum() > power)
                {
                    double average = wagons.Average();
                    double closest = double.MaxValue;
                    int result = 0;
                    foreach (var num in wagons)
                    {
                        if (Math.Abs(num - average) < closest)
                        {
                            closest = Math.Abs(num - average);
                            result = num;
                        }
                    }
                    wagons.Remove(result);
                }
                input = Console.ReadLine();
            }
            wagons.Reverse();
            wagons.Add(power);
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
