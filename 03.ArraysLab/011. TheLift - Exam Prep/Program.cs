namespace _011._TheLift___Exam_Prep
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

            
            for (int i = 0; i < lift.Length; i++)
            {
                
                while (lift[i] < 4 && people > 0)
                {
                    lift[i]++;
                    people--;
                    
                }   
                
            }
            if (lift.Sum() % 4 == 0 && people == 0)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (lift.Sum() % 4 != 0 && people == 0)
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