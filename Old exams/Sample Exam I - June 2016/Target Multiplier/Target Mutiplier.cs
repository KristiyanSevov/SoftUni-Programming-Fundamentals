using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Target_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            List<long[]> matrix = new List<long[]>();
            for (int i = 0; i < rows; i++)
            {
                long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                matrix.Add(nums);
            }
            string[] indices = Console.ReadLine().Split(' ');
            int rowIndex = int.Parse(indices[0]);
            int colIndex = int.Parse(indices[1]);
            long sum = 0;
            for (int i = rowIndex - 1; i <= rowIndex + 1; i++)
            {
                for (int j = colIndex - 1; j <= colIndex + 1; j++)
                {
                    if (i == rowIndex && j == colIndex)
                    {
                        continue;
                    }
                    sum += matrix[i][j];
                    matrix[i][j] *= matrix[rowIndex][colIndex];
                }
            }
            matrix[rowIndex][colIndex] *= sum;
            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
