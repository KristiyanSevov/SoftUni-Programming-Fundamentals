using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            if (char.IsDigit(a))
            {
                Console.WriteLine("digit");
            }
            else if (a == 'a' || a == 'e' || a == 'o' || a =='i' || a == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
