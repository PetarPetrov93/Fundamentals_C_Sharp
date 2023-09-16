namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] commonArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = commonArguments[0];
                string lastName = commonArguments[1];
                double grade = double.Parse(commonArguments[2]);

                Student currentStudent = new Student(firstName, lastName, grade);
                students.Add(currentStudent);
            }

            List<Student> orderedStudents = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade :f2}");
            }
        }
    }
    public class Student 
    {
        public Student (string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Grade { get; private set; }
        
    }

}