namespace _2.PascalTriangleMoreEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= input; i++)
            {

                int[] initialArray = new int[1];
                initialArray[0] = 1;
                initialArray[initialArray.Length - 1] = 1;


                for (int j = 0; j < initialArray.Length-1; j++)
                 {
                    int[] newArray = new int[initialArray.Length + 1];
                    newArray = initialArray;
                    newArray[newArray.Length-1] = 1;

                    newArray[j+1] = newArray[j] + newArray[j + 1];
                    

                }
                 

                Console.WriteLine(string.Join(" ", initialArray));
                Console.WriteLine();
                

            }
        }
    }
}