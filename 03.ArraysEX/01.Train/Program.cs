namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] wagons = new int[input];

            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                int passangers = int.Parse(Console.ReadLine());
                sum += passangers;
                wagons[i] = passangers;
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum);
            

        }
    }
}