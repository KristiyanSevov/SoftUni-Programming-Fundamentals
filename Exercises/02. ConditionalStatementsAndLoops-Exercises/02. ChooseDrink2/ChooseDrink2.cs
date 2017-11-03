using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseDrink2
{
    class ChooseDrink2
    {
        static void Main()
        {
            string prof = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price;

            if (prof == "Athlete")
            {
                price = quantity * 0.7m;
            }
            else if (prof == "Businessman" || prof == "Businesswoman")
            {
                price = quantity * 1.00m;
            }
            else if (prof == "SoftUni Student")
            {
                price = quantity * 1.7m;
            }
            else
	        {
                price = quantity * 1.2m;
            }

            Console.WriteLine("The {0} has to pay {1:f2}.", prof, price);
        }
    }
}
