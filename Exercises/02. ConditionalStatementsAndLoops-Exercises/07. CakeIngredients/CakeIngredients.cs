using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            int num = 0;
            for (;;)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", num);
                    return;
                }
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                num++;
            }
        }
    }
}
