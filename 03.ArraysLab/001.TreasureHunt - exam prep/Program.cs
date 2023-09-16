namespace _001.TreasureHunt___exam_prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands;

            while ((commands = Console.ReadLine()) != "Yohoho!")
            {
                string[] items = commands.Split();

                if (items[0] == "Loot")
                {
                    for (int i = 1; i < items.Length; i++)
                    {
                        if (!chest.Contains(items[i]))
                        {
                            chest.Insert(0, items[i]);
                        }
                        
                    }
                }
                else if (items[0] == "Drop")
                {
                    int indexOfItemToDrop = int.Parse(items[1]);
                    if (indexOfItemToDrop > chest.Count || indexOfItemToDrop < 0)
                    {
                        continue;
                    }
                    string itemToDrop = chest[indexOfItemToDrop];
                    
                    chest.RemoveAt(indexOfItemToDrop);
                    chest.Add(itemToDrop);
                }
                else if (items[0] == "Steal")
                {
                    int stolenItems = int.Parse(items[1]);
                    
                    if (stolenItems >= chest.Count)
                    {
                        Console.WriteLine(string.Join(", ", chest));
                        chest.Clear();
                    }
                    else
                    {
                        List<string> stolenItemsLis = new List<string>();

                        for (int i = chest.Count-stolenItems; i < chest.Count; i++)
                        {
                            stolenItemsLis.Add(chest[i]);
                            
                        }
                        Console.WriteLine(string.Join(", ", stolenItemsLis));
                        chest.RemoveRange(chest.Count-stolenItems, stolenItems);
                        
                    }

                }
            }
            
            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                int sumOfElementsByLetters = 0;
                foreach (string item in chest) 
                {
                    sumOfElementsByLetters += item.Length;
                }
                double averageGain = (double)sumOfElementsByLetters / chest.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
        }
    }
}