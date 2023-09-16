using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder newString = new StringBuilder();

            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentCh = input[i];

                if (currentCh == '>')
                {
                    int currBombPow = GetIntValueOfAChar(input[i + 1]);

                    newString.Append(currentCh);
                    bombPower += currBombPow;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        newString.Append(currentCh);
                    }
                }
                
            }
            Console.WriteLine(newString.ToString());
        }
        static int GetIntValueOfAChar (char currentChar)
        {
            return (int)currentChar - 48;
        }
    }
}