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
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }
                students[student].Add(grade);
            }
            foreach (var student in students)
            {
                if (student.Value.Average() < 4.5)
                {
                    students.Remove(student.Key);
                }
                
                // ALTERNATIVE IF YOU USE (key, value)
                //if (value.Average() < 4.5)
                //{
                //    students.Remove(key);
                //}

            }
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}