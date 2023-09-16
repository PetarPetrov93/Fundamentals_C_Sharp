using System.Security.Cryptography.X509Certificates;

namespace _06.UserLogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string cmd;
            //Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            //char[] separators = { '=', ' ' };

            //while ((cmd = Console.ReadLine()) != "end")
            //{
            //    string[] cmdArr = cmd.Split(separators);
            //    string ip = cmdArr[1];
            //    string username = cmdArr[cmdArr.Length - 1];
            //    if (!users.ContainsKey(username))
            //    {
            //        users.Add(username, new List<string>());
            //    }
            //    users[username].Add(ip);
            //}
            //foreach (var user in users.OrderBy(x => x.Key))
            //{
            //    Console.WriteLine(user.Key + ":");
            //    Dictionary<string, int> ipOccurances = new Dictionary<string, int>();
            //    foreach (string ip in user.Value)
            //    {


            //        if (!ipOccurances.ContainsKey(ip))
            //        {
            //            ipOccurances.Add(ip, 0);
            //        }
            //        ipOccurances[ip]++;

            //    }
            //    foreach (var item in ipOccurances)
            //    {
            //        Console.WriteLine($"{item.Key} => {item.Value}");
            //    }
            //}

            string command;

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            char[] separators = { '=', ' ' };

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArr = command.Split(separators);
                string ip = cmdArr[1];
                string username = cmdArr[cmdArr.Length - 1];

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, int>());
                    users[username].Add(ip, 1);
                }
                else
                {
                    if (!users[username].ContainsKey(ip))
                    {
                        users[username].Add(ip, 0);
                    }
                    users[username][ip]++;
                }
            }
            foreach (var currentUser in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(currentUser.Key + ":");

                Dictionary<string, int> ipsOfCurrUser = currentUser.Value; // NOT necessary, I decided to create new dictionary and use it's name instead of using currentUser.Value.

                foreach (var ip in ipsOfCurrUser)
                {

                    if (ip.Equals(ipsOfCurrUser.Last()))
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                        break;
                    }

                    Console.WriteLine($"{ip.Key} => {ip.Value},");

                }
            }

        }
    }
}