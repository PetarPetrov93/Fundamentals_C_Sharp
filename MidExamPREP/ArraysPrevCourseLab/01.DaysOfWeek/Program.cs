namespace _01.DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (input <= 0 || input > 7) 
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                for (int i = 0; i < daysOfWeek.Length; i++)
                {
                    if (input == i+1)
                    {
                        Console.WriteLine(daysOfWeek[i]);
                    }
                }
            }
        }
    }
}