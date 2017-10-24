using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder match = new StringBuilder();
            int turn = 1;
            bool hasDash = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (turn % 2 != 0)
                {
                    if (!(char.IsLetter(text[i]) || text[i] == '-'))
                    {
                        match.Append(text[i]);
                    }
                    else
                    {
                        if (match.Length >= 1)
                        {
                            Console.WriteLine(match.ToString());
                            match = new StringBuilder();
                            i--;
                            turn++;
                        }
                    }
                    if (i == text.Length - 1 && match.Length != 0)
                    {
                        Console.WriteLine(match);
                    }
                }
                else
                {
                    if (char.IsLetter(text[i]) || (text[i] == '-' && !hasDash && match.Length != 0)) 
                    {
                        if (text[i] == '-')
                        {
                            hasDash = true;
                        }
                        match.Append(text[i]);
                    }
                    else
                    {
                        if (hasDash)
                        {
                            Console.WriteLine(match);
                            turn++;
                            i--;
                        }
                        match = new StringBuilder();
                        hasDash = false;
                    }
                    if (i == text.Length - 1 && match.Length != 0 && hasDash)
                    {
                        Console.WriteLine(match);
                    }
                }
            }
        }
    }
}
