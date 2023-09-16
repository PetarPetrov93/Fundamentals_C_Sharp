namespace _09.PalidromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
           
            while ((input = Console.ReadLine()) != "END")
            {
                int number = int.Parse(input);
                List<int> list = new List<int>();

                while (number != 0)
                {
                    int currentNum = number % 10;
                    number /= 10;
                    list.Insert(0, currentNum);

                }
                Console.WriteLine(IsPalidrome(list));
            }
        }
        static bool IsPalidrome(List<int> checkList)
        {
            for (int i = 0, j = checkList.Count-1; i < checkList.Count/2; i++, j--)
            {
                if (checkList[i] != checkList[j])
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}