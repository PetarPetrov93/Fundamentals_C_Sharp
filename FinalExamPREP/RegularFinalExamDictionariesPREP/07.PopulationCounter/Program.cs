namespace _07.PopulationCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;

            Dictionary< string, Dictionary<string, int>> populationCounter = new Dictionary<string, Dictionary<string, int>>();

            while ((cmd = Console.ReadLine()) != "report")
            {
                string[] cmdArr = cmd.Split("|");
                string city = cmdArr[0];
                string country = cmdArr[1];
                int population = int.Parse(cmdArr[2]);


                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter.Add(country, new Dictionary<string, int>());
                }
                populationCounter[country].Add(city, population);
                
            }
            Dictionary<string, int> countryTotalPop = new Dictionary<string, int>();

            foreach (var country in populationCounter)
            {
                int countryPopulation = 0;
                foreach (var cityAndPop in country.Value)
                {
                    countryPopulation += cityAndPop.Value;
                }

                countryTotalPop.Add(country.Key, countryPopulation);
            }

            foreach (var country in countryTotalPop.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                foreach (var item in populationCounter.Where(x => x.Key == country.Key))
                {
                    foreach (var city in item.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    }
                }
            }
        }
    }
}