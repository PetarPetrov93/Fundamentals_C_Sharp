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
                string currentCourse = inputArr[0];
                string studentName = inputArr[1];

                if (!courses.ContainsKey(currentCourse))
                {
                    courses.Add(currentCourse, new List<string>());
                }
                foreach (var item in courses.Where(item => item.Key == currentCourse))
                {
                    if (!item.Value.Contains(studentName))
                    {
                        item.Value.Add(studentName);
                        //courses[currentCourse].Add(studentName); --> alternative to the above :)
                    }
                }
                
            }
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var name in item.Value)
                {
                    Console.WriteLine("-- " + name);
                }
            }

        }
    }
}