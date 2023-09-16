namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, int> elements = new Dictionary<string, int>();
            int counter = 0;
            string currentElement = string.Empty;


            while ((input = Console.ReadLine()) != "stop")
            {
                counter++;
                if (counter % 2 != 0)
                {
                    currentElement = input;
                    if (!elements.ContainsKey(currentElement))
                    {
                        elements.Add(currentElement, 0);
                    }
                }
                else if (counter % 2 == 0)
                {
                    int quantity = int.Parse(input);
                    elements[currentElement] += quantity;
                }
            }
            foreach (var item in elements)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}