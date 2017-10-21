using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main()
        {
            DateTime first = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);
            DateTime second = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(1970, 01, 01),
                new DateTime(1970, 03, 03),
                new DateTime(1970, 05, 01),
                new DateTime(1970, 05, 06),
                new DateTime(1970, 05, 24),
                new DateTime(1970, 09, 06),
                new DateTime(1970, 09, 22),
                new DateTime(1970, 10, 01),
                new DateTime(1970, 12, 24),
                new DateTime(1970, 12, 25),
                new DateTime(1970, 12, 26)
            };
            int workdays = 0;
            for (DateTime date = first; date <= second; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && 
                    date.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool found = false;
                    foreach (var holiday in holidays)
                    {
                        if (date.Month == holiday.Month && date.Day == holiday.Day)
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        workdays++;
                    }
                }
            }
            Console.WriteLine(workdays);
        }
    }
}
