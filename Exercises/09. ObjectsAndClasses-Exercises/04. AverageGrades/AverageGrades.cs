using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Test
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                students[i] = new Student() { Name = input[0], Grades = new List<double>() };
                students[i].Grades.AddRange(input.Skip(1).Select(double.Parse));
            }
            foreach (var student in students.OrderBy(x => x.Name)
                                            .ThenByDescending(x => x.AverageGrade))
            {
                if (student.AverageGrade >= 5.00)
                {
                    Console.WriteLine("{0} -> {1:f2}", student.Name, student.AverageGrade);
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return this.Grades.Average();
            }
        }
    }
}
