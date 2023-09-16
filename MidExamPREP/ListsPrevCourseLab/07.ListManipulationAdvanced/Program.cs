namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            int value = 0;
            List<int> OriginalList = new List<int>(list);
            int compareNum = 0;
            bool areEqual = true;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Add")
                {
                    value = int.Parse(command[1]);
                    list.Add(value);
                    areEqual = false;
                }
                else if (command[0] == "Remove")
                {
                    value = int.Parse(command[1]);
                    list.Remove(value);
                    areEqual = false;
                }
                else if (command[0] == "RemoveAt")
                {
                    value = int.Parse(command[1]);
                    list.RemoveAt(value);
                    areEqual = false;
                }
                else if (command[0] == "Insert")
                {
                    value = int.Parse(command[1]);
                    int indexToAddAt = int.Parse(command[2]);
                    list.Insert(indexToAddAt, value);
                    areEqual = false;

                }
                else if (command[0] == "Contains")
                {
                    compareNum = int.Parse(command[1]);
                    if (list.Contains(compareNum))
                    {
                        Console.WriteLine("Yes");
                    }
                    else if (!list.Contains(compareNum))
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    Console.Write(string.Join(" ", list.Where(x => x % 2 == 0)));
                    Console.WriteLine();
                }
                else if (command[0] == "PrintOdd")
                {
                    Console.Write(string.Join(" ", list.Where(x => x % 2 != 0)));
                    Console.WriteLine();
                }
                else if (command[0] == "GetSum")
                {
                    Console.Write(string.Join(" ", list.Sum()));
                    Console.WriteLine();
                }
                else if (command[0] == "Filter")
                {
                    if (command[1] == "<")
                    {
                        compareNum = int.Parse(command[2]);
                        Console.Write(string.Join(" ", list.Where(x => x < compareNum)));
                        Console.WriteLine();
                    }
                    else if (command[1] == ">")
                    {
                        compareNum = int.Parse(command[2]);
                        Console.Write(string.Join(" ", list.Where(x => x > compareNum)));
                        Console.WriteLine();
                    }
                    else if (command[1] == ">=")
                    {
                        compareNum = int.Parse(command[2]);
                        Console.Write(string.Join(" ", list.Where(x => x >= compareNum)));
                        Console.WriteLine();
                    }
                    else if (command[1] == "<=")
                    {
                        compareNum = int.Parse(command[2]);
                        Console.Write(string.Join(" ", list.Where(x => x <= compareNum)));
                        Console.WriteLine();
                    }
                }
            }
            if (!areEqual)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            
            

        }
    }
}