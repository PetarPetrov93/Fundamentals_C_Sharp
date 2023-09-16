using System.Xml.Linq;

namespace _012._MemoryGame___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;
            int moves = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                moves++;
                int[] indexes = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                Commands(elements, indexes, moves);

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
                
            }
            if (elements.Count() != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }

            
        }
        static void Commands (List<string> boardWithElements, int[] indexes, int moves)
        {
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];
            if (firstIndex == secondIndex || firstIndex < 0 || secondIndex >= boardWithElements.Count ||
                secondIndex < 0 || firstIndex >= boardWithElements.Count)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                boardWithElements.Insert(boardWithElements.Count / 2, "-" + moves + "a");
                boardWithElements.Insert(boardWithElements.Count / 2, "-" + moves + "a");
            }

            else if (boardWithElements[firstIndex] == boardWithElements[secondIndex])
            {
                Console.WriteLine($"Congrats! You have found matching elements - {boardWithElements[firstIndex]}!");
                if (firstIndex > secondIndex)
                {
                    boardWithElements.RemoveAt(firstIndex);
                    boardWithElements.RemoveAt(secondIndex);
                }
                else if (firstIndex < secondIndex)
                {
                    boardWithElements.RemoveAt(secondIndex);
                    boardWithElements.RemoveAt(firstIndex);
                }
                
            }
            else if (boardWithElements[firstIndex] != boardWithElements[secondIndex])
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}