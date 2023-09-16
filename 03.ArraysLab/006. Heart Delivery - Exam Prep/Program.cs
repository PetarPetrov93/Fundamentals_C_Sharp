namespace _006._Heart_Delivery___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            int cupidPosition = 0;

            string input;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();

                cupidPosition += int.Parse(command[1]);

                if (cupidPosition >= neighbourhood.Length)
                {
                    cupidPosition = 0;
                }
                neighbourhood[cupidPosition] -= 2;

                if (neighbourhood[cupidPosition] == 0)
                {
                    Console.WriteLine($"Place {cupidPosition} has Valentine's day.");
                    
                    continue;
                }
                
                if (neighbourhood[cupidPosition] < 0)
                {
                    
                    Console.WriteLine($"Place {cupidPosition} already had Valentine's day.");
                    continue;
                }

             

            }
            Console.WriteLine($"Cupid's last position was {cupidPosition}.");

            
            if (neighbourhood.Max() <= 0) // .Sum() is the same as .Sum(x => x)
            {
                Console.WriteLine("Mission was successful.");
            }
            else if (neighbourhood.Max() > 0)
            {
                Console.WriteLine($"Cupid has failed {neighbourhood.Count(x => x > 0)} places.");
            }
        }
    }
}