using System;
using System.Text;

namespace _01.AdvertisementMEssage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fakeComments = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();
            
            for (int i = 0; i < fakeComments; i++)
            {
                int randomIndexOfPhrases = random.Next(0, phrases.Length);
                int randomIndexOfEvents = random.Next(0, events.Length);
                int randomIndexOfAuthors = random.Next(0, authors.Length);
                int randomIndexOfCities = random.Next(0, cities.Length);

                string newPhrase = phrases[randomIndexOfPhrases];
                string newEvent = events[randomIndexOfEvents];
                string newAuthor = authors[randomIndexOfAuthors];
                string newCity = cities[randomIndexOfCities];

                Console.WriteLine($"{newPhrase}. {newEvent}. {newAuthor} - {newCity}.");

            }
        }
    }
}