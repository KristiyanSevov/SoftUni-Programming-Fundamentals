using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new Dictionary<string, SortedDictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(';');
                long size = long.Parse(inputs[1]);
                int index = inputs[0].LastIndexOf('\\');
                string name = inputs[0].Substring(index + 1);
                index = inputs[0].IndexOf('\\');
                string root = inputs[0].Substring(0, index);
                if (!files.ContainsKey(root))
                {
                    files.Add(root, new SortedDictionary<string, long>());
                }
                if (!files[root].ContainsKey(name))
                {
                    files[root].Add(name, size);
                }
                else
                {
                    files[root][name] = size;
                }
            }
            string[] printing = Console.ReadLine().Split(' ');
            string rootP = printing[2];
            string ext = printing[0];
            bool found = false;
            foreach (var root in files.Where(x => x.Key == rootP))
            {
                foreach (var file in root.Value
                    .Where(x => x.Key.Substring(x.Key.LastIndexOf('.') + 1) == ext)
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
