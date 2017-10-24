using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main() //old solution - written before Lists lecture
        {
            {
                string[] input = Console.ReadLine().Split();
                int[] numbers = Array.ConvertAll(input, int.Parse);
                int index;
                int value = int.MinValue;
                int sum = 0;

                while (numbers.Length != 0)
                {
                    index = int.Parse(Console.ReadLine());
                    if (index < 0)
                    {
                        value = numbers[0];
                        sum += value;
                        numbers[0] = numbers[numbers.Length - 1];
                        numbers = ValueUpdater(numbers, value);
                    }
                    else if (index >= numbers.Length)
                    {
                        value = numbers[numbers.Length - 1];
                        sum += value;
                        numbers[numbers.Length - 1] = numbers[0];
                        numbers = ValueUpdater(numbers, value);
                    }
                    else
                    {
                        sum += numbers[index];
                        numbers = newArrayMaker(numbers, index);
                    }
                }
                Console.WriteLine(sum);
            }
        }

        static int[] newArrayMaker(int[] arr, int index)
        {
            int[] newArr = new int[arr.Length - 1];
            int element;
            bool passed = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = (passed ? i - 1 : i);
                if (i == index)
                {
                    passed = true;
                    continue;
                }
                if (arr[i] <= arr[index])
                {
                    element = arr[i] + arr[index];
                    newArr[j] = element;
                }
                else if (arr[i] >= arr[index])
                {
                    element = arr[i] - arr[index];
                    newArr[j] = element;
                }
            }
            return newArr;
        }

        static int[] ValueUpdater(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= value)
                {
                    arr[i] += value;
                }
                else
                {
                    arr[i] -= value;
                }
            }
            return arr;
        }
    }
}
