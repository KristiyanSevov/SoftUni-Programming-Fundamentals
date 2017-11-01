using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] matrix = new string[n];
            int rowIndex = 0;
            int colIndex = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                matrix[i] = line;
                if (line.Contains('S'))
                {
                    rowIndex = i;
                    colIndex = line.IndexOf('S');
                }
            }
            string commands = Console.ReadLine();
            bool exit = false;
            int turns = 0;
            foreach (char cmd in commands)
            {
                if (cmd == 'L')
                {
                    colIndex = colIndex - 1 >= 0 ? colIndex - 1 : matrix[rowIndex].Length - 1;
                }
                else if (cmd == 'R')
                {
                    colIndex = colIndex + 1 < matrix[rowIndex].Length ? colIndex + 1 : 0;
                }
                else if (cmd == 'U')
                {
                    while (true)
                    {
                        int newIndex = rowIndex - 1 >= 0 ? rowIndex - 1 : matrix.Length - 1;
                        if (colIndex < matrix[newIndex].Length)
                        {
                            rowIndex = newIndex;
                            break;
                        }
                        else
                        {
                            rowIndex = newIndex != matrix.Length-1 ? rowIndex -= 1 : matrix.Length - 1;
                        }
                    }
                }
                else if (cmd == 'D')
                {
                    while (true)
                    {
                        int newIndex = rowIndex + 1 < matrix.Length ? rowIndex + 1 : 0;
                        if (colIndex < matrix[newIndex].Length)
                        {
                            rowIndex = newIndex;
                            break;
                        }
                        else
                        {
                            rowIndex = newIndex != 0 ? rowIndex + 1 : 0;
                        }
                    }
                }
                turns++;
                if (matrix[rowIndex][colIndex] == 'E')
                {
                    Console.WriteLine("Experiment successful. {0} turns required.", turns);
                    exit = true;
                    return;
                }
            }
            if (!exit)
            {
                Console.WriteLine("Robot stuck at {0} {1}. Experiment failed.", rowIndex, colIndex);
            }
        }
    }
}
