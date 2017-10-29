using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                string command = inputs[0];
                if (command == "exchange")
                {
                    int index = int.Parse(inputs[1]);
                    if (index < 0 || index >= nums.Count)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    var split = nums.Skip(index+1).ToList();
                    nums.RemoveRange(index + 1, nums.Count - index - 1);
                    nums.InsertRange(0, split);
                }
                else if (command == "max")
                {
                    string type = inputs[1];
                    if (type == "even" && nums.Where(x => x % 2 == 0).Count() != 0)
                    {
                        Console.WriteLine(nums.LastIndexOf(nums.Where(x => x % 2 == 0).Max()));
                    }
                    else if (type == "odd" && nums.Where(x => x % 2 != 0).Count() != 0)
                    {
                        Console.WriteLine(nums.LastIndexOf(nums.Where(x => x % 2 != 0).Max()));
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (command == "min")
                {
                    string type = inputs[1];
                    if (type == "even" && nums.Where(x => x % 2 == 0).Count() != 0)
                    {
                        Console.WriteLine(nums.LastIndexOf(nums.Where(x => x % 2 == 0).Min()));
                    }
                    else if (type == "odd" && nums.Where(x => x % 2 != 0).Count() != 0)
                    {
                        Console.WriteLine(nums.LastIndexOf(nums.Where(x => x % 2 != 0).Min()));
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(inputs[1]);
                    if (count < 0 || count > nums.Count)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }
                    string type = inputs[2];
                    if (type == "even")
                    {
                        Console.WriteLine("[{0}]", String.Join(", ", nums.Where(x => x % 2 == 0).Take(count)));
                    }
                    else if (type == "odd")
                    {
                        Console.WriteLine("[{0}]", String.Join(", ", nums.Where(x => x % 2 != 0).Take(count)));
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(inputs[1]);
                    if (count < 0 || count > nums.Count)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }
                    string type = inputs[2];
                    if (type == "even")
                    {
                        Console.WriteLine("[{0}]", String.Join(", ", nums
                            .Where(x => x % 2 == 0)
                            .Skip(nums.Where(x => x % 2 == 0).Count() - count)));
                    }
                    else if (type == "odd")
                    {
                        Console.WriteLine("[{0}]", String.Join(", ", nums
                            .Where(x => x % 2 != 0)
                            .Skip(nums.Where(x => x % 2 != 0).Count() - count)));
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", String.Join(", ", nums));
        }
    }
}
