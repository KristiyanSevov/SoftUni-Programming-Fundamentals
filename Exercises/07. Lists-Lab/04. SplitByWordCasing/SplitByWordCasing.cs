using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' },
                                                                 StringSplitOptions.RemoveEmptyEntries);

            List<string> LowerCase = new List<string>();
            List<string> UpperCase = new List<string>();
            List<string> Mixed = new List<string>();

            foreach (var word in words)
            {
                int countLower = 0;
                int countUpper = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        countUpper++;
                    }
                    else if (char.IsLower(word[i]))
                    {
                        countLower++;
                    }
                }
                if (countUpper == word.Length)
                {
                    UpperCase.Add(word);
                }
                else if (countLower == word.Length)
                {
                    LowerCase.Add(word);
                }
                else
                {
                    Mixed.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", String.Join(", ", LowerCase));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", Mixed));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", UpperCase));
        }
    }
}
