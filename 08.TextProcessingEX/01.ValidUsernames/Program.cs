using System.Diagnostics;
using System.Text;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            List<string> validUsernames = new List<string>();
            bool isValid = true;

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (char letter in username)
                    {

                        if (!(letter == '-' || letter == '_' || (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z') ||
                            (letter >= 0 && letter <= 9)))
                        {
                            isValid = false;
                            break;
                        }
                        
                    }
                    if (isValid)
                    {
                        validUsernames.Add(username);
                    }
                    isValid = true;
                }
                
            }
            foreach (string username in validUsernames)
            {
                Console.WriteLine(username);
            }

        }
    }
}