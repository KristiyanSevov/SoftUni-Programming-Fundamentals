using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyContent = energy * volume / 100.0;
            double sugarContent = sugar * volume / 100.0;
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyContent, sugarContent);
        }
    }
}