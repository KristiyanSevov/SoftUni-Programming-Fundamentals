using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hornet_Assault
{
    class Program
    {
        static void Main()
        {
            List<int> hives = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> hornets = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());

            long sum = 0;
            foreach (var num in hornets)
            {
                sum += num;
            }
            for (int i = 0; i < hives.Count; i++)
            {
                bool removed = false;

                if (sum >= hives[i])
                {
                    removed = true;
                }
                if (sum <= hives[i] && hornets.Count > 0)
                {
                    hives[i] = hives[i] - (int)sum;
                    sum -= hornets[0];
                    hornets.RemoveAt(0);
                }
                if (removed)
                {
                    hives.RemoveAt(i);
                    i--;
                }
            }
            if (hives.Count > 0)
            {
                Console.WriteLine(String.Join(" ", hives));
            }
            else
            {
                Console.WriteLine(String.Join(" ", hornets));
            }
        }
    }
}
