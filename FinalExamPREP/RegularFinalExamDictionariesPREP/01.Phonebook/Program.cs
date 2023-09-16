namespace _01.Phonebook
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
                string name = cmdArr[1];
                
                if (cmdArr[0] == "A")
                {
                    string phone = cmdArr[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, "");
                    }
                    phonebook[name] = phone;
                }
                else if (cmdArr[0] == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}