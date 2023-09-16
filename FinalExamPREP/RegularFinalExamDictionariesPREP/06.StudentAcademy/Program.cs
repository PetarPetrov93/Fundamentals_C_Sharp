namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string currentStudent = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());
                
                if (!students.ContainsKey(currentStudent))
                {
                    students.Add(currentStudent, new List<double>());
                }
                students[currentStudent].Add(currentGrade);
            }
            foreach (var item in students)
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }

        }
    }
}