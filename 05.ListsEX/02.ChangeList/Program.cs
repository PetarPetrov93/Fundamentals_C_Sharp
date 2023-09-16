namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandToArray = command.Split().ToArray();
                int element = int.Parse(commandToArray[1]);

                if (commandToArray[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (commandToArray[0] == "Insert")
                {
                    int position = int.Parse(commandToArray[2]);

                    numbers.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}