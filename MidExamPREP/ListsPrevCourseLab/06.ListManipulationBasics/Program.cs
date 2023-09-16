namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            int value = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Add")
                {
                    value = int.Parse(command[1]);
                    list.Add(value);
                }
                else if (command[0] == "Remove")
                {
                    value = int.Parse(command[1]);
                    list.Remove(value);
                }
                else if (command[0] == "RemoveAt")
                {
                    value = int.Parse(command[1]);
                    list.RemoveAt(value);
                }
                else if (command[0] == "Insert")
                {
                    value = int.Parse(command[1]);
                    int indexToAddAt = int.Parse(command[2]);
                    list.Insert(indexToAddAt, value);

                }

            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}