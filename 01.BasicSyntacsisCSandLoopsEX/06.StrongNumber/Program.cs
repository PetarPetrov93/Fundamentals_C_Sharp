namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int number = input;
            int digit = 0;
            int sumNums = 0;
            int factorial = 1;

            for (int i = input; i > 0; i = i/10)
            {
                factorial = 1;

                for (int j = 1; j <= i%10; j++)
                {
                    factorial *= j;
                }
                sumNums += factorial;
            }
           

            if (input == sumNums)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

           
        }
    }
}