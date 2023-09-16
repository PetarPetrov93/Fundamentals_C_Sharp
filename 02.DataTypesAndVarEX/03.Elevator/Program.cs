using System.Diagnostics.Metrics;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int liftCapacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)persons/liftCapacity);
            Console.WriteLine(courses);


        }
    }
}