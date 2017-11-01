using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());
                decimal totalPrice = DateTime.DaysInMonth(date.Year, date.Month) * capsules * price;
                Console.WriteLine("The price for the coffee is: ${0:f2}", totalPrice);
                total += totalPrice;
            }
            Console.WriteLine("Total: ${0:f2}", total);
        }
    }
}