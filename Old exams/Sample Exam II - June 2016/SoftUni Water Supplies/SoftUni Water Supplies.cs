using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args) 
        {
            double water = double.Parse(Console.ReadLine());
            List<double> bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double capacity = double.Parse(Console.ReadLine());
            double waterNeeded = 0;
            List<int> indices = new List<int>();
            if (water % 2 == 0)
            {
                int index = 0;
                while (water > 0 && index < bottles.Count)
                {
                    water -= capacity - bottles[index];
                    index++;
                }
                if (water < 0)
                {
                    indices.Add(index - 1);
                }
                waterNeeded -= water;
                while (index < bottles.Count)
                {
                    waterNeeded += capacity - bottles[index];
                    indices.Add(index);
                    index++;
                }
            }
            else
            {
                int index = bottles.Count-1;
                while (water > 0 && index >= 0)
                {
                    water -= capacity - bottles[index];
                    index--;
                }
                if (water < 0)
                {
                    indices.Add(index+1);
                }
                waterNeeded -= water;
                while (index >= 0)
                {
                    waterNeeded += capacity - bottles[index];
                    indices.Add(index);
                    index--;
                }
            }
            if (water >= 0 && indices.Count == 0) //checking for cases where we fill a bottle and water becomes 0
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine("Water left: {0}l.", water);
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", indices.Count);
                Console.WriteLine("With indexes: {0}", string.Join(", ", indices));
                Console.WriteLine("We need {0} more liters!", waterNeeded);
            }
        }
    }
}
