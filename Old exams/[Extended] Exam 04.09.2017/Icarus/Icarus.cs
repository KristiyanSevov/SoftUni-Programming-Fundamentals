using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int damage = 1;
            while (input != "Supernova")
            {
                string[] inputs = input.Split(' ');
                string direction = inputs[0];
                int steps = int.Parse(inputs[1]);
                if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (index + 1 < nums.Count)
                        {
                            index++;
                        }
                        else
                        {
                            index = 0;
                            damage++;
                        }
                        nums[index] -= damage;
                    }
                }
                else if (direction == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (index - 1 >= 0)
                        {
                            index--;
                        }
                        else
                        {
                            index = nums.Count - 1;
                            damage++;
                        }
                        nums[index] -= damage;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
