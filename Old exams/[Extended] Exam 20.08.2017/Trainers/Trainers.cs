using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal technical = 0;
            decimal theoretical = 0;
            decimal practical = 0;
            for (int i = 0; i < n; i++)
            {
                int distance = int.Parse(Console.ReadLine());
                decimal cargo = decimal.Parse(Console.ReadLine());
                string team = Console.ReadLine();
                decimal money = cargo * 1000m * 1.5m - 0.7m * distance * 1600m * 2.5m;
                if (team == "Technical")
                {
                    technical += money;
                }
                else if (team == "Practical")
                {
                    practical += money;
                }
                else if (team == "Theoretical")
                {
                    theoretical += money;
                }
            }
            string winner;
            decimal final;
            if (theoretical > Math.Max(practical, technical))
            {
                winner = "Theoretical";
                final = theoretical;
            }
            else if (practical > Math.Max(theoretical, technical))
            {
                winner = "Practical";
                final = practical;
            }
            else
            {
                winner = "Technical";
                final = technical;
            }
            Console.WriteLine("The {0} Trainers win with ${1:f3}.", winner, final);
        }
    }
}
