namespace _04.FixEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;
            int counter = 0;
            string name = string.Empty;
            Dictionary<string, string> emailAdressess = new Dictionary<string, string>();

            while ((cmd = Console.ReadLine()) != "stop")
            {
                counter++;
                if (counter % 2 != 0)
                {
                    name = cmd;
                    if (!emailAdressess.ContainsKey(name))
                    {
                        emailAdressess.Add(name, "");
                    }
                }
                else if (counter % 2 == 0)
                {
                    emailAdressess[name] = cmd;
                }
            }
            string usCheck = ".us";
            string ukCheck = ".uk";

            foreach (var (accHolder, email) in emailAdressess)
            {
                string substring = email.Substring(email.Length-3);
                if (substring.ToLower() == usCheck || substring.ToLower() == ukCheck)
                {
                    emailAdressess.Remove(accHolder);
                }
            }
            foreach (var item in emailAdressess)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}