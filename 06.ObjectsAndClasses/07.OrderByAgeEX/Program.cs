namespace _07.OrderByAgeEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;
            List<People> people = new List<People>();

            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArr = cmd.Split();
                string name = cmdArr[0];
                string ID = cmdArr[1];
                int age = int.Parse(cmdArr[2]);
                People newPerson = new People(name, ID, age);
                if (people.Find(x => x.Id == ID) == null)
                {
                    people.Add(newPerson);
                }
                else
                {
                    People humanToUpdateData = people.First(x => x.Id == ID);
                    humanToUpdateData.Age = age;
                    humanToUpdateData.Name = name;

                }
            }
            List<People> orderByAge = people.OrderBy(x => x.Age).ToList();

            foreach (People person in orderByAge)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
    public class People
    {
        public People(string name, string iD, int age)
        {
            Name = name;
            Id = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}