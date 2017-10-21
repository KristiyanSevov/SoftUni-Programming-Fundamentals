using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ').Select(x => x.ToLower()).ToArray();
            var results = new Dictionary<string, int>();

            foreach (var item in arr)
            {
                if (!results.ContainsKey(item))
                {
                    results.Add(item, 1);
                }
                else
                {
                    results[item]++;
                }
            }
            string s = String.Empty;
            foreach (var num in results)
            {
                if (num.Value % 2 != 0)
                {
                    s += num.Key + ", ";
                }
            }
            s = s.Remove(s.Length - 2);
            Console.WriteLine(s);
        }
    }
}
