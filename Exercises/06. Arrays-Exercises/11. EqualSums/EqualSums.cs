using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSums
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Take(i).Sum() == arr.Skip(i+1).Sum())
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
