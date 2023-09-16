namespace _04.SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < totalCommands; i++)
            {
                string command  = Console.ReadLine();
                string[] cmdArr = command.Split();

                if (cmdArr[0] == "register")
                {
                    string username = cmdArr[1];
                    string plateN = cmdArr[2];

                    if (!registeredUsers.ContainsKey(username))
                    {
                        registeredUsers.Add(username, plateN);
                        Console.WriteLine($"{username} registered {plateN} successfully");
                    }
                    else
                    {
                        foreach (var item in registeredUsers.Where(x => x.Key == username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {item.Value}");
                        }
                        
                    }
                }
                else if (cmdArr[0] == "unregister")
                {
                    string username = cmdArr[1];

                    if (registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        registeredUsers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var item in registeredUsers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}