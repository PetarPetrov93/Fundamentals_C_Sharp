using System.Text;

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string word = Console.ReadLine();
            StringBuilder newWord = new StringBuilder();
            int numberSum = 0;
            int currentCharIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                while (numbers[i] > 0)
                {
                    numberSum += numbers[i] % 10;
                    numbers[i] /= 10;
                }

                if (numberSum < word.Length)
                {
                    char letterr = word[numberSum];
                    word = word.Remove(numberSum, 1);
                    newWord.Append(letterr);
                }
                else
                {
                    while (numberSum >= word.Length)
                    {
                        numberSum -= word.Length;
                    }
                    char letterr = word[numberSum - 1];
                    word = word.Remove(numberSum - 1, 1);
                    newWord.Append(letterr);
                }
                numberSum = 0;
                
            }
           
            Console.WriteLine(newWord.ToString());


        }
    }
}