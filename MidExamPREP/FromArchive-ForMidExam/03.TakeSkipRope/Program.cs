using System.Text;

namespace _03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string initialString = Console.ReadLine();
            List<char> stringAsCharArr = initialString.ToList();
            List<int> numbers = new List<int>();
            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();

            foreach (var symbol in stringAsCharArr.Where(x=> char.IsDigit(x)))
            {
                numbers.Add(int.Parse(symbol.ToString()));
            }

            stringAsCharArr.RemoveAll(x => char.IsDigit(x));

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenNums.Add(numbers[i]);
                }
                else
                {
                    oddNums.Add(numbers[i]);
                }   
            }

            int skipCount = 0;
            int takeCount = 0;
            StringBuilder newWord = new StringBuilder();
            for (int i = 0; i < evenNums.Count; i++)
            {
                takeCount = evenNums[i];
                skipCount = oddNums[i];

                if (takeCount >= stringAsCharArr.Count)
                {
                    takeCount = stringAsCharArr.Count;
                }

                for (int j = 0; j < takeCount; j++)
                {
                    newWord.Append(stringAsCharArr[j]);
                }

                stringAsCharArr.RemoveRange(0, takeCount);
                stringAsCharArr.RemoveRange(0, skipCount);   
            }
            Console.WriteLine(newWord.ToString());
        }
    }
}