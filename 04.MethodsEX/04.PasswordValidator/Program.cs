namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

        }
        public static string LengthCheck(string pass) 
        {
            if (pass.Length < 6 && pass.Length > 10)
            {
                return "Password must be between 6 and 10 characters";
            }
            else
            {
               return;
            }
        }
        public static string LettersAndDigits(string symbolsCheck)
        {
            for (int i = 0; i < symbolsCheck.Length; i++)
            {
                if ((symbolsCheck[i] < 48 && symbolsCheck[i] > 57) && (symbolsCheck[i] < 65 && symbolsCheck[i] > 90) && (symbolsCheck[i] < 97 && symbolsCheck[i] > 122))
                {
                   
                    return "Password must consist only of letters and digits";
                    
                }
                
            }
            return;
        }
        public static string TwoNumbersCheck (string NumbersCheck)
        {
            int numCounter = 0;

            for (int i = 0; i < NumbersCheck.Length; i++)
            {
                if (NumbersCheck[i] > 48 && NumbersCheck[i] < 57)
                {
                    numCounter++;
                }
            }
            if (numCounter < 2)
            {
                return "Password must have at least 2 digits";
            }

            return;
        }
    }
}