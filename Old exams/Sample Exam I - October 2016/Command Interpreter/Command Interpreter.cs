using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                if (inputs[0] == "reverse")
                {
                    bool parsedS = int.TryParse(inputs[2], out int start);
                    bool parsedC = int.TryParse(inputs[4], out int count);
                    if (!parsedS || !parsedC || count < 0 || count > list.Count - start || start < 0 || start >= list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    var rev = list.Skip(start).Take(count).Reverse().ToList();
                    list.RemoveRange(start, count);
                    list.InsertRange(start, rev);
                }
                else if (inputs[0] == "sort")
                {
                    bool parsedS = int.TryParse(inputs[2], out int start);
                    bool parsedC = int.TryParse(inputs[4], out int count);
                    if (!parsedS || !parsedC || count < 0 || count > list.Count - start || start < 0 || start >= list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    var sort = list.Skip(start).Take(count).OrderBy(x => x).ToList();
                    list.RemoveRange(start, count);
                    list.InsertRange(start, sort);
                }
                else if (inputs[0] == "rollLeft")
                {
                    bool parsed = int.TryParse(inputs[1], out int count);
                    if (!parsed || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    for (int i = 0; i < count % list.Count; i++)
                    {
                        var elem = list[0];
                        list.RemoveAt(0);
                        list.Add(elem);
                    }
                }
                else if (inputs[0] == "rollRight")
                {
                    bool parsed = int.TryParse(inputs[1], out int count);
                    if (!parsed || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    for (int i = 0; i < count % list.Count; i++)
                    {
                        var elem = list[list.Count - 1];
                        list.RemoveAt(list.Count - 1);
                        list.Insert(0, elem);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }
    }
}