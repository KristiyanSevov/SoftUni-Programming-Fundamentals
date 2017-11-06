using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "3:1")
            {
                string[] inputs = input.Split(' ');
                string command = inputs[0];
                if (command == "merge")
                {
                    int start = int.Parse(inputs[1]);
                    int end = int.Parse(inputs[2]);
                    start = start >= 0 ? start : 0;
                    start = start < data.Count ? start : data.Count - 1;
                    end = end < data.Count ? end : data.Count - 1;
                    end = end >= 0 ? end : 0;
                    var result = new StringBuilder();
                    for (int i = start; i <= end; i++)
                    {
                        result.Append(data[i]);
                    }
                    if (start != data.Count - 1 && end != 0)
                    {
                        data.RemoveRange(start, end - start + 1);
                        data.Insert(start, result.ToString());
                    }
                }
                else if (command == "divide")
                {
                    int index = int.Parse(inputs[1]);
                    int partitions = int.Parse(inputs[2]);
                    string element = data[index];
                    List<string> parts = new List<string>();
                    int partLength = element.Length / partitions;
                    var part = new StringBuilder();
                    for (int i = 0; i < element.Length; i++)
                    {
                        part.Append(element[i]);
                        if (part.Length == partLength && parts.Count != partitions)
                        {
                            parts.Add(part.ToString());
                            part.Clear();
                        }
                    }
                    if (part.Length != 0)
                    {
                        parts[parts.Count - 1] += part.ToString();
                    }
                    data.RemoveAt(index);
                    data.InsertRange(index, parts);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", data));
        }
    }
}