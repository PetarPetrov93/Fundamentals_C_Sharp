namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string cmd;

            while ((cmd = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArr = cmd.Split(":|:");

                if (cmdArr[0] == "InsertSpace")
                {
                    int index = int.Parse(cmdArr[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");

                    Console.WriteLine(concealedMessage);
                }
                else if (cmdArr[0] == "Reverse")
                {
                    string substring = cmdArr[1];

                    if (concealedMessage.Contains(substring))
                    {
                        int startingIndex = concealedMessage.IndexOf(substring);

                        concealedMessage = concealedMessage.Remove(startingIndex, substring.Length);

                        char[] substringAsCharArr = substring.ToCharArray();
                        Array.Reverse(substringAsCharArr);
                        substring = string.Join("",substringAsCharArr).ToString();
                        concealedMessage += substring;

                        Console.WriteLine(concealedMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdArr[0] == "ChangeAll")
                {
                    string substring = cmdArr[1];
                    string replacement = cmdArr[2];

                    concealedMessage = concealedMessage.Replace(substring, replacement);
                    Console.WriteLine(concealedMessage);
                }
            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}