using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "Over!")
            {
                int len = int.Parse(Console.ReadLine());
                var leftNumbers = new StringBuilder();
                var message = new StringBuilder();
                var rightNumbers = new StringBuilder();
                int index = 0;
                while (index < text.Length && char.IsDigit(text[index]))
                {
                    leftNumbers.Append(text[index]);
                    index++;
                }
                while (index < text.Length && char.IsLetter(text[index]))
                {
                    message.Append(text[index]);
                    index++;
                }
                var rightChars = new StringBuilder();
                bool broken = false;
                for (int i = index; i < text.Length; i++)
                {
                    if (char.IsLetter(text[i]))
                    {
                        text = Console.ReadLine();
                        broken = true;
                        break;
                    }
                    rightChars.Append(text[i]);
                }
                if (broken)
                {
                    continue;
                }
                int newIndex = index;
                while (newIndex < text.Length && char.IsDigit(text[newIndex]))
                {
                    rightNumbers.Append(text[newIndex]);
                    newIndex++;
                }
                if (index + rightChars.Length != text.Length || message.Length != len)
                {
                    text = Console.ReadLine();
                    continue;
                }
                string decrypted = message.ToString();
                leftNumbers.Append(rightNumbers);
                var validation = new StringBuilder();
                foreach (var num in leftNumbers.ToString().ToCharArray().Select(x => String.Join("", x)).Select(int.Parse))
                {
                    if (num >= decrypted.Length)
                    {
                        validation.Append(" ");
                    }
                    else
                    {
                        validation.Append(decrypted[num]);
                    }
                }
                Console.WriteLine("{0} == {1}", decrypted, validation.ToString());

                text = Console.ReadLine();
            }
        }
    }
}