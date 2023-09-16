namespace _02.ManipulateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // now it's 03.Safe Manipulation
            
            string[] words = Console.ReadLine().Split();
            string command;

            while((command = Console.ReadLine()) != "END")
            {
                
                string[] cmdArr = command.Split();

                if (cmdArr[0] == "Reverse")
                {
                    Array.Reverse(words);
                }
                else if (cmdArr[0] == "Distinct")
                {
                    for (int j = 0; j < words.Length-1; j++)
                    {
                        for (int k = j+1; k < words.Length; k++)
                        {
                            if (words[j] == words[k])
                            {
                                words[k] = string.Empty;
                               
                            }
                        }
                    }
                }
                else if (cmdArr[0] == "Replace")
                {
                    int index = int.Parse(cmdArr[1]);
                    if (index >= 0 && index < words.Length)
                    {
                        words[index] = cmdArr[2];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine(string.Join(", ", words.Where(x => x != string.Empty)));
        }
    }
}