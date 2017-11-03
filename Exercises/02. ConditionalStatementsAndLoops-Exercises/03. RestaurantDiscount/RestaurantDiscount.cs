using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall;
            int price;
            decimal discount;
            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                discount = 0.95m;
                price += 500;
            }
            else if (package == "Gold")
            {
                discount = 0.9m;
                price += 750;
            }
            else
            {
                discount = 0.85m;
                price += 1000;
            }

            decimal finalPrice = price * discount;
            decimal pricePerPerson = finalPrice / groupSize;

            Console.WriteLine("We can offer you the {0}", hall);
            Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
        }
    }
}
