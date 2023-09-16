using System.Text.RegularExpressions;

namespace _09.MalerahShake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = Console.ReadLine();

            while (Regex.Matches(input, patern).Count >= 2)
            {
                int indexOfPattern = input.IndexOf(patern);
                int indexOfLastPattern = input.LastIndexOf(patern);

                input = input.Remove(indexOfLastPattern, patern.Length);
                input = input.Remove(indexOfPattern, patern.Length);  

                patern = patern.Remove(patern.Length / 2, 1);
                Console.WriteLine("Shake it.");
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}