using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
	    string[] command = Console.ReadLine().Split(' ');
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        phonebook[command[1]] = command[2];
                    }
                    else
                    {
                        phonebook.Add(command[1], command[2]);
                    }
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", command[1]);
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
