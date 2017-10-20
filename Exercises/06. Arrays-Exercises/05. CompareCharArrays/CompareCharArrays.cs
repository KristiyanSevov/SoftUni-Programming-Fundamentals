using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        public static void Main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            if (s1.CompareTo(s2) <= 0)
            {
                Console.WriteLine(string.Join("", s1.Split(' ')));
                Console.WriteLine(string.Join("", s2.Split(' ')));
            }
            else
            {
                Console.WriteLine(string.Join("", s2.Split(' ')));
                Console.WriteLine(string.Join("", s1.Split(' ')));
            }

        }
    }
}
