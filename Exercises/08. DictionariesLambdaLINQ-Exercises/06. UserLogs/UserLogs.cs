using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
	    var users = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split(new char[] { '=', ' ' },
                                  StringSplitOptions.RemoveEmptyEntries);
                string IP = inputs[1];
                string user = inputs[inputs.Length - 1];
                if (!users.ContainsKey(user))
                {
                    users.Add(user, new Dictionary<string, int>());
                }
                if (!users[user].ContainsKey(IP))
                {
                    users[user].Add(IP, 1);
                }
                else
                {
                    users[user][IP]++;
                }
                input = Console.ReadLine();
            }
            foreach (var user in users)
            {
                Console.WriteLine("{0}: ", user.Key);
                string res = String.Empty;
                foreach (var IP in users[user.Key])
                {
                    res += string.Format("{0} => {1}, ", IP.Key, IP.Value);
                }
                res = res.Remove(res.Length - 2);
                Console.WriteLine(res + '.');
            }
        }
    }
}
