using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle first = ReadRectangle();
            Rectangle second = ReadRectangle();
            Console.WriteLine(first.IsInside(second) ? "Inside" : "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rectangle = new Rectangle();
            rectangle.Left = first[0];
            rectangle.Top = first[1];
            rectangle.Width = first[2];
            rectangle.Heigth = first[3];
            return rectangle;
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public int Bottom
        {
            get
            {
                return Top + Heigth;
            }
        }

        public bool IsInside(Rectangle r)
        {
            if (this.Left >= r.Left && this.Right <= r.Right && this.Top <= r.Top && this.Bottom <= r.Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
