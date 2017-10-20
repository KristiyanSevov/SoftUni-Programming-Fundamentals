using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (var num in arr.Reverse())
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
