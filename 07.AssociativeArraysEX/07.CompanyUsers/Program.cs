namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArr = input.Split(" -> ");
                string comapny = inputArr[0];
                string employeeID = inputArr[1];

                DoesEmployeeIDExists(data, comapny, employeeID);   
            }
            PrintCompanyAndStaff(data);
        }

        static void DoesEmployeeIDExists(Dictionary<string, List<string>> data, string company, string employeeID)
        {
            if (!data.ContainsKey(company))
            {
                data.Add(company, new List<string>());
            }
            if (!data[company].Contains(employeeID))
            {
                data[company].Add(employeeID);
            }
        }
        static void PrintCompanyAndStaff(Dictionary<string, List<string>> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item.Key);
                foreach (var ID in item.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}