using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            int skip = int.Parse(nums[0]);
            int take = int.Parse(nums[1]);
            string[] inputs = Regex.Split(Console.ReadLine(), @"\|<").Skip(1).ToArray();
            List<string> results = new List<string>();
            foreach (var pic in inputs)
            {
                if (pic.Length > skip)
                {
                    string photo = String.Join("", pic.Skip(skip).Take(Math.Min(take, pic.Length-skip)));
                    results.Add(photo);
                }
            }
            Console.WriteLine(String.Join(", ", results));
        }
    }
}
