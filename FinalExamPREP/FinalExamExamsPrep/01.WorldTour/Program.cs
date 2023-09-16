namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string cmd;

            while ((cmd = Console.ReadLine()) != "Travel")
            {
                string[] cmdArr = cmd.Split(":");

                if (cmdArr[0] == "Add Stop")
                {
                    int index = int.Parse(cmdArr[1]);
                    string newStop = cmdArr[2];

                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, newStop);                       
                    }
                    Console.WriteLine(text);
                }
                else if (cmdArr[0] == "Remove Stop")
                {
                    int startingIndex = int.Parse(cmdArr[1]);
                    int endingIndex = int.Parse(cmdArr[2]);

                    if ((startingIndex >= 0 && startingIndex < text.Length) && (endingIndex >= 0 && endingIndex < text.Length))
                    {
                        int count = (endingIndex - startingIndex) + 1;
                        text = text.Remove(startingIndex, count);                      
                    }
                    Console.WriteLine(text);
                }
                else if (cmdArr[0] == "Switch")
                {
                    string oldString = cmdArr[1];
                    string newString = cmdArr[2];

                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);   
                    }
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}