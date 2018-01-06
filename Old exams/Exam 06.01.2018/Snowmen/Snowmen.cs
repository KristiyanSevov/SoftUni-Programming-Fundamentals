using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> losers = new HashSet<int>();
            List<int> snowmen = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (snowmen.Count > 1)
            {
                for (int attacker = 0; attacker < snowmen.Count; attacker++)
                {
                    if (!losers.Contains(attacker))
                    {
                        int target = snowmen[attacker];
                        target = target >= snowmen.Count ? target % snowmen.Count : target;
                        if (attacker == target)
                        {
                            Console.WriteLine("{0} performed harakiri", attacker);
                            losers.Add(attacker);
                        }
                        else if (Math.Abs(attacker - target) % 2 == 0)
                        {
                            Console.WriteLine("{0} x {1} -> {0} wins", attacker, target);
                            losers.Add(target);
                        }
                        else
                        {
                            Console.WriteLine("{0} x {1} -> {1} wins", attacker, target);
                            losers.Add(attacker);
                        }

                        if (snowmen.Count - losers.Count == 1)
                        {
                            return;
                        }
                    }
                }
                foreach (var index in losers)
                {
                    snowmen[index] = -1;
                }
                losers.Clear();
                snowmen = snowmen.Where(x => x != -1).ToList();
            }  
        }
    }
}
