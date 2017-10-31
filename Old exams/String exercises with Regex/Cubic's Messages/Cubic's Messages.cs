using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cubic_s_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Over!")
            {
                int num = int.Parse(Console.ReadLine());
                string pattern = $@"^\d+([a-zA-Z]{{{num}}})[^a-zA-Z]*$";
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string message = match.Groups[1].Value;
                    var verification = new StringBuilder();
                    foreach (Match m in Regex.Matches(match.Value, @"\d"))
                    {
                        int digit = int.Parse(m.Value);
                        if (digit < message.Length)
                        {
                            verification.Append(message[digit]);
                        }
                        else
                        {
                            verification.Append(' ');
                        }
                    }
                    Console.WriteLine("{0} == {1}", message, verification);
                }
                input = Console.ReadLine();
            }
        }
    }
}
