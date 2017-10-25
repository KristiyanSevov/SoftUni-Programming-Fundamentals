using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string first = inputs[0];
            string second = inputs[1];
            Console.WriteLine(Multiply(first, second));
        }

        private static int Multiply(string first, string second)
        {
            string bigger = first.Length >= second.Length ? first : second;
            int sum = 0;
            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                sum += first[i] * second[i];
            }
            for (int i = Math.Min(first.Length, second.Length); i < bigger.Length; i++)
            {
                sum += bigger[i];
            }
            return sum;
        }
    }
}
