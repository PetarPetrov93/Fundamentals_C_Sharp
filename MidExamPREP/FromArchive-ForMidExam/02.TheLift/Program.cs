using System.Collections.Immutable;

namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleQueueing = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Cabbins(lift, peopleQueueing);

        }
        static void Cabbins(int[] lift, int people)
        {

            if (people <= 0)
            {
                if (lift.Sum() % 4 != 0)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", lift));
                    return;
                }
                else
                {
                    int counter = 0;
                    foreach (int i in lift)
                    {
                        if (i == 4)
                        {
                            counter++;
                        }
                    }
                    if (counter == lift.Count())
                    {
                        Console.WriteLine(string.Join(" ", lift));
                        return;
                    }
                    else
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", lift));
                        return;
                    }
                    
                }
                
            }
            for (int i = 0; i < lift.Length; i++)
            {

                while (lift[i] < 4 && people > 0)
                {
                    lift[i]++;
                    people--;

                }


            }
            if (lift.Sum() / 4 == lift.Count() && people == 0)
            {
                Console.WriteLine(string.Join(" ", lift));
                
            }
            else if (people == 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (lift.Sum() % 4 == 0 && people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }

        }

    }
}