using System.Text;

namespace _08.AnnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArr = command.Split();

                if (cmdArr[0] == "merge")
                {
                    int startIndex = int.Parse(cmdArr[1]);
                    int endIndex = int.Parse(cmdArr[2]);
                    Merge(list, startIndex, endIndex);
                }
                else if (cmdArr[0] == "divide")
                {
                    int index = int.Parse(cmdArr[1]);
                    int partitions = int.Parse(cmdArr[2]);
                    Divide(list, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        static void Merge(List<string> list, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= list.Count)
            {
                endIndex = list.Count-1;
            }
            if (endIndex < 0)
            {
                endIndex = 0;
            }
            if (startIndex >= list.Count)
            {
                startIndex = list.Count - 1;
            }

            int count = endIndex - startIndex;
            StringBuilder concatenatedWords = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                concatenatedWords.Append(list[i]);
            }

            list.RemoveRange(startIndex, count+1);
            list.Insert(startIndex, concatenatedWords.ToString());
        }

        static void Divide(List<string> list, int index, int partitions)
        {
            if (partitions <= 1)
            {
                return;
            }

            string wordToDivide = list[index];
            list.RemoveAt(index);
            string singlePartition = string.Empty;

            if (wordToDivide.Length % partitions == 0)
            {
                int lengthOfPArtitions = wordToDivide.Length / partitions;

                for (int i = 0; i < wordToDivide.Length; i += lengthOfPArtitions)
                {
                    singlePartition += wordToDivide.Substring(i, lengthOfPArtitions);
                    singlePartition += " ";
                }

                string[] newWordsAfterDivision = singlePartition.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Array.Reverse(newWordsAfterDivision);
                
                foreach (string newWord in newWordsAfterDivision)
                {
                    list.Insert(index, newWord);
                }

            }
            else
            {
                int lengthOfPartitions = wordToDivide.Length / partitions;
                int LastElement = lengthOfPartitions + (wordToDivide.Length % partitions);

                for (int i = 0; i < wordToDivide.Length-LastElement; i += lengthOfPartitions)
                {
                    singlePartition += wordToDivide.Substring(i, lengthOfPartitions);
                    singlePartition += " ";
                }

                singlePartition += wordToDivide.Substring(wordToDivide.Length - LastElement, LastElement);

                string[] newWordsAfterDivision = singlePartition.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Array.Reverse(newWordsAfterDivision);

                foreach (string newWord in newWordsAfterDivision)
                {
                    list.Insert(index, newWord);
                }
            }
        }
    }
}