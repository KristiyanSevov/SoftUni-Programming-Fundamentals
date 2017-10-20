using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
	    string[] input = Console.ReadLine().Split(':');
            
            Dictionary<char, int> values = new Dictionary<char, int>
            {
                {'2', 2}, {'3', 3}, {'4', 4}, {'5', 5}, {'6', 6},
                {'7', 7}, {'8', 8}, {'9', 9}, {'T', 10},
                {'J', 11}, {'Q', 12}, {'K', 13}, {'A', 14},
                {'S', 4}, {'H', 3}, {'D', 2}, {'C', 1}
            };
            var results = new Dictionary<string, Dictionary<string,int>>();

            while (input[0] != "JOKER")
            {
                string name = input[0];
                if (input[1].Contains("10"))
                {
                    input[1] = input[1].Replace("10", "T");
                }
                string[] cards = input[1].Split(new char[] { ',', ' ' },
                                 StringSplitOptions.RemoveEmptyEntries);
               
                if (!results.ContainsKey(name))
                {
                    results.Add(name, new Dictionary<string, int>());
                }
                foreach (var card in cards)
                {
                    if (!results[name].ContainsKey(card))
                    {
                        results[name].Add(card, values[card[0]] * values[card[1]]);
                    }
                }
                input = Console.ReadLine().Split(':');
            }
            foreach (var pair in results)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value.Values.Sum());
            }
        }
    }
}
