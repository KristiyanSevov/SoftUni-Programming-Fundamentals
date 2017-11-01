using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                string command = inputs[0];
                if (command == "swap")
                {
                    int firstIndex = int.Parse(inputs[1]);
                    int secondIndex = int.Parse(inputs[2]);
                    long temp = nums[secondIndex];
                    nums[secondIndex] = nums[firstIndex];
                    nums[firstIndex] = temp;
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(inputs[1]);
                    int secondIndex = int.Parse(inputs[2]);
                    nums[firstIndex] = nums[firstIndex] * nums[secondIndex];
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums[i]--;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
