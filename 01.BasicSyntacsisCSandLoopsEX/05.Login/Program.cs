namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            string password = string.Empty;
            int incorrectCounter = 0;

            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }
            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    incorrectCounter++;

                    if (incorrectCounter <=3)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    
                }
            }
            
        }
    }
}