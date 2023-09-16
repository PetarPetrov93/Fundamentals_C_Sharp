namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

           
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i].Length < 3 || input[i].Length > 16)
                {
                    continue;
                }
                char[] charArr = input[i].ToCharArray();
                
                for (int currChIndex = 0; currChIndex < charArr.Length; currChIndex++)
                {
                    if (!(char.IsLetterOrDigit(charArr[currChIndex]) || charArr[currChIndex] == '-' || charArr[currChIndex] == '_'))
                    {
                        break;
                    }
                    if (currChIndex == charArr.Length-1)
                    {
                        Console.WriteLine(input[i]);
                    }
                }
            }
            
        }
    }
}