using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            long employeeNum = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", first);
            Console.WriteLine("Last name: {0}", last);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", ID);
            Console.WriteLine("Unique Employee number: {0}", employeeNum);
        }
    }
}
