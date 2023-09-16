using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string correctPassword = string.Empty;
      
           
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                correctPassword += userName[i];
            }
            string password = Console.ReadLine();
            int counter = 1;
            while (password != correctPassword)
            {
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                counter++;

            }
            if (password == correctPassword)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
