using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string type = null;
            string source = null;
            string forecast = null;
            while (input != "Davai Emo")
            {
                if (type == null && Regex.IsMatch(input, @"^Type: (Normal|Warning|Danger)$"))
                {
                    type = input.Substring(6);
                }
                if (source == null && type != null && Regex.IsMatch(input, @"^Source: \w+$"))
                {
                    source = input.Substring(8);
                }
                if (type != null && source != null && Regex.IsMatch(input, @"^Forecast: [^!.,?]+$"))
                {
                    forecast = input.Substring(10);
                }
                if (type != null && source != null && forecast != null)
                {
                    Console.WriteLine("({0}) {1} ~ {2}", type, forecast, source);
                    type = null;
                    source = null;
                    forecast = null;
                }
                input = Console.ReadLine();
            }
        }
    }
}
