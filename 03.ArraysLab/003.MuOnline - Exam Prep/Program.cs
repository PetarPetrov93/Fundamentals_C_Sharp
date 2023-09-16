namespace _003.MuOnline___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|").ToArray();

            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            int bestRoomIndex = 0;
            bool youWon = true;

            for (int i = 0; i < rooms.Length; i++)
            {

                string[] commandAndNumber = rooms[i].Split().ToArray();
                int number = int.Parse(commandAndNumber[1]);

                

                if (commandAndNumber[0] == "potion")
                {
                    if (health + int.Parse(commandAndNumber[1]) > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    
                    else
                    {
                        health += int.Parse(commandAndNumber[1]);
                        Console.WriteLine($"You healed for {commandAndNumber[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    
                }
                else if (commandAndNumber[0] == "chest")
                {
                    bitcoins += int.Parse(commandAndNumber[1]);
                    Console.WriteLine($"You found {commandAndNumber[1]} bitcoins.");
                }
                else
                {
                    if (bestRoom < number)
                    {
                        bestRoom = number;
                        bestRoomIndex = i + 1;
                    }

                    health -= int.Parse(commandAndNumber[1]);
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {commandAndNumber[0]}.");
                        Console.WriteLine($"Best room: {bestRoomIndex}");
                        youWon = false;
                        break;

                    }
                    else
                    {
                        
                        Console.WriteLine($"You slayed {commandAndNumber[0]}.");
                    }
                }


            }
            if (youWon)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}