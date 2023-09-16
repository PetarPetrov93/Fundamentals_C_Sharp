namespace _1.EncryptSortPrintArrayMoreEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] encryptedNames = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    char currentLetter = input[j];

                    int letterASCII = (int)currentLetter;

                    if (Char.ToLower(currentLetter) == 'a' || Char.ToLower(currentLetter) == 'e' || Char.ToLower(currentLetter) == 'o' ||
                        Char.ToLower(currentLetter) == 'i' || Char.ToLower(currentLetter) == 'u')
                    {
                        sum += letterASCII * input.Length;
                    }
                    else
                    {
                        sum += letterASCII / input.Length;
                    }
                }
                encryptedNames[i] = sum;
                sum = 0;
            }
            Array.Sort(encryptedNames);
            foreach (int code in encryptedNames)
            {
                Console.WriteLine(code);
            }
        }
    }
}