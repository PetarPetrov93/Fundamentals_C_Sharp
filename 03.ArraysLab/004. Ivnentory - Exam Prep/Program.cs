namespace _004._Ivnentory___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string input;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(" - ");

                if (commands[0] == "Collect")
                {
                    if (!inventory.Contains(commands[1]))
                    {
                        inventory.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Drop")
                {
                    inventory.Remove(commands[1]);
                    
                }
                else if (commands[0] == "Combine Items")
                {
                    string[] itemsToCombine = commands[1].Split(":");

                    if (inventory[inventory.Count-1] == itemsToCombine[0])
                    {
                        inventory.Add(itemsToCombine[1]);
                    }
                    else if (inventory.Contains(itemsToCombine[0]))
                    {
                        int indexOfElementToCombine = inventory.IndexOf(itemsToCombine[0]) + 1;
                        inventory.Insert(indexOfElementToCombine, itemsToCombine[1]);
                    }
                    
                }
                else if (commands[0] == "Renew")
                {
                    string itemToRenew = commands[1];

                    if (inventory.Contains(commands[1]))
                    {
                        inventory.Remove(itemToRenew);
                        inventory.Add(itemToRenew);
                    }
                    
                }

            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}