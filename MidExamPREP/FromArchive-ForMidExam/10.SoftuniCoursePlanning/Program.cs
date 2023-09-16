using System.ComponentModel;

namespace _10.SoftuniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArr = command.Split(":");
                string cmd = cmdArr[0];

                if (cmd == "Add")
                {
                    Add(lessons, cmdArr[1]);
                }
                else if (cmd == "Insert")
                {
                    Insert(lessons, cmdArr[1], int.Parse(cmdArr[2].ToString()));
                }
                else if (cmd == "Remove")
                {
                    Remove(lessons, cmdArr[1]);
                }
                else if (cmd == "Swap")
                {
                    if (lessons.Contains(cmdArr[1]) && lessons.Contains(cmdArr[2]))
                    {
                        Swap(lessons, cmdArr[1], cmdArr[2]);
                    }                   
                }
                else if (cmd == "Exercise")
                {
                    Exercise(lessons, cmdArr[1]);
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        static void Add (List<string> lessons, string lessonTitle)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
            }
        }
        static void Insert (List<string> lessons, string lessonTitle, int index)
        {
            if ((!lessons.Contains(lessonTitle)) && index >=0 && index < lessons.Count)
            {
                if (lessons[index].Contains("-Exercise"))
                {
                    index += 1;
                    lessons.Insert(index, lessonTitle);
                }
                else
                {
                    lessons.Insert(index, lessonTitle);
                }
                
            }
        }
        static void Remove(List<string> lessons, string lessonTitle)
        {
            if (lessons.Contains(lessonTitle))
            {
                lessons.RemoveAll(x => x.Contains(lessonTitle)); // That way if there is an excercise as well - it should also be removed
            }
        }
        static void Swap (List<string> lessons, string lessonTitleOne, string lessonTitleTwo)
        {
            string currentLessonToSwap = lessonTitleOne;
            int indexOflessonTitleOne = lessons.IndexOf(lessonTitleOne);
            int indexOflessonTitleTwo = lessons.IndexOf(lessonTitleTwo);
            lessons[indexOflessonTitleOne] = lessonTitleTwo;
            lessons[indexOflessonTitleTwo] = currentLessonToSwap;

            if (lessons.Contains($"{lessonTitleOne}-Exercise"))
            {
                int initialIndexOfExOne = lessons.IndexOf($"{lessonTitleOne}-Exercise");
                int indexToInsertExOne = lessons.IndexOf(lessonTitleOne) + 1;
                if (initialIndexOfExOne > indexToInsertExOne)
                {
                    lessons.RemoveAt(initialIndexOfExOne);
                    lessons.Insert(indexToInsertExOne, $"{lessonTitleOne}-Exercise");
                }
                else if (initialIndexOfExOne < indexToInsertExOne)
                {
                    lessons.Insert(indexToInsertExOne, $"{lessonTitleOne}-Exercise");
                    lessons.RemoveAt(initialIndexOfExOne);
                }
            }
            if (lessons.Contains($"{lessonTitleTwo}-Exercise"))
            {
                int initialIndexOfExTwo = lessons.IndexOf($"{lessonTitleTwo}-Exercise");
                int indexToInsertExTwo = lessons.IndexOf(lessonTitleTwo) + 1;
                if (initialIndexOfExTwo > indexToInsertExTwo)
                {
                    lessons.RemoveAt(initialIndexOfExTwo);
                    lessons.Insert(indexToInsertExTwo, $"{lessonTitleTwo}-Exercise");
                }
                else if (initialIndexOfExTwo < indexToInsertExTwo)
                {
                    lessons.Insert(indexToInsertExTwo, $"{lessonTitleTwo}-Exercise");
                    lessons.RemoveAt(initialIndexOfExTwo);
                }
            }
            
        }
        static void Exercise (List<string> lessons, string lessonTitle)
        {
            if (lessons.Contains(lessonTitle) && (!lessons.Contains(lessonTitle + "-Exercise")))
            {
                int indexToInsertTheEX = lessons.IndexOf(lessonTitle)+1;
                lessons.Insert(indexToInsertTheEX, $"{lessonTitle}-Exercise");
            }
            else if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
                lessons.Add($"{lessonTitle}-Exercise");
            }
        }
    }
}