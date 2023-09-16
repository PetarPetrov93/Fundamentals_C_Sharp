using System.Text;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string cmd;

            while ((cmd = Console.ReadLine()) != "Done")
            {
                string[] cmdArr = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArr[0] == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {  
                        sb.Append(password[i]);   
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (cmdArr[0] == "Cut")
                {
                    int index = int.Parse(cmdArr[1]);
                    int length = int.Parse(cmdArr[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (cmdArr[0] == "Substitute")
                {
                    string substring = cmdArr[1];
                    string replacement = cmdArr[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, replacement);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}