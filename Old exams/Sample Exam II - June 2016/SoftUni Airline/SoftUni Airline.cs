using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            int flights = int.Parse(Console.ReadLine());
            decimal overallProfit = 0;
            for (int i = 0; i < flights; i++)
            {
                int adults = int.Parse(Console.ReadLine());
                decimal adultPrice = decimal.Parse(Console.ReadLine());
                int young = int.Parse(Console.ReadLine());
                decimal youngPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = adults * adultPrice + young * youngPrice;
                decimal expenses = fuelPrice * fuelConsumption * flightDuration;
                if (income >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", income - expenses);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", income - expenses);
                }
                overallProfit += income - expenses;
            }
            Console.WriteLine("Overall profit -> {0:f3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:f3}$.", overallProfit / flights);
        }
    }
}
