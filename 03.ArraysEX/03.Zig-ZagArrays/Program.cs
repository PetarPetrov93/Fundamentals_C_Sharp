namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] firstArray = new int[input];
            int[] secondArray = new int[input];

            for (int i = 0; i < input; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                if (i % 2 == 0)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else if (i % 2 != 0)
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                }


            }
            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }


        }
    }
}