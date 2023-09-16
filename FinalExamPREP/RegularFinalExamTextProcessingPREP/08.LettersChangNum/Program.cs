using System.Text;

namespace _08.LettersChangNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal result = 0;

            foreach (var word in input)
            {
                int frontLetterABPosition = char.ToUpper(word[0]) - 64;
                int lastLetterABPosition = char.ToUpper(word[word.Length-1]) - 64;

                StringBuilder numberAsString = new StringBuilder();

                for (int i = 1; i < word.Length-1; i++)
                {
                    numberAsString.Append(word[i]);
                }

                decimal number = decimal.Parse(numberAsString.ToString());
                
                if (char.IsUpper(word[0]))
                {
                    number /= frontLetterABPosition;
                }
                else
                {
                    number *= frontLetterABPosition;
                }
                if (char.IsUpper(word[word.Length-1]))
                {
                    number -= lastLetterABPosition;
                }
                else
                {
                    number += lastLetterABPosition;
                }
                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}