namespace _02.AsciiSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            string symbolsToCheck = Console.ReadLine();
            int sum = 0;

            foreach (var sym in symbolsToCheck)
            {
                if (sym > symbol1 && sym < symbol2)
                {
                    sum += sym;
                }
            }
            Console.WriteLine(sum);

        }
    }
}