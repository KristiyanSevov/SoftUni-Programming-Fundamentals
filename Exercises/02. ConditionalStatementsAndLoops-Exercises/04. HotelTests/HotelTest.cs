using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HotelTests
{
    class HotelTest
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceST = 0;
            double priceDO = 0;
            double priceSU = 0;

            if (month == "May" || month == "October")
            {
                priceST = 50 * nights;
                priceDO = 65 * nights;
                priceSU = 75 * nights;

                if (nights > 7 && month == "October")
                {
                    priceST = priceST - 50;
                }

                if (nights > 7)
                {
                    priceST = priceST * 0.95;
                }

                
            }

            else if (month == "June" || month == "September")
            {
                priceST = 60 * nights;
                priceDO = 72 * nights;
                priceSU = 82 * nights;

                if (nights > 7 && month == "September")
                {
                    priceST = priceST - 60;
                }

                if (nights > 14)
                {
                    priceDO = priceDO * 0.9;
                }

                
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                priceST = 68 * nights;
                priceDO = 77 * nights;
                priceSU = 89 * nights;

                if (nights > 14)
                {
                    priceSU = priceSU * 0.85;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.", priceST);
            Console.WriteLine("Double: {0:f2} lv.", priceDO);
            Console.WriteLine("Suite: {0:f2} lv.", priceSU);
        }
    }
}
