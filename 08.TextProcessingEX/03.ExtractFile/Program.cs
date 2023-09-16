namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // with REGEX -> "\\" the first \ is regex!
            string[] directory = Console.ReadLine().Split("\\");
            
            string[] fileNameAndExtention = directory[directory.Length-1].Split(".");

            Console.WriteLine($"File name: {fileNameAndExtention[0]}");
            Console.WriteLine($"File extension: {fileNameAndExtention[1]}");

        }
    }
}