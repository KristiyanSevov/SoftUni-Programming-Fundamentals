using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
            dynamic a;
            dynamic b;
            if (type == "int")
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            else if (type == "char")
            {
                a = char.Parse(Console.ReadLine());
                b = char.Parse(Console.ReadLine());
            }
            else
            {
                a = Console.ReadLine();
                b = Console.ReadLine();
            }
            Console.WriteLine(GetMax(a, b));
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static char GetMax(char a, char b)
        {
            return (char)Math.Max(a, b);
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) <= 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
