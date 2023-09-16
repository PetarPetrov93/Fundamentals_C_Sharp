namespace _02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string cmd;

            while ((cmd = Console.ReadLine()) != "Finish")
            {
                string[] cmdArr = cmd.Split();
                string command = cmdArr[0];
                int value = int.Parse(cmdArr[1]);

                if (command == "Add")
                {
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    if (numbers.Contains(value))
                    {
                        numbers.Remove(value);
                    }
                }
                else if (command == "Replace")
                {
                    int replacement = int.Parse(cmdArr[2]);

                    if (numbers.Contains(value))
                    {
                        int indexOfValueToReplace = numbers.IndexOf(value);
                        numbers.RemoveAt(indexOfValueToReplace);
                        numbers.Insert(indexOfValueToReplace, replacement);
                    }
                }
                else if (command == "Collapse")
                {
                    numbers.RemoveAll(x => x < value);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}