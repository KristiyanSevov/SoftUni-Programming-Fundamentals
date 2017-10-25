using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new List<Sale>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSale();
                sales.Add(sale);
            }
            foreach (var sale in sales.Select(x => x.Town).Distinct().OrderBy(x => x))
            {
                Console.WriteLine("{0} -> {1:f2}", sale, 
                    sales.Where(x => x.Town == sale).Select(x => x.Price * x.Quantity).Sum());
            }
        }

        private static Sale ReadSale()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            var sale = new Sale();
            sale.Town = inputs[0];
            sale.Product = inputs[1];
            sale.Price = double.Parse(inputs[2]);
            sale.Quantity = double.Parse(inputs[3]);
            return sale;
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
