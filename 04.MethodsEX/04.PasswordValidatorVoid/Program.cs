using System.Diagnostics.SymbolStore;

namespace _04.PasswordValidatorVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOT FINISHED!!!
            
            string password = Console.ReadLine();
            
            LengthCheck(password);
            LettersAndDigits(password);
            TwoNumbersCheck(password);
            
            //Console.WriteLine("Password is valid");
        }
        public static void LengthCheck(string pass)
        {
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
               
            }
            
        }
        public static void LettersAndDigits(string symbolsCheck)
        {
            for (int i = 0; i < symbolsCheck.Length; i++)
            {
                if ((symbolsCheck[i] < 48 || symbolsCheck[i] > 57) && (symbolsCheck[i] < 65 || symbolsCheck[i] > 90) && (symbolsCheck[i] < 97 || symbolsCheck[i] > 122))
                {

                    Console.WriteLine("Password must consist only of letters and digits");
                    break;

                }

            }
            
        }
        public static void TwoNumbersCheck(string NumbersCheck)
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
                Console.WriteLine("Password must have at least 2 digits");
            }
            

        }
    }
}