using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var results = new SortedDictionary<double, int>();

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
            foreach (var num in results)
            {
                Console.WriteLine("{0} -> {1}", num.Key, num.Value);
            }
        }
    }
}
