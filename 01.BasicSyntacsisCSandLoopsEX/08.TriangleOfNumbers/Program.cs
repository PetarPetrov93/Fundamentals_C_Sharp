namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int column = 1; column <= num; column++)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        }
    }
}