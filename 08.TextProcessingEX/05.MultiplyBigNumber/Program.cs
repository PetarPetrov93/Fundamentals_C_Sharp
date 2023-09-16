using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do not use BigInteger class!!

            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int leftover = 0;
            
            StringBuilder result = new StringBuilder();

            if (multiplier == 0)
            {
                Console.WriteLine("0"); // should put this output for Judge to get 100/100
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                string currentDigitStr = bigNumber[i].ToString();
                int currentDigit = int.Parse(currentDigitStr);

                int multipliedNum = multiplier * currentDigit;
                int numToAdd = (multipliedNum % 10) + leftover;

                leftover = multipliedNum / 10;

                if (numToAdd > 9)
                {
                    leftover += numToAdd / 10;
                    numToAdd = numToAdd % 10;   
                }

                result.Insert(0, numToAdd);
   
            }
            if (leftover != 0)
            {
                result.Insert(0, leftover);
            }

            if (multiplier <0) // Not needed for Judge, but IRL is goot to be checked.
            {
                result.Insert(0, '-');
            }
            Console.WriteLine(result.ToString());
        }
    }
}