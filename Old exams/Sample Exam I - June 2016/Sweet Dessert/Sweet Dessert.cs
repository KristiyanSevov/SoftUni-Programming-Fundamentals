using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());

            int portions = guests % 6 == 0 ? guests / 6 : guests / 6 + 1;
            decimal sum = portions * 2 * priceBananas + portions * 4 * priceEggs + portions * 0.2m * priceBerries;
            if (sum <= money)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", sum);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", sum - money);
            }
        }
    }
}