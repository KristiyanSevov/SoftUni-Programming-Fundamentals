using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main()
        {
            string[] nums = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, 
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(String.Join(", ", nums.Where(x => x.Length < 5)
						    .Select(x => x.ToLower())
						    .Distinct()
						    .OrderBy(x => x)));
        }
    }
}
