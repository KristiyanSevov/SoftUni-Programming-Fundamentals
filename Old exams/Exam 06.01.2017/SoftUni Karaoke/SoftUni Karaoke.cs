using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new char[] { ',' }).Select(x => x.Trim()).ToArray();
            string[] songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            var singers = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "dawn")
            {
                string[] inputs = input.Split(',').Select(x => x.Trim()).ToArray();
                string singer = inputs[0];
                string song = inputs[1];
                string award = inputs[2];

                if (participants.Contains(singer) && songs.Contains(song))
                {
                    if (!singers.ContainsKey(singer))
                    {
                        singers.Add(singer, new List<string>() { award });
                    }
                    else if (singers.ContainsKey(singer) && !singers[singer].Contains(award))
                    {
                        singers[singer].Add(award);
                    }
                }
                input = Console.ReadLine();
            }
            if (singers.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var singer in singers.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
                {
                    Console.WriteLine("{0}: {1} awards", singer.Key, singer.Value.Count());
                    foreach (var award in singer.Value.OrderBy(x => x))
                    {
                        Console.WriteLine("--{0}", award);
                    }
                }
            }
        }
    }
}
