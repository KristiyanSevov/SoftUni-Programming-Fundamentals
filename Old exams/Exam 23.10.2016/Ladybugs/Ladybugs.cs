using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] places = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] field = new int[size];
            foreach (var index in places)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                int index = int.Parse(inputs[0]);
                string direction = inputs[1];
                int length = int.Parse(inputs[2]);

                if ((index >= 0 && index < field.Length) && field[index] == 1)
                {
                    field[index] = 0;
                    if (direction == "right")
                    {
                        FlyRight(index, length, field);
                    }
                    else if (direction == "left")
                    {
                        FlyLeft(index, length, field);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", field));
        }

        private static void FlyLeft(int index, int length, int[] field)
        {
            int newIndex = index - length;
            if (newIndex >= 0)
            {
                if (field[newIndex] == 0)
                {
                    field[newIndex] = 1;
                }
                else
                {
                    FlyLeft(newIndex, length, field);
                }
            }
        }

        private static void FlyRight(int index, int length, int[] field)
        {
            int newIndex = index + length;
            if (newIndex < field.Length)
            {
                if (field[newIndex] == 0)
                {
                    field[newIndex] = 1;
                }
                else
                {
                    FlyRight(newIndex, length, field);
                }
            }
        }
    }
}
