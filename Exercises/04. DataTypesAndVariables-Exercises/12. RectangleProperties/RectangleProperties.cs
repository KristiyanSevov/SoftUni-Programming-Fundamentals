using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(2 * width + 2 *height);
            Console.WriteLine(width * height);
            Console.WriteLine(Math.Sqrt(width*width + height*height));
        }
    }
}
