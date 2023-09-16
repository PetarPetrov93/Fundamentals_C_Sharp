using System.Text;

namespace _06.ReplaceRepChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder newSeuence = new StringBuilder();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    continue;
                }
                newSeuence.Append(input[i]);
            }
            newSeuence.Append(input[input.Length-1]);
            Console.WriteLine(newSeuence.ToString());
        }
    }
}