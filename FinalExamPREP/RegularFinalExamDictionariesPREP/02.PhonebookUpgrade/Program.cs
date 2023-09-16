namespace _02.PhonebookUpgrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while ((cmd = Console.ReadLine()) != "END")
            {
                string[] cmdArr = cmd.Split();
                

                if (cmdArr[0] == "A")
                {
                    string name = cmdArr[1];
                    string phone = cmdArr[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, "");
                    }
                    phonebook[name] = phone;
                }
                else if (cmdArr[0] == "S")
                {
                    string name = cmdArr[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (cmdArr[0] == "ListAll")
                {
                    
                    foreach (var item in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }

                }
            }
        }
    }
}