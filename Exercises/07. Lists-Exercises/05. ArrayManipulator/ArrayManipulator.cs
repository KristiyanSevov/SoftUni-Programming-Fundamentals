using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] cmds = Console.ReadLine().Split(' ');
            while (cmds[0] != "print")
            {
                if (cmds[0] == "add")
                {
                    nums.Insert(int.Parse(cmds[1]), int.Parse(cmds[2]));
                }
                else if (cmds[0] == "addMany")
                {
                    nums.InsertRange(int.Parse(cmds[1]), cmds.Skip(2).Select(int.Parse));
                }
                else if (cmds[0] == "contains")
                {
                    Console.WriteLine(nums.IndexOf(int.Parse(cmds[1])));
                }
                else if (cmds[0] == "remove")
                {
                    nums.RemoveAt(int.Parse(cmds[1]));
                }
                else if (cmds[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(cmds[1]); i++)
                    {
                        LeftRotateOnce(nums);
                    }
                }
                else if (cmds[0] == "sumPairs")
                {
                    SumPairs(nums);
                }
                cmds = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        private static void SumPairs(List<int> nums)
        {
            for (int i = 0; i < nums.Count-1; i++)
            {
                nums[i] += nums[i + 1];
                nums.RemoveAt(i + 1);
            }
        }

        private static void LeftRotateOnce(List<int> nums)
        {
            var temp = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                nums[i - 1] = nums[i];
            }
            nums[nums.Count - 1] = temp;
        }
    }
}
