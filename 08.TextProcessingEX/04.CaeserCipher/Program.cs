using System.Text;

namespace _04.CaeserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = (char)(input[i] +3);
                encryptedText.Append(currentLetter);
            }
            Console.WriteLine(encryptedText.ToString());
        }
    }
}