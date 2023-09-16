namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startingIndexOfFileName = input.LastIndexOf('\\') + 1;

            int endIndexOfFileName = input.LastIndexOf('.');

            string fileName = input.Substring(startingIndexOfFileName, endIndexOfFileName - startingIndexOfFileName);
            string extension = input.Substring(endIndexOfFileName + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}