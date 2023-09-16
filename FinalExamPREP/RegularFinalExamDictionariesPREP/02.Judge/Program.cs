namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;

            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            while ((cmd = Console.ReadLine()) != "no more time")
            {
                string[] cmdArr = cmd.Split(" -> ");
                string username = cmdArr[0];
                string contest = cmdArr[1];
                int points = int.Parse(cmdArr[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                }
                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, 0);
                }
                if (contests[contest][username] < points)
                {
                    contests[contest][username] = points;
                }
                
            }

            foreach (var currContest in contests)
            {
                
                Console.WriteLine($"{currContest.Key}: {currContest.Value.Count} participants");

                int counter = 0;
              
                foreach (var participant in currContest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {participant.Key} <::> {participant.Value}");
                    
                }
            }

            Dictionary<string, int> individualStats = new Dictionary<string, int>();

            foreach (var contest in contests)
            {
                foreach (var participant in contest.Value)
                {
                    if (!individualStats.ContainsKey(participant.Key))
                    {
                        individualStats.Add(participant.Key, 0);
                    }
                    individualStats[participant.Key]+= participant.Value;
                }
            }

            Console.WriteLine("Individual standings:");
            int counter2 = 0;
            foreach (var username in individualStats.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter2++;
                Console.WriteLine($"{counter2}. {username.Key} -> {username.Value}");
            }
        }
    }
}