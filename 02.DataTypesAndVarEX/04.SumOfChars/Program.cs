namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort lines = ushort.Parse(Console.ReadLine());
            ushort sumOfASCII = 0;

            for (int i = 1; i <= lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sumOfASCII += letter;
            }
            Console.WriteLine($"The sum equals: {sumOfASCII}");
        }
    }
}