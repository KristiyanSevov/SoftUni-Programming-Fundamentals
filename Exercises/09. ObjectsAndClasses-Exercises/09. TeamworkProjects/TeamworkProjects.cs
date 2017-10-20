using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class Test
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creator = input[0];
                string name = input[1];
                if (teams.Any(x => x.Name == name))
                {
                    Console.WriteLine("Team {0} was already created!", name);
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine("{0} cannot create another team!", creator);
                }
                else
                {
                    Team team = new Team() { Name = name, Creator = creator, Members = new List<string>() };
                    Console.WriteLine("Team {0} has been created by {1}!", name, creator);
                    teams.Add(team);
                }
            }
            string nextInput = Console.ReadLine();
            while (nextInput != "end of assignment")
            {
                string[] members = nextInput.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string member = members[0];
                string team = members[1];
                if (!teams.Any(x => x.Name == team))
                {
                    Console.WriteLine("Team {0} does not exist!", team);
                }
                else if (teams.Any(x => x.Members.Contains(member) || x.Creator == member))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", member, team);
                }
                else
                {
                    teams.Where(x => x.Name == team).ToList()[0].Members.Add(member);
                }
                nextInput = Console.ReadLine();
            }
            foreach (var team in teams.Where(x => x.Members.Count != 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- {0}", team.Creator);
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0}", member);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public List<string> Members { get; set; }
        public string Creator { get; set; }
        public string Name { get; set; }
    }
}
