namespace _01.RankingNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] inputArr = input.Split(":");
                string contest = inputArr[0];
                string password = inputArr[1];

                if (!contestAndPassword.ContainsKey(contest))
                {
                    contestAndPassword.Add(contest, password); 
                }
            }

            string cmd;

            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();

            while ((cmd = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArr = cmd.Split("=>");
                string contest = cmdArr[0];
                string password = cmdArr[1];
                string candidate = cmdArr[2];
                int points = int.Parse(cmdArr[3]);

                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == password)
                {
                    if (candidates.ContainsKey(candidate) && candidates[candidate].ContainsKey(contest) && candidates[candidate][contest] < points)
                    {
                        candidates[candidate][contest] = points;
                        
                    }
                    else if (!candidates.ContainsKey(candidate))
                    {
                        candidates.Add(candidate, new Dictionary<string, int>());
                        candidates[candidate].Add(contest, points);
                        
                    }
                    else if (candidates.ContainsKey(candidate) && (!candidates[candidate].ContainsKey(contest)))
                    {
                        candidates[candidate].Add(contest, points);
                    }

                }
            }

            int bestCandidateTotalPoints = 0;
            string bestCandidate = string.Empty;
            
            foreach (var candidate in candidates)
            {
                int currentCandidateTotalPoints = 0;

                foreach (var (contest, points) in candidate.Value)
                {
                    
                    currentCandidateTotalPoints += points;
                }

                if (bestCandidateTotalPoints < currentCandidateTotalPoints) // what happens if there are 2 candidates with euqal points?
                {
                    bestCandidateTotalPoints = currentCandidateTotalPoints;
                    bestCandidate = candidate.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidateTotalPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var candidate in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);

                foreach (var (contest, points) in candidate.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}