using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            List<int> foldedArray = new List<int>();
            foreach (var num in arr.Take(k).Reverse())
            {
                foldedArray.Add(num);
            }
            foreach (var num in arr.Reverse().Take(k))
            {
                foldedArray.Add(num);
            }
            int[] remaining = arr.Skip(k).Take(k * 2).ToArray();
            int[] result = new int[arr.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = foldedArray[i] + remaining[i];
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
