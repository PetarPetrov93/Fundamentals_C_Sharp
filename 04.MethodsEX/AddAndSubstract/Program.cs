namespace AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum= int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

           
            Console.WriteLine(SubstractC(SumAandB(firstNum, secondNum), thirdNum));
        }
        static int SumAandB (int a, int b)
        {
            return a + b;
        }
        static int SubstractC( int SumAandB, int c)
        {
            

            return SumAandB - c;


        }
    }
}