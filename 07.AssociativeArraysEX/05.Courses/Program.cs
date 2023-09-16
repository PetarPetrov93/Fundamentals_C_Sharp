namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split(" : ");
                DoesCourseExists(courses, inputArr[0], inputArr[1]);
            }

            PrintStudents(courses);
        }
        static void DoesCourseExists(Dictionary<string, List<string>> courses, string currentCourse,
                                     string student)
        {
            

            if (!courses.ContainsKey(currentCourse))
            {
                
                courses.Add(currentCourse, new List<string>()); 
                
            }

             courses[currentCourse].Add(student);

        }

        static void PrintStudents(Dictionary<string, List<string>> courses)
        {
            foreach (var (key, value) in courses)
            {
                Console.WriteLine($"{key}: {value.Count}");

                for (int i = 0; i < value.Count; i++)
                {
                    Console.WriteLine($"-- {value[i]}");
                }
            }
        }
    }
}