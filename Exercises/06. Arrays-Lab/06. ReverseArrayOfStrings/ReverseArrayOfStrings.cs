using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length/2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            foreach (var s in arr)
            {
                Console.Write("{0} ", s);
            }
        }
    }
}
