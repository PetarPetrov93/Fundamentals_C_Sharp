namespace _8.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());

            double result = Factorial(x) / Factorial(y);
            Console.WriteLine($"{result :f2}");

        }
        static double Factorial(double a) 
        {

            if (a == 0)
            {
                return 1;
            }
            else
            {
                return (a * Factorial(a - 1));
            }
            
            
        }
        
    }
}