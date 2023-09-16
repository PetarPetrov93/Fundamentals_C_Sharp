namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte kegs = sbyte.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string BiggestKegModel = string.Empty;

            for (int i = 1; i <= kegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentKegSize = (Math.Pow(radius, 2) * Math.PI * height);
                if (biggestKeg < currentKegSize)
                {
                    biggestKeg = currentKegSize;
                    BiggestKegModel = model;
                }
            }
            Console.WriteLine(BiggestKegModel);
        }
    }
}