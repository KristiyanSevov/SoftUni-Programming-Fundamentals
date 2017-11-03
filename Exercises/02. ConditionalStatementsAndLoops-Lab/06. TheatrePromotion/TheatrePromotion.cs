using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main()
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int teenager = 0;
            int adult = 0;
            int old = 0;

            switch (day)
            {
                case "Weekday":
                    teenager = 12;
                    adult = 18;
                    old = 12;
                    break;
                case "Weekend":
                    teenager = 15;
                    adult = 20;
                    old = 15;
                    break;
                case "Holiday":
                    teenager = 5;
                    adult = 12;
                    old = 10;
                    break;
            }

            if (age >= 0 && age <= 18)
            {
                Console.WriteLine($"{teenager}$");
            }
            else if (age > 18 && age <= 64)
            {
                Console.WriteLine($"{adult}$");
            }
            else if (age > 64 && age <= 122)
            {
                Console.WriteLine($"{old}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
