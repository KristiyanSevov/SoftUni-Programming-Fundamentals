using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int sites = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            for (int i = 0; i < sites; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string name = inputs[0];
                long visits = long.Parse(inputs[1]);
                decimal price = decimal.Parse(inputs[2]);
                Console.WriteLine(name);
                decimal loss = price * visits;
                totalLoss += loss;
            }
            Console.WriteLine("Total Loss: {0:f20}", totalLoss);
            BigInteger token = 1;
            for (int i = 0; i < sites; i++)
            {
                token *= key;
            }
            Console.WriteLine("Security Token: {0}", token);
        }
    }
}