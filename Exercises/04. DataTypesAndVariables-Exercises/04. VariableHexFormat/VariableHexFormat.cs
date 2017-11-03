using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableHexFormat
{
    class VariableHexFormat
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(num);
        }
    }
}
