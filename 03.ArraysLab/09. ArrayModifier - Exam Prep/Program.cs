namespace _09._ArrayModifier___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArr = command.Split();

                if (cmdArr[0] == "swap")
                {
                    Swap(input, int.Parse(cmdArr[1]), int.Parse(cmdArr[2]));
                }
                else if (cmdArr[0] == "multiply")
                {
                    Multiply(input, int.Parse(cmdArr[1]), int.Parse(cmdArr[2]));
                }
                else if (cmdArr[0] == "decrease")
                {
                    Decrease(input);
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
        static void Swap(int[] inputArray, int index1, int index2)
        {
            int firstElementToSwap = inputArray[index1];
            int secondElementToSwap = inputArray[index2];

            inputArray[index1] = secondElementToSwap;
            inputArray[index2] = firstElementToSwap;
        }
        static void Multiply(int[] inputArray, int index1, int index2)
        {
            inputArray[index1] *= inputArray[index2];
        }
        static void Decrease(int[] inputArray) 
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] -= 1;
            }
        }
    }
}