namespace _08.LogsAgregator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ip = input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);

                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }
                if (!users[name].ContainsKey(ip))
                {
                    users[name].Add(ip, duration);
                }
                else
                {
                    users[name][ip] += duration;
                }
               
            }
            foreach (var user in users)
            {
                Console.Write($"{user.Key}: ");
                int totalTime = 0;
                foreach (var ip in user.Value)
                {
                    totalTime += ip.Value;
                }

                Console.Write($"{totalTime} [");
                List<string> ipsOfCurrUser = new List<string>();

                foreach (var ip in user.Value)
                {
                    ipsOfCurrUser.Add(ip.Key);
                    
                }

                ipsOfCurrUser.Sort();

                Console.WriteLine($"{string.Join(", ", ipsOfCurrUser)}]");
            }
        }
    }
}