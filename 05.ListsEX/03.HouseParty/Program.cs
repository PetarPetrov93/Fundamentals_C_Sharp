namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string invited = Console.ReadLine();
                string[] invitedArray = invited.Split().ToArray();

                if (list.Contains(invitedArray[0]))
                {
                    if (invitedArray[2] == "not")
                    {
                        list.Remove(invitedArray[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{invitedArray[0]} is already in the list!");
                    }

                }
                else
                {
                    if (invitedArray[2] == "not")
                    {
                        if (list.Contains(invitedArray[0]))
                        {
                            list.Remove(invitedArray[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{invitedArray[0]} is not in the list!");
                        }  

                    }
                    else
                    {
                        list.Add(invitedArray[0]);
                    }
                    
                }
                
            }
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

        }
    }
}