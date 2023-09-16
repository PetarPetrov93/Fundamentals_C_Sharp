namespace _008._MovingTarget___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                if (command[0] == "Shoot")
                {
                    Shoot(targets, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "Add")
                {
                    Add(targets, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "Strike")
                {
                    Strike(targets, int.Parse(command[1]), int.Parse(command[2]));
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }
        static void Shoot (List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count) 
            {
                targets[index] -= power;
                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
        }
        static void Add (List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }
        static void Strike (List<int>  targets, int index, int radius)
        {
            
            if (index - radius < 0 || index + radius >= targets.Count)
            {
                Console.WriteLine("Strike missed!");
            }
            else
            {
                
                int startingIndex = index - radius;
                int count = radius * 2 + 1; // +1 because this represents the count and we have to include the index as well (we need to add 1)
                targets.RemoveRange(startingIndex, count); //RemoveRange ( starting index, COUNT!!!!)
                
            }
        }
    }
}