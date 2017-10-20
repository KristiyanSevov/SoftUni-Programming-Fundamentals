using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    class TripleSum
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool existsTriple = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    int num = arr[i] + arr[j];
                    if (arr.Contains(num))
                    {
                        Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], num);
                        existsTriple = true;
                    }
                }
            }
            if (!existsTriple)
            {
                Console.WriteLine("No");
            }
        }
    }
}
