using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
	    Dictionary<string, string> emails = new Dictionary<string, string>();
            int count = 1;
            string name = string.Empty;
            string email = string.Empty;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                if (count % 2 != 0)
                {
                    name = command;
                }
                else if (!(command.ToLower().EndsWith("us") ||
                    command.ToLower().EndsWith("uk")))
                {
                    email = command;
                    emails.Add(name, email);
                }
                count++;
            }
            foreach (var pair in emails)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
