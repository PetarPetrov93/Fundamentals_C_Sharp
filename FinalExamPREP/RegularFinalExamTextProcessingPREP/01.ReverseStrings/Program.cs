namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                char[] reversedWordChar = input.ToCharArray();

                Array.Reverse(reversedWordChar);

                string reversedWord = new string(reversedWordChar);

                Console.WriteLine($"{input} = {reversedWord}");

            }
        }
    }
}