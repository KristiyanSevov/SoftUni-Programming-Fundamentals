using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PriceChangeAlert
{
    class PriceChangeAlert
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double previous = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double change = FindChange(previous, price);

                bool isSignificantDifference = IsDifference(change, threshold);
                string message = GetChangeMessage(price, previous, change, isSignificantDifference);
                Console.WriteLine(message);
                previous = price;
            }
        }

        static string GetChangeMessage(double price, double previous, double change, bool isSignificant)
        {
            string message = "";
            if (change == 0)
            {
                message = string.Format("NO CHANGE: {0}", price);
            }
            else if (!isSignificant)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previous, price, change*100);
            }
            else if (isSignificant && (change > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previous, price, change*100);
            }
            else if (isSignificant && (change < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previous, price, change*100);
            return message;
        }

        static bool IsDifference(double change, double threshold)
        {
            if (Math.Abs(change) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static double FindChange(double previous, double price)
        {
            double change = (price - previous) / previous;
            return change;
        }
    }
}
