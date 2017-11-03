using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGround
{
    class Test
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.Write("Health: |");
            Console.Write("{0}", new string('|', currentHealth));
            Console.Write("{0}", new string('.', maxHealth - currentHealth));
            Console.WriteLine('|');

            Console.Write("Energy: |");
            Console.Write("{0}", new string('|', currentEnergy));
            Console.Write("{0}", new string('.', maxEnergy - currentEnergy));
            Console.WriteLine('|');
        }
    }
}