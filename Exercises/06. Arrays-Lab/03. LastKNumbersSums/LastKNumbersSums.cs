using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSums
{
    class LastKNumbersSums
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                long sum = 0;
                if (i-k > 0)
                {
                    for (int j = i-k ; j < i; j++)
                    {
                        sum += arr[j];
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += arr[j];
                    }
                }
                arr[i] = sum;
            }
            foreach (var num in arr)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
