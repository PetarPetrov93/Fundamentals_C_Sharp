using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            StringBuilder newSequence = new StringBuilder();

            for (int i = 0; i < sequence.Length-1; i++)
            {
                if (sequence[i] == sequence[i+1])
                {
                    continue;
                }
                newSequence.Append(sequence[i]);
            }
            newSequence.Append(sequence[sequence.Length - 1]);
            Console.WriteLine(newSequence.ToString());
        }
    }
}