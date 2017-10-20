using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                if (!products.ContainsKey(input[0]))
                {
                    products.Add(input[0], decimal.Parse(input[1]));
                }
                else
                {
                    products[input[0]] = decimal.Parse(input[1]);
                }
            }
            var people = new SortedDictionary<string, Dictionary<string, int>>();
            string clientInput = Console.ReadLine();
            while (clientInput != "end of clients")
            {
                string[] clients = clientInput.Split('-');
                string name = clients[0];
                string[] bought = clients[1].Split(',');
                string item = bought[0];
                int quantity = int.Parse(bought[1]);
                if (!people.ContainsKey(name) && products.ContainsKey(item))
                {
                    people.Add(name, new Dictionary<string, int>());
                }
                if (products.ContainsKey(item))
                {
                    if (!people[name].ContainsKey(item))
                    {
                        people[name].Add(item, quantity);
                    }
                    else
                    {
                        people[name][item] += quantity;
                    }
                }
                clientInput = Console.ReadLine();
            }
            decimal totalBill = 0;
            foreach (var person in people)
            {
                Console.WriteLine(person.Key);
                decimal sum = 0;
                foreach (var product in person.Value)
                {
                    Console.WriteLine("-- {0} - {1}", product.Key, product.Value);
                    sum += product.Value * products[product.Key];
                }
                Console.WriteLine("Bill: {0:f2}", sum);
                totalBill += sum;
            }
            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }
    }
}
