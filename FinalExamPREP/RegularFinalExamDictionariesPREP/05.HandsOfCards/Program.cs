namespace _05.HandsOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string input;

            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "JOKER")
            {
                string[] cmdArr = input.Split(": ");
                string CurrPlr = cmdArr[0];
                List<string> cardsOfCurrPlr = cmdArr[1].Split(", ").Distinct().ToList();

                if (!players.ContainsKey(CurrPlr))
                {
                    players.Add(CurrPlr, new List<string>());
                    players[CurrPlr] = cardsOfCurrPlr;
                }
                else
                {
                    foreach (var card in cardsOfCurrPlr.Distinct())
                    {
                        if (!players[CurrPlr].Contains(card))
                        {
                            players[CurrPlr].Add(card);
                        }
                    }
                }
                
            }

            foreach (var (player, deck) in players)
            {
                int totalPointsOfThePlr = 0;
                for (int i = 0; i < deck.Count; i++)
                {
                    char[] currCard = deck[i].ToCharArray();
                    int value = 0;
                    int multiplier = 0;
                    int currPoints = 0;
                    
                    if (currCard[0] == '2' || currCard[0] == '3' || currCard[0] == '4' || currCard[0] == '5' ||
                        currCard[0] == '6' || currCard[0] == '7' || currCard[0] == '8' || currCard[0] == '9' )
                    {
                        value = int.Parse(currCard[0].ToString());
                    }
                    else if (currCard[0] == '1')
                    {
                        value = 10;
                    }
                    else if (currCard[0] == 'J')
                    {
                        value = 11;
                    }
                    else if (currCard[0] == 'Q')
                    {
                        value = 12;
                    }
                    else if (currCard[0] == 'K')
                    {
                        value = 13;
                    }
                    else if (currCard[0] == 'A')
                    {
                        value = 14;
                    }
                    if (currCard[currCard.Length-1] == 'S')
                    {
                        multiplier = 4;
                    }
                    if (currCard[currCard.Length - 1] == 'H')
                    {
                        multiplier = 3;
                    }
                    if (currCard[currCard.Length - 1] == 'D')
                    {
                        multiplier = 2;
                    }
                    if (currCard[currCard.Length - 1] == 'C')
                    {
                        multiplier = 1;
                    }
                    currPoints = value * multiplier;
                    totalPointsOfThePlr += currPoints;
                }
                Console.WriteLine($"{player}: {totalPointsOfThePlr}");
            }
        }
    }
}