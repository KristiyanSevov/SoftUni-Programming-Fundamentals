using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(", ", words.Where(x => IsPalindrome(x)).Distinct().OrderBy(x => x)));
        }

        private static bool IsPalindrome(string s)
        {
            bool isPal = true;
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length-1-i])
                {
                    isPal = false;
                    break;
                }
            }
            return isPal;
        }
    }
}
