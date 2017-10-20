using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            char[] arr = new char[26];
            int index = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                arr[index] = i;
                index++;
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", word[i], 
                                   Array.IndexOf(arr, word[i]));
            }
        }
    }
}
