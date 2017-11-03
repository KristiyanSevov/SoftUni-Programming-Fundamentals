using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloName
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}