using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FiveDifferentNumbers
{
    class FiveDifferentNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool no = true;

            for (int i = a; i <= b; i++)
            {
                for (int j = a+1; j <= b; j++)
                {
                    for (int k = a+2; k <= b; k++)
                    {
                        for (int l = a+3; l <= b; l++)
                        {
                            for (int m = a+4; m <= b; m++)
                            {
                                if (a <= i && i < j && j < k && k < l && l < m && m <= b)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, l, m);
                                    no = false;
                                }
                            }
                        }
                    }
                }
            }
            if (no)
	        {
                Console.WriteLine("No");  
	        }
        }
    }
}
