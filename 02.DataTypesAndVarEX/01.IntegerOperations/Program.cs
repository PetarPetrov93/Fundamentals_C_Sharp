namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            b += a;
            int calc = (b / c) * d;
            Console.WriteLine(calc);

        }
    }
}