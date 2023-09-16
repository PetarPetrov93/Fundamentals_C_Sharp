namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] passangers = command.Split().ToArray();

                if (passangers[0] == "Add")
                {
                    int newWagon = int.Parse(passangers[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int addToWagon = int.Parse(passangers[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + addToWagon <= capacity)
                        {
                            wagons[i] += addToWagon;
                            break;
                        }
                    }


                }
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}