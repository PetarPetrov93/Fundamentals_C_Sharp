namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort lostGames = ushort.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            ushort headsetsTrashed = 0;
            ushort miceTrashed = 0;
            ushort keyboardsTrashed = 0;
            ushort displaysTrashed = 0;
            float totalExpenses = 0;
            
            ushort counter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetsTrashed++;
                }
                if (i % 3 ==0)
                {
                    miceTrashed++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardsTrashed++;

                    counter++;
                }
                if (counter == 2)
                {
                    counter = 0;
                    displaysTrashed++;

                }
            }
            totalExpenses = (headsetsTrashed * headsetPrice) + (miceTrashed * mousePrice) + (keyboardsTrashed * keyboardPrice) + (displaysTrashed * displayPrice);
            
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");

        }
    }
}