using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            var scores = new SortedDictionary<string, long>();
            var goals = new SortedDictionary<string, long>();
            while (input != "final")
            {
                int keyIndex = input.IndexOf(key);
                int nextKey = input.IndexOf(key, keyIndex + key.Length);
                string firstTeam = input.Substring(keyIndex + key.Length, nextKey - key.Length - keyIndex).ToUpper();
                firstTeam = string.Join("", firstTeam.Reverse());
                int thirdKey = input.IndexOf(key, nextKey + key.Length);
                int lastKey = input.IndexOf(key, thirdKey + key.Length);
                string secondTeam = input.Substring(thirdKey + key.Length, lastKey - key.Length - thirdKey).ToUpper();
                secondTeam = string.Join("", secondTeam.Reverse());
                string[] inputs = input.Split(' ');
                string[] results = inputs.Last().Split(':');
                int firstScore = int.Parse(results[0]);
                int secondScore = int.Parse(results[1]);
                if (!scores.ContainsKey(firstTeam))
                {
                    scores.Add(firstTeam, 0);
                }
                if (!scores.ContainsKey(secondTeam))
                {
                    scores.Add(secondTeam, 0);
                }
                if (firstScore > secondScore)
                {
                    scores[firstTeam] += 3;
                }
                else if (firstScore < secondScore)
                {
                    scores[secondTeam] += 3;
                }
                else
                {
                    scores[firstTeam] += 1;
                    scores[secondTeam] += 1;
                }
                if (!goals.ContainsKey(firstTeam))
                {
                    goals.Add(firstTeam, 0);
                }
                if (!goals.ContainsKey(secondTeam))
                {
                    goals.Add(secondTeam, 0);
                }
                goals[firstTeam] += firstScore;
                goals[secondTeam] += secondScore;

                input = Console.ReadLine();
            }
            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var team in scores.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0}. {1} {2}", place, team.Key, team.Value);
                place += 1;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in goals.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
            }
        }
    }
}
