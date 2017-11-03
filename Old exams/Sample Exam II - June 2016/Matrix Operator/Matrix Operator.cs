using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> row = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                matrix.Add(row);
            }
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                string command = inputs[0];
                if (command == "remove")
                {
                    string type = inputs[1];
                    string place = inputs[2];
                    int index = int.Parse(inputs[3]);
                    if (place == "row")
                    {
                        RemoveFromRow(matrix, type, index);
                    }
                    else if (place == "col")
                    {
                        RemoveFromCol(matrix, type, index);
                    }
                }
                else if (command == "swap")
                {
                    int firstIndex = int.Parse(inputs[1]);
                    int secondIndex = int.Parse(inputs[2]);
                    var temp = matrix[firstIndex];
                    matrix[firstIndex] = matrix[secondIndex];
                    matrix[secondIndex] = temp;
                }
                else if (command == "insert")
                {
                    int index = int.Parse(inputs[1]);
                    int element = int.Parse(inputs[2]);
                    matrix[index].Insert(0, element);
                }
                input = Console.ReadLine();
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }

        public static void RemoveFromCol(List<List<int>> matrix, string type, int index)
        {
            foreach (var row in matrix)
            {
                if (index < row.Count)
                {
                    if (type == "positive" && row[index] >= 0 ||
                        type == "negative" && row[index] < 0 ||
                        type == "odd" && row[index] % 2 != 0 ||
                        type == "even" && row[index] % 2 == 0)
                    {
                        row.RemoveAt(index);
                    }
                }
            }
        }

        public static void RemoveFromRow(List<List<int>> matrix, string type, int index)
        {
            switch (type)
            {
                case "positive": 
                    matrix[index].RemoveAll(x => x >= 0); break;
                case "negative":
                    matrix[index].RemoveAll(x => x < 0); break;
                case "even":
                    matrix[index].RemoveAll(x => x % 2 == 0); break;
                case "odd":
                    matrix[index].RemoveAll(x => x % 2 != 0); break;
            }
        }
    }
}
