namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static void Matrix(int number) 
        {
            for (int columns = 1; columns <= number; columns++)
            {
                for (int rows = 1; rows <= number; rows++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}