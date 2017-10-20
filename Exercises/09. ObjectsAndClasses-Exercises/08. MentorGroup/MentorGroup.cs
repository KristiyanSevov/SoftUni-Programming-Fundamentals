using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    class Test
    {
        static void Main()
        {
            var students = new Dictionary<string, Student>();
            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                string[] namesAndDates = input.Split(' ');
                string name = namesAndDates[0];
                List<string> dates = new List<string>();
                if (namesAndDates.Length > 1)
                {
                     dates = namesAndDates[1].Split(',').ToList();
                }
                Student student = new Student()
                {   Name = name,
                    Dates = new List<DateTime>(),
                    Comments = new List<string>()
                };
                foreach (var date in dates)
                {
                    student.Dates.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                if (!students.ContainsKey(name))
                {
                    students.Add(name, student);
                }
                else
                {
                    students[name].Dates.AddRange(student.Dates);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "end of comments")
            {
                string[] comments = input.Split('-');
                string user = comments[0];
                string comment = comments[1];
                if (students.ContainsKey(user))
                {
                    students[user].Comments.Add(comment);
                }
                input = Console.ReadLine();
            }
            foreach (var user in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in user.Value.Comments)
                {
                    Console.WriteLine("- {0}", comment);
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in user.Value.Dates.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0:d2}/{1:d2}/{2}", date.Day, date.Month, date.Year);
                }
            }
        }
    }

    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
        public string Name { get; set; }
    }
}
