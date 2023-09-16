namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // minava v Judge, tuka ne mi zarejda :D
            char startingLetter = char.Parse(Console.ReadLine());
            char endingLetter = char.Parse(Console.ReadLine());

            Range(startingLetter, endingLetter);
        }
        public static void Range(char start, char end)
        {
            if (start > end)
            {
                char reversedStartingIndex = end;
                char reversedEndingIndex = start;

                for (int j = reversedStartingIndex + 1; j < reversedEndingIndex; j++)
                {
                    Console.Write((char)j + " ");
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
            
        }
    }
}