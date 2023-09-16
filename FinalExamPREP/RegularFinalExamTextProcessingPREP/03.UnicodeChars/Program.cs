using System.Text;

namespace _03.UnicodeChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     
            string input = Console.ReadLine();
            StringBuilder unicode = new StringBuilder();
            foreach (var symbol in input)
            {
                unicode.Append('\\');
                unicode.Append(((int)symbol).ToString("x4"));
            }
            Console.WriteLine(unicode.ToString());

        }
    }
}