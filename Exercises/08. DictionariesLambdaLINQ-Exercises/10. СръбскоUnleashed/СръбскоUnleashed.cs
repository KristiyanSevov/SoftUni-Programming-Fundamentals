using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.СръбскоUnleashed
{
    class СръбскоUnleashed
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var venues = new Dictionary<string, Dictionary<string, int>>();
            while (input != "End")
            {
                if (!TestInput(input, out string nums, out string venue))
                {
                    input = Console.ReadLine();
                    continue;
                }
                string[] inputs = input.Split('@');
                string singer = inputs[0].Remove(inputs[0].Length - 1);
                string[] prices = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int revenue = int.Parse(prices[0]) * int.Parse(prices[1]);

                if (!venues.ContainsKey(venue))
                {
                    venues.Add(venue, new Dictionary<string, int>());
                }
                if (!venues[venue].ContainsKey(singer))
                {
                    venues[venue].Add(singer, revenue);
                }
                else
                {
                    venues[venue][singer] += revenue;
                }
                input = Console.ReadLine();
            }
            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }

        private static bool TestInput(string input, out string nums
                                                    , out string venue)
        {
            string[] inputs = input.Split('@');
            nums = string.Empty;
            venue = string.Empty;

            if (!inputs[0].EndsWith(" "))
            {
                return false;
            }
            StringBuilder reversed = new StringBuilder();
            for (int i = inputs[1].Length-1; i >= 0; i--)
            {
                if (char.IsDigit(inputs[1][i]) || inputs[1][i] == ' ')
                {
                    reversed.Append(inputs[1][i]);
                    if (reversed.ToString().Count(x => x == ' ') == 2)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            if (!reversed.ToString().EndsWith(" "))
            {
                return false;
            }
            nums = String.Join("", reversed.ToString().Reverse().ToArray());
            venue = inputs[1].Substring(0, inputs[1].Length - reversed.Length);
            return true;
        }
    }
}
