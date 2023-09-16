namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
               string product = Console.ReadLine();
                list.Add(product);
            }
            list.Sort();
            foreach (var item in list)
            {
                counter++;
                Console.WriteLine($"{counter}.{item}");
            }
        }
    }
}