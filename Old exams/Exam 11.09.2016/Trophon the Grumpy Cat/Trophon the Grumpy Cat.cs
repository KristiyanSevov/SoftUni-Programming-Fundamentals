using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> prices = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            string typeOfItem = Console.ReadLine();
            string typeOfPrice = Console.ReadLine();

            long price = prices[index];
            long leftSum = 0;
            long rightSum = 0;
            if (typeOfItem == "cheap")
            {
                if (typeOfPrice == "positive")
                {
                    leftSum = prices.Take(index).Where(x => x > 0 && x < price).Sum();
                    rightSum = prices.Skip(index+1).Where(x => x > 0 && x < price).Sum();
                }
                else if (typeOfPrice == "negative")
                {
                    leftSum = prices.Take(index).Where(x => x < 0 && x < price).Sum();
                    rightSum = prices.Skip(index + 1).Where(x => x < 0 && x < price).Sum();
                }
                else if (typeOfPrice == "all")
                {
                    leftSum = prices.Take(index).Where(x => x < price).Sum();
                    rightSum = prices.Skip(index + 1).Where(x => x < price).Sum();
                }
            }
            else if (typeOfItem == "expensive")
            {
                if (typeOfPrice == "positive")
                {
                    leftSum = prices.Take(index).Where(x => x > 0 && x >= price).Sum();
                    rightSum = prices.Skip(index + 1).Where(x => x > 0 && x >= price).Sum();
                }
                else if (typeOfPrice == "negative")
                {
                    leftSum = prices.Take(index).Where(x => x < 0 && x >= price).Sum();
                    rightSum = prices.Skip(index + 1).Where(x => x < 0 && x >= price).Sum();
                }
                else if (typeOfPrice == "all")
                {
                    leftSum = prices.Take(index).Where(x => x >= price).Sum();
                    rightSum = prices.Skip(index + 1).Where(x => x >= price).Sum();
                }
            }
            Console.WriteLine("{0} - {1}", 
                leftSum >= rightSum ? "Left":"Right",
                leftSum >= rightSum ? leftSum : rightSum);
        }
    }
}
