using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder encryptedMessage = new StringBuilder();

            foreach (char letter in input)
            {
                char newChar = (char)(letter+3);

                encryptedMessage.Append(newChar);
            }
            Console.WriteLine(encryptedMessage.ToString());
        }
    }
}