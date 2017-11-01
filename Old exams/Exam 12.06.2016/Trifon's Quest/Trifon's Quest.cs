using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifon_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            long health = int.Parse(Console.ReadLine());
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string[] map = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                map[i] = Console.ReadLine();
            }
            int rowIndex = 0;
            int colIndex = 0;
            int turns = 0;
            while (true)
            {
                if (map[rowIndex][colIndex] == 'F') 
                { 
                    health -= turns / 2;
                }
                else if (map[rowIndex][colIndex] == 'H')
                {
                    health += turns / 3;
                }
                else if (map[rowIndex][colIndex] == 'T')
                {
                    turns += 2;
                }
                if (health <= 0)
                {
                    Console.WriteLine("Died at: [{0}, {1}]", rowIndex, colIndex);
                    break;
                }
                turns += 1;
                if (cols % 2 == 0 && rowIndex == 0 && colIndex == cols - 1 ||
                    cols % 2 != 0 && rowIndex == map.Length - 1 && colIndex == cols - 1)
                {
                    Console.WriteLine("Quest completed!");
                    Console.WriteLine("Health: {0}", health);
                    Console.WriteLine("Turns: {0}", turns);
                    break;
                }
                if (rowIndex == map.Length - 1 && colIndex % 2 == 0 ||
                    rowIndex == 0 && colIndex % 2 != 0)
                {
                    colIndex += 1;
                }
                else
                {
                    if (colIndex % 2 == 0)
                    {
                        rowIndex += 1;
                    }
                    else
                    {
                        rowIndex -= 1;
                    }
                }
            }
        }
    }
}
