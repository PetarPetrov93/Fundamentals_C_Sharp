namespace _01.DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                if (i == input - 1)
                {
                    Console.WriteLine(daysOfWeek[i]);
                    break;
                }
                else if (input > 7 || input <1)   
                {
                    Console.WriteLine("Invalid day!");
                    break;
                }
            }
        }
    }
}