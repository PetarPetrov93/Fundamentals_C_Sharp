namespace _005._Gorceires___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split();

                if (command[0] == "Urgent")
                {
                    if (!shoppingList.Contains(command[1]))
                    {
                        shoppingList.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        shoppingList.Remove(command[1]);
                    }
                }
                else if (command[0] == "Correct")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        int indexOfItemToSwap = shoppingList.IndexOf(command[1]);
                        shoppingList.Remove(command[1]);
                        shoppingList.Insert(indexOfItemToSwap, command[2]);
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        string itemToRearrange = command[1];
                        shoppingList.Remove(command[1]);
                        shoppingList.Add(command[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}