namespace _03.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroesStats = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] hero = Console.ReadLine().Split(" ");
                string heroName = hero[0];
                int HP = int.Parse(hero[1]);
                int MP = int.Parse(hero[2]);

                if (!heroesStats.ContainsKey(heroName))
                {
                    heroesStats.Add(heroName, new List<int>());
                    heroesStats[heroName].Add(HP);
                    heroesStats[heroName].Add(MP);
                }
                else // probably not needed here specifically
                {
                    heroesStats[heroName][0] = HP;
                    heroesStats[heroName][1] = MP;
                }
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArr = cmd.Split(" - ");
                string heroName = cmdArr[1];

                if (cmdArr[0] == "CastSpell")
                {
                    int MPNeeded = int.Parse(cmdArr[2]);
                    string spellName = cmdArr[3];

                    if (heroesStats[heroName][1] - MPNeeded < 0)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroesStats[heroName][1] -= MPNeeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesStats[heroName][1]} MP!");
                    }
                }
                else if (cmdArr[0] == "TakeDamage")
                {
                    int damage = int.Parse(cmdArr[2]);
                    string attacker = cmdArr[3];

                    heroesStats[heroName][0] -= damage;

                    if (heroesStats[heroName][0] <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroesStats.Remove(heroName);
                    }
                    else
                    {                       
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesStats[heroName][0]} HP left!");
                    }
                }
                else if (cmdArr[0] == "Recharge")
                {
                    int recherge = int.Parse(cmdArr[2]);

                    if (heroesStats[heroName][1] + recherge > 200)
                    {
                        int rechargedAmmout = 200 - heroesStats[heroName][1];

                        heroesStats[heroName][1] = 200;

                        Console.WriteLine($"{heroName} recharged for {rechargedAmmout} MP!");
                    }
                    else
                    {
                        heroesStats[heroName][1] += recherge;
                        Console.WriteLine($"{heroName} recharged for {recherge} MP!");
                    }
                }
                else if (cmdArr[0] == "Heal")
                {
                    int heal = int.Parse(cmdArr[2]);

                    if (heroesStats[heroName][0] + heal > 100)
                    {
                        int healedAmmount = 100 - heroesStats[heroName][0];

                        heroesStats[heroName][0] = 100;

                        Console.WriteLine($"{heroName} healed for {healedAmmount} HP!");
                    }
                    else
                    {
                        heroesStats[heroName][0] += heal;
                        Console.WriteLine($"{heroName} healed for {heal} HP!");
                    }
                }
            }

            foreach (var hero in heroesStats)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}