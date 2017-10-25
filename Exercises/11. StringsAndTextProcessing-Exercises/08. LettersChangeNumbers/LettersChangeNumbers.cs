using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()
			.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
			.Select(x => x.Trim()).ToArray();
            double sum = 0;
            foreach (var input in inputs)
            {
                double num = double.Parse(input.Substring(1, input.Length - 2));
                if (char.IsUpper(input[0]))
                {
                    num /= input[0] - 64;
                }
                else
                {
                    num *= input[0] - 96;
                }
                if (char.IsUpper(input[input.Length - 1]))
                {
                    num -= input[input.Length - 1] - 64;
                }
                else
                {
                    num += input[input.Length - 1] - 96;
                }
                sum += num;
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
