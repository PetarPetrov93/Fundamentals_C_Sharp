namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drumset = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> initialDrumset = new List<int>(drumset);

            string command;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int cmdAsInt = int.Parse(command);

                for (int i = 0; i < drumset.Count; i++)
                {
                    drumset[i] -= cmdAsInt;
                    if (drumset[i] <= 0)
                    {
                        int newDrum = initialDrumset[i] * 3;

                        if (newDrum <= budget)
                        {
                            budget -= newDrum;
                            drumset[i] = initialDrumset[i];
                        } 
                        
                    }
                }
                for (int i = 0; i < drumset.Count; i++)
                {
                    if (drumset[i] <=0)
                    {
                        drumset.RemoveAt(i);
                        initialDrumset.RemoveAt(i);
                    }
                }
            }
           
            Console.WriteLine(string.Join(" ", drumset));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}