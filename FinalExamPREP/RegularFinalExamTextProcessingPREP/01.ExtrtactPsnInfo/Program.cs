namespace _01.ExtrtactPsnInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int nameStartingIndex = input.IndexOf('@')+1;
                int nameEndingIndex = input.LastIndexOf('|');
                int nameLength = nameEndingIndex - nameStartingIndex;

                int ageStartindex = input.IndexOf('#')+1;
                int ageEndingindex = input.LastIndexOf('*');
                int ageLength = ageEndingindex - ageStartindex;

                string name = input.Substring(nameStartingIndex, nameLength);
                string age = input.Substring(ageStartindex, ageLength);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}