﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main() //only had to debug the code
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] commands = Console.ReadLine().Trim().Split(ArgumentsDelimiter); 
            while (!commands[0].Equals("stop"))
            {
                string command = commands[0];
                int[] args = new int[2];
                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    args[0] = int.Parse(commands[1]);
                    args[1] = int.Parse(commands[2]);

                    PerformAction(array, command, args);
                }

                else
                {
                    PerformAction(array, command, args);
                }

                PrintArray(array);
                Console.WriteLine();

                commands = Console.ReadLine().Trim().Split(ArgumentsDelimiter);
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}