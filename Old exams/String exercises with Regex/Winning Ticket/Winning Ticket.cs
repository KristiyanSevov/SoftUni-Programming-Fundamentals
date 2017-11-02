using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"@{6,}|#{6,}|\${6,}|\^{6,}";
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string left = ticket.Substring(0, 10);
                string right = ticket.Substring(10, 10);
                Match leftMatch = Regex.Match(left, pattern);
                Match rightMatch = Regex.Match(right, pattern);
                if (leftMatch.Success && rightMatch.Success)
                {
                    char leftSymbol = leftMatch.Value[0];
                    int leftLength = leftMatch.Value.Length;
                    char rightSymbol = rightMatch.Value[0];
                    int rightLength = rightMatch.Value.Length;
                    if (leftLength == 10 && rightLength == 10 && leftSymbol == rightSymbol)
                    {
                        Console.WriteLine("ticket \"{0}\" - 10{1} Jackpot!", ticket, leftSymbol);
                    }
                    else if (leftSymbol == rightSymbol)
                    {
                        Console.WriteLine("ticket \"{0}\" - {1}{2}", ticket, Math.Min(leftLength, rightLength), leftSymbol);
                    }
                    else
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    }
                }
                else
                {
                    Console.WriteLine("ticket \"{0}\" - no match", ticket);
                }
            }
        }
    }
}
