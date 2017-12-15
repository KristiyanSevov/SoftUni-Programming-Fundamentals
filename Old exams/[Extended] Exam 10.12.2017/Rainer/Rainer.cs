using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = sequence.Last();
            List<int> field = sequence.Take(sequence.Count - 1).ToList();
            int steps = 0;
            while (true)
            {
                for (int i = 0; i < field.Count; i++)
                {
                    field[i]--;
                }
                if (field[index] == 0)
                {
                    Console.WriteLine(string.Join(" ", field));
                    Console.WriteLine(steps);
                    return;
                }
                for (int i = 0; i < field.Count; i++)
                {
                    if (field[i] == 0)
                    {
                        field[i] = sequence[i];
                    }
                }
                index = int.Parse(Console.ReadLine());
                steps += 1;
            }
        }
    }
}
