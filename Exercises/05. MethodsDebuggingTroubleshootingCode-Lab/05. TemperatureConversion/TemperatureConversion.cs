using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(n);
            Console.WriteLine("{0:f2}", celsius);
        }

        static double FahrenheitToCelsius(double n)
        {
            double celsius = (n - 32) * 5 / 9;
            return celsius;
        }
    }
}
