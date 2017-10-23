using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(string.Join("", s.ToCharArray().Reverse().ToArray()));
        }
    }
}
