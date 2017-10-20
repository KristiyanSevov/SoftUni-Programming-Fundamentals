using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] arr = new bool[n + 1];
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    Console.Write("{0} ", i);
                    for (int j = i; j < arr.Length; j += i) //try j*j
                    {
                        arr[j] = false;
                    }
                }
            }
        }
    }
}
