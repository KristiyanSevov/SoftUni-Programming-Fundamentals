using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string match = Console.ReadLine().ToLower();
            int counter = 0;
            int index = -1;
            while (true)
            {
                index = text.IndexOf(match, index + 1);
                if (index != -1)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
