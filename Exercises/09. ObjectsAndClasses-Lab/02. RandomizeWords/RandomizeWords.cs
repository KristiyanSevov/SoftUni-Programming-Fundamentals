using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
    }
}
