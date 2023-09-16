using System.Text;

namespace _05.DigitsLtrsOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  text = Console.ReadLine();
            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder symbol = new StringBuilder();

            // you can also use one foreach with ifs inside - possibly the more optimal option
            
            foreach (char ch in text.Where( x=> char.IsDigit(x)))
            {
                digit.Append(ch);  
            }
            foreach (char ch in text.Where(x => char.IsLetter(x)))
            {
                letter.Append(ch);
            }
            foreach (char ch in text.Where(x => !char.IsLetterOrDigit(x)))
            {
                symbol.Append(ch);
            }
            Console.WriteLine(digit.ToString());
            Console.WriteLine(letter.ToString());
            Console.WriteLine(symbol.ToString());
        }
    }
}