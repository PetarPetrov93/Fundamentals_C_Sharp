namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> comapnyList = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] compAndId = input.Split(" -> ");
                string companyName = compAndId[0];
                string employeeID = compAndId[1];

                if (!comapnyList.ContainsKey(companyName))
                {
                    comapnyList.Add(companyName, new List<string>());
                }
                if (!comapnyList[companyName].Contains(employeeID))
                {
                    comapnyList[companyName].Add(employeeID);
                }
            }
            foreach (var item in comapnyList)
            {
                Console.WriteLine(item.Key);
                foreach (var ID in item.Value)
                {
                    Console.WriteLine("-- " + ID);
                }
            }
        }
    }
}