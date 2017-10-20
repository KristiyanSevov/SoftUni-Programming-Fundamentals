using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestCount = 0;
            int value = arr[0];
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    value = arr[i];
                }
                counter = 0;
            }
            Console.WriteLine(value);
        }
    }
}
