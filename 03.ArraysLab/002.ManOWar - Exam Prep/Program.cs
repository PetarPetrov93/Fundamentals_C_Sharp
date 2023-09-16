namespace _002.ManOWar___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] warShip = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int maxHealthCapacityOfASection = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] command = input.Split();

                if (command[0] == "Fire")
                {
                    int warShipSectionIndex = int.Parse(command[1]);
                    int warShipDamage = int.Parse(command[2]);

                    if (warShipSectionIndex <= warShip.Length && warShipSectionIndex >= 0)
                    {
                        if (warShipDamage >= warShip[warShipSectionIndex])
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                        else // could need to add <0 for negatives
                        {
                            warShip[warShipSectionIndex] -= warShipDamage;
                        }
                    }
                   
                }
                else if (command[0] == "Defend")
                {
                    int startingIndexDefend = int.Parse(command[1]);
                    int endingIndexDefend = int.Parse(command[2]);
                    int damagePiratShip = int.Parse(command[3]);

                    if (startingIndexDefend >= 0 && endingIndexDefend < pirateShip.Length)
                    {
                        for (int attackedSection = startingIndexDefend; attackedSection <= endingIndexDefend; attackedSection++)
                        {
                            pirateShip[attackedSection] -= damagePiratShip;
                            if (pirateShip[attackedSection] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    int indexOfSectionToRepair = int.Parse(command[1]);
                    int health = int.Parse(command[2]);

                    if (indexOfSectionToRepair >= 0 && indexOfSectionToRepair < pirateShip.Length)
                    {
                        pirateShip[indexOfSectionToRepair] += health;
                        if (pirateShip[indexOfSectionToRepair] > maxHealthCapacityOfASection)
                        {
                            pirateShip[indexOfSectionToRepair] = maxHealthCapacityOfASection;
                        }
                    }

                    

                }
                else if (command[0] == "Status")
                {
                    int countSectionsThatNeedRepairing = 0;
                    foreach (int sections in pirateShip.Where(x => x < maxHealthCapacityOfASection * 0.2)) // may need to be casted to double
                    {
                        countSectionsThatNeedRepairing++;
                    }
                    Console.WriteLine($"{countSectionsThatNeedRepairing} sections need repair.");
                   
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}