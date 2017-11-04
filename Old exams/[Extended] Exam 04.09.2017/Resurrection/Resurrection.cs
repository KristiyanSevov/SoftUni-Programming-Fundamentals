using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long length = long.Parse(Console.ReadLine());
                string widthStr = Console.ReadLine();
                int precision = widthStr.IndexOf('.') != 0 ? widthStr.Substring(widthStr.IndexOf('.') + 1).Length : 0;
                decimal width = decimal.Parse(widthStr);
                long wing = long.Parse(Console.ReadLine());
                decimal years = length * length * (width + 2 * wing);
                Console.WriteLine(Math.Round(years, precision));
            }
        }
    }
}
