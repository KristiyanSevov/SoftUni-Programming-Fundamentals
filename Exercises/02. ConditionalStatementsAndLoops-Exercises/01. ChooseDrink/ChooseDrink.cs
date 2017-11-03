using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseDrink
{
    class ChooseDrink
    {
        static void Main()
        {
            string prof = Console.ReadLine();
            string drink;

            if (prof == "Athlete")
            {
                drink = "Water";
            }
            else if (prof == "Businessman" || prof == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (prof == "SoftUni Student")
            {
                drink = "Beer";
            }
            else
	        {
                drink = "Tea";
            }

            Console.WriteLine(drink);
        }
    }
}
