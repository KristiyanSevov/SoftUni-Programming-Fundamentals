using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _10.StudentGroups
{
    class Test
    {
        static void Main()
        {
            List<Group> groups = new List<Group>();
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            int counter = -1;
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    string[] inputs = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string townName = inputs[0].Trim();
                    int seats = int.Parse(inputs[1].Trim().Split(' ')[0]);
                    var town = new Town()
                    {
                        Name = townName,
                        SeatsCount = seats,
                        Students = new List<Student>()
                    };
                    towns.Add(town);
                    counter++;
                }
                else
                {
                    string[] namesInput = input.Split('|');
                    string name = namesInput[0].Trim();
                    string email = namesInput[1].Trim();
                    DateTime date = DateTime.ParseExact(namesInput[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    var student = new Student()
                    {
                        Name = name,
                        Email = email,
                        RegistrationDate = date
                    };
                    towns[counter].Students.Add(student);
                }
                input = Console.ReadLine();
            }

            foreach (var town in towns)
            {
                town.Students = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email).ToList();
                int countProcessedStudents = 0;
                while (countProcessedStudents < town.Students.Count)
                {
                    var group = new Group()
                    {
                        Town = town,
                        Students = new List<Student>()
                    };
                    groups.Add(group);
                    for (int i = countProcessedStudents; i < town.Students.Count; i++)
                    {
                        group.Students.Add(town.Students[i]);
                        countProcessedStudents++;
                        if (group.Students.Count == town.SeatsCount)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);
            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, String.Join(", ", group.Students.Select(x => x.Email)));
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }
    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
