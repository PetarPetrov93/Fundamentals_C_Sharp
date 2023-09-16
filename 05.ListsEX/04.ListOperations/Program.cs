namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            int count = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split().ToArray();
                if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        count = int.Parse(command[2]);
                        int firstNum = 0;
                        for (int i = 0; i < count; i++)
                        {
                            firstNum = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNum);
                        }
                    }
                    else if (command[1] == "right")
                    {
                        count = int.Parse(command[2]);
                        int lastNum = 0;
                        for (int j = 0; j < count; j++)
                        {
                            lastNum = (numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1]);
                            numbers.Insert(0, lastNum);
                        }
                        
                    }
                }
                else if (command[0] == "Add")
                {
                    int numToAdd = int.Parse(command[1]);
                    numbers.Add(numToAdd);
                }
                else
                {
                    if (command[0] == "Remove")
                    {
                        int removeAt = int.Parse(command[1]);
                        if (removeAt < 0 || removeAt > numbers.Count-1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(removeAt);
                        }
                    }
                    else if (command[0] == "Insert")
                    {
                        int insert = int.Parse(command[2]);
                        int numToInsert = int.Parse(command[1]);
                        if (insert < 0 || insert > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            
                        }
                        else
                        {
                            numbers.Insert(insert, numToInsert);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}