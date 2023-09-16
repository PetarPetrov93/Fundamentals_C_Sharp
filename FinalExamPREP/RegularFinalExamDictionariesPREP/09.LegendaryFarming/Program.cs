namespace _09.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               •	Shadowmourne – requires 250 Shards;
               •	Valanyr – requires 250 Fragments;
               •	Dragonwrath – requires 250 Motes;
               .    Junk

             */

            string[] input;

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();

            int shadowmourne = 0;
            int valanyr = 0;
            int dragonwarth = 0;

            while (shadowmourne < 250 && valanyr < 250 && dragonwarth < 250)   
            {
                input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string element = input[i + 1].ToLower();

                    if (element == "shards")
                    {
                        shadowmourne += quantity;

                        if (shadowmourne >= 250)
                        {
                            break;
                        }

                    }
                    else if (element == "fragments")
                    {
                        valanyr += quantity;

                        if (valanyr >= 250)
                        {
                            break;
                        }
                    }
                    else if (element == "motes")
                    {
                        dragonwarth += quantity;

                        if (dragonwarth >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(element))
                        {
                            junkItems.Add(element, 0);
                        }
                        junkItems[element] += quantity;
                    }

                }
            }
            if (shadowmourne >= 250)
            {
                shadowmourne -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (valanyr >= 250)
            {
                valanyr -= 250;
                Console.WriteLine("Valanyr obtained!");
            }
            else if (dragonwarth >= 250)
            {
                dragonwarth -= 250;
                Console.WriteLine("Dragonwarth obtained!");
            }

            string shards = "shards";
            string fragments = "fragments";
            string motes = "motes";

            keyMaterials.Add(shards, shadowmourne);
            keyMaterials.Add(fragments, valanyr);
            keyMaterials.Add(motes, dragonwarth);

            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            
        }
    }
}