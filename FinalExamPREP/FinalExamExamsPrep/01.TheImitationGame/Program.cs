namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string cmd;

            while ((cmd = Console.ReadLine()) != "Decode")
            {
                string[] cmdArr = cmd.Split("|");

                if (cmdArr[0] == "Move")
                {
                    int lettersToMoveNum = int.Parse(cmdArr[1]);

                    string substringToMove = message.Substring(0, lettersToMoveNum);

                    message = message.Remove(0, lettersToMoveNum);
                    message = message.Insert(message.Length, substringToMove);
                }
                else if (cmdArr[0] == "Insert")
                {
                    int index = int.Parse(cmdArr[1]);
                    string value = cmdArr[2];
                    message = message.Insert(index, value);
                }
                else if (cmdArr[0] == "ChangeAll")
                {
                    string substringToReplace = cmdArr[1];
                    string replacement = cmdArr[2];

                    message = message.Replace(substringToReplace, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}