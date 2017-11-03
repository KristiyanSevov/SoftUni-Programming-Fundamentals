using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            object var = s1 + ' ' + s2;
            string s3 = var.ToString();
            Console.WriteLine(s3);
        }
    }
}
