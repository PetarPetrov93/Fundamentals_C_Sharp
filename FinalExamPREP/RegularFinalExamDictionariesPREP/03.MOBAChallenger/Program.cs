using System.Security.Cryptography;

namespace _03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;

            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            while ((cmd = Console.ReadLine()) != "Season end")
            {
                string splitter = " -> ";
                if (cmd.Contains(splitter))
                {
                    string[] cmdArr = cmd.Split(splitter);
                    string player = cmdArr[0];
                    string position = cmdArr[1];
                    int skill = int.Parse(cmdArr[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                    }
                    if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);
                    }
                    else
                    {
                        if (players[player][position] < skill)
                        {
                            players[player][position] = skill;
                        }
                    }

                }
                else
                {
                    string[] cmdArr2 = cmd.Split(" vs ");
                    string plr1 = cmdArr2[0];
                    string plr2 = cmdArr2[1];

                    if (players.ContainsKey(plr1) && players.ContainsKey(plr2))
                    {
                        string plrToRemove = string.Empty;

                        foreach (var positionPlr1 in players[plr1])
                        {
                            foreach (var positionPlr2 in players[plr2])
                            {
                                if (positionPlr1.Key == positionPlr2.Key)
                                {
                                    if (players[plr1].Values.Sum() > players[plr2].Values.Sum())
                                    {
                                        plrToRemove = plr2;
                                    }
                                    else if (players[plr1].Values.Sum() < players[plr2].Values.Sum())
                                    {
                                        plrToRemove = plr1;
                                    }
                                }
                            }
                        }
                        players.Remove(plrToRemove);
                    }

                }
            }

            Dictionary< string, int> playerTotalSkill = new Dictionary< string, int>();

            foreach (var player in players)
            {
                string currPlr = player.Key;
                if (!playerTotalSkill.ContainsKey(currPlr))
                {
                    playerTotalSkill.Add(currPlr, 0);
                }
                foreach (var skill in player.Value)
                {
                    playerTotalSkill[currPlr] += skill.Value;
                }
            }
            foreach (var playerTotal in playerTotalSkill.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{playerTotal.Key}: {playerTotal.Value} skill");

                foreach (var player in players.Where(x => x.Key == playerTotal.Key))
                {
                    foreach (var skill in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                    }
                }
            }

        }
    }
}