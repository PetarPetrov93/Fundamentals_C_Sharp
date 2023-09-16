namespace _02.AMinerTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourse = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Dictionary<string, int> store = new Dictionary<string, int>();

            if (!store.ContainsKey(resourse))
            {
                store.Add(resourse, 0);
            }
            store[resourse] += quantity;
        }
    }
}