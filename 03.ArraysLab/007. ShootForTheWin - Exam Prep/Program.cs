namespace _007._ShootForTheWin___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int valueToAddOrSubstract = 0;

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index >= 0 && index < targets.Length) 
                {
                    if (targets[index] >= 0)
                    {
                        valueToAddOrSubstract = targets[index];
                        targets[index] = -1;
                        AddOrSubstractValue(targets, valueToAddOrSubstract);
   
                    }

                }
            }
            Console.WriteLine($"Shot targets: {targets.Count(x => x == -1)} -> {string.Join(" ", targets)}");

        }
        static void AddOrSubstractValue(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0 && arr[i] <= value) 
                {
                    arr[i] += value;
                }
                else if (arr[i] >= 0 && arr[i] > value) 
                {
                    arr[i] -= value;
                }
            }

        }
        
    }
}