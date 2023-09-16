using System.Threading.Channels;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            VowelsCount(input);
        }
        public static void VowelsCount(string vowels) 
        {
            int counter = 0;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == 'a' || vowels[i] == 'e' || vowels[i] == 'o' || vowels[i] == 'i' || vowels[i] == 'u' ||
                    vowels[i] == 'A' || vowels[i] == 'E' || vowels[i] == 'O' || vowels[i] == 'I' || vowels[i] == 'U')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        
    }
}