using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string first = inputs[0];
            string second = inputs[1];
            Console.WriteLine(Exchangable(first, second).ToString().ToLower());
        }

        private static bool Exchangable(string first, string second)
        {
            if (first.ToCharArray().Distinct().Count() == second.ToCharArray().Distinct().Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
