using System.Runtime.CompilerServices;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string cmd;

            while ((cmd = Console.ReadLine()) != "Generate")
            {
                string[] cmdArr = cmd.Split(">>>");

                if (cmdArr[0] == "Contains")
                {
                    string substring = cmdArr[1];
                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmdArr[0] == "Flip")
                {
                    if (cmdArr[1] == "Upper")
                    {
                        int startIndex = int.Parse(cmdArr[2]);
                        int endIndex = int.Parse(cmdArr[3]);

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char currentLetter = rawActivationKey[i];
                            if (char.IsLetter(currentLetter) && char.IsLower(currentLetter))
                            {
                                char currLetterToUpper = char.ToUpper(currentLetter);
                                rawActivationKey = rawActivationKey.Remove(i, 1);
                                rawActivationKey = rawActivationKey.Insert(i, currLetterToUpper.ToString());
                            }   
                        }
                        Console.WriteLine(rawActivationKey);
                    }
                    else if (cmdArr[1] == "Lower")
                    {
                        int startingIndex = int.Parse(cmdArr[2]);
                        int endingIndex = int.Parse(cmdArr[3]);

                        for (int i = startingIndex; i < endingIndex; i++)
                        {
                            char currentLetter = rawActivationKey[i];
                            if (char.IsLetter(currentLetter) && char.IsUpper(currentLetter))
                            {
                                char currLetterToLower = char.ToLower(currentLetter);
                                rawActivationKey = rawActivationKey.Remove(i, 1);
                                rawActivationKey = rawActivationKey.Insert(i, currLetterToLower.ToString());
                                
                            }
                        }
                        Console.WriteLine(rawActivationKey);

                    }
                }
                else if (cmdArr[0] == "Slice")
                {
                    int startIndex = int.Parse(cmdArr[1]);
                    int endIndex = int.Parse(cmdArr[2]);
                    int count = endIndex - startIndex;
                    rawActivationKey = rawActivationKey.Remove(startIndex, count);
                    Console.WriteLine(rawActivationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}