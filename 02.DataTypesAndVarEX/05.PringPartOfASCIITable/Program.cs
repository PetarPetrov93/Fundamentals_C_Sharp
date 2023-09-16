namespace _05.PringPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort startingIndex = ushort.Parse(Console.ReadLine());
            ushort endingIndex = ushort.Parse(Console.ReadLine());
            char letter;

            for (int i = startingIndex; i <= endingIndex; i++)
            {
                letter = (char)i;
                Console.Write(letter + " ");
            }
        }
    }
}