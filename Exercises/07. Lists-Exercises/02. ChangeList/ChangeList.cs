using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    nums.RemoveAll(x => x == element);
                }
                else if (command[0] == "Insert")
                {
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split(' ');
            }
            if (command[0] == "Odd")
            {
                foreach (var num in nums)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write("{0} ", num);
                    }
                }
            }
            else
            {
                foreach (var num in nums)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write("{0} ", num);
                    }
                }
            }
        } 
    }
}
