using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split('|');
            List<int> result = new List<int>();

            for (int i = arr.Length-1; i >= 0; i--)
            {
                result.AddRange(arr[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            foreach (var num in result)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
