using System.Runtime.InteropServices;

namespace _04.SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "register")
                {
                    Register(users, command[1], command[2]);
                }
                else if (command[0]== "unregister")
                {
                    Unregister(users, command[1]);
                }
            }

            PrintAllUsers(users);
        }

        static void Register(Dictionary<string, string> users, string name, string plateN)
        {
            if (!users.ContainsKey(name))
            {
                users.Add(name, plateN);
                Console.WriteLine($"{name} registered {plateN} successfully");
            }
            else
            {
                foreach (var user in users.Where(x => x.Key == name))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {user.Value}");
                }
                
            }
        }

        static void Unregister(Dictionary<string, string> users, string name) 
        {
            if (!users.ContainsKey(name))
            {
                Console.WriteLine($"ERROR: user {name} not found");
            }
            else
            {
                Console.WriteLine($"{name} unregistered successfully");
                users.Remove(name);
            }
        }

        static void PrintAllUsers(Dictionary<string, string> users)
        {
            foreach (var (key, value) in users)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}