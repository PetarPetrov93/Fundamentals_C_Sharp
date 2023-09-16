namespace _09.PokermonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> removedElements = new List<int>();

            while (pokemonList.Count > 0)
            {
                int pokemonIndex = int.Parse(Console.ReadLine());

                if (pokemonIndex < 0)
                {
                    IndexLessThanZero(pokemonList, removedElements);
                }
                else if (pokemonIndex > pokemonList.Count-1)
                {
                    IndexIsHigherThanCount(pokemonList, removedElements);
                }
                else
                {
                    IndexInRange(pokemonList, removedElements, pokemonIndex);
                }
            }
            Console.WriteLine(removedElements.Sum());
        }
        static void IndexLessThanZero(List<int> pokemonList, List<int> removedElements)
        {
            int currentElement = pokemonList[0];
            removedElements.Add(currentElement);
            pokemonList.RemoveAt(0);
            int elementToCopy = pokemonList[pokemonList.Count - 1];
            pokemonList.Insert(0, elementToCopy);

            for (int i = 0; i < pokemonList.Count; i++)
            {
                if (pokemonList[i] > currentElement)
                {
                    pokemonList[i] -= currentElement;
                }
                else if (pokemonList[i] <= currentElement)
                {
                    pokemonList[i] += currentElement;
                }
            }
        }
        static void IndexIsHigherThanCount(List<int> pokemonList, List<int> removedElements)
        {
            int currentElement = pokemonList[pokemonList.Count - 1];
            removedElements.Add(currentElement);
            pokemonList.RemoveAt(pokemonList.Count-1);
            int elementToCopy = pokemonList[0];
            pokemonList.Add(elementToCopy);

            for (int i = 0; i < pokemonList.Count; i++)
            {
                if (pokemonList[i] > currentElement)
                {
                    pokemonList[i] -= currentElement;
                }
                else if (pokemonList[i] <= currentElement)
                {
                    pokemonList[i] += currentElement;
                }
            }
        }
        static void IndexInRange(List<int> pokemonList, List<int> removedElements, int pokemonIndex)
        {
            int currentElement = pokemonList[pokemonIndex];
            removedElements.Add(currentElement);
            pokemonList.RemoveAt(pokemonIndex);

            for (int i = 0; i < pokemonList.Count; i++)
            {
                if (pokemonList[i] > currentElement)
                {
                    pokemonList[i] -= currentElement;
                }
                else if (pokemonList[i] <= currentElement)
                {
                    pokemonList[i] += currentElement;
                }
            }
        }
    }
}