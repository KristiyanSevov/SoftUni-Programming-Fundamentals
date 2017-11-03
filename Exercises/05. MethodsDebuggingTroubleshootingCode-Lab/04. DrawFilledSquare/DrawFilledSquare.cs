using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopAndBottom(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintTopAndBottom(n);
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n-1; i++)
            {
                Console.Write('\\');
                Console.Write('/');
            }
            Console.WriteLine('-');
        }

        static void PrintTopAndBottom(int n)
        {
            Console.WriteLine(new string('-', n*2));
        }
    }
}
