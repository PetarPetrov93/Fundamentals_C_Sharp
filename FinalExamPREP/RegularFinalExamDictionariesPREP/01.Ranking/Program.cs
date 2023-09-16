namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOT THE CORRECT APPROACH TO THE TASK HOWEVER PLENTY OF GOOD NEW STUFF TO LOOK AT FOR REFFERENCE!!


            //We have 4 valuse to work with -> Contest, Pass, Student and Points
            // I've created a dictionary<string, Dictionary<string, int>> - I'm keeping the Contest and Password combined as a Key
            // I'm adding the student and his points as a Key-Value pair in the nested dictionary

            string inputContest;

            Dictionary<string, Dictionary<string, int>> contestDic = new Dictionary<string, Dictionary<string, int>>();

            while ((inputContest = Console.ReadLine()) != "end of contests") // the input here contains Contest:Password and I'm adding them in the same format as a KEY
            {
                if (!contestDic.ContainsKey(inputContest))
                {
                    contestDic.Add(inputContest, new Dictionary<string, int>()); // I've added the Contest:Pass pair as KEY for example (c#Basics:b14f)
                }
            }

            string inputStudents;

            while ((inputStudents = Console.ReadLine()) != "end of submissions") // the input here looks like this: Contest=>Pass=>student=>points
            {
                string[] inputStudentsAsArr = inputStudents.Split("=>"); // I'm splitting the input in order to get each element and sort in in the dictionary
                string contestAndPass = inputStudentsAsArr[0] + ":" + inputStudentsAsArr[1]; // I'm, concatenating [0] + : + [1] because that is how my Key looks like in the dictionary
                string currentStudent = inputStudentsAsArr[2]; // getting the student name which will be the key in the NESTED dictionary
                int currentPoints = int.Parse(inputStudentsAsArr[3]); // getting the student's points which will be the value in the NESTED dictionary

                if (contestDic.ContainsKey(contestAndPass)) // checking if the contestAndPass exist in the dictionary as KEY (I can use concatenated strings here since the input is only valid if both Contest name and pass are fully matched)
                {
                    if (!contestDic[contestAndPass].ContainsKey(currentStudent)) // if there is no student in the current contest, I'm adding it as a Key with his points as a Value in the NESTED dictionary
                    {
                        contestDic[contestAndPass].Add(currentStudent, currentPoints);
                    }
                    else
                    {
                        if (currentPoints > contestDic[contestAndPass][currentStudent]) // <-- checking if the new score is higher than the previous by accessing The value of the NESTED dictionary
                        {
                            contestDic[contestAndPass][currentStudent] = currentPoints; // <-- updating the value of the NESTED dictionary
                        }
                    }  
               
                }
            }

            Dictionary<string, int> studentsTotalPoints = new Dictionary<string, int>(); // creating new dictionary to keep students total score

            foreach (var contest in contestDic) // <-- going through all Keys (contests)
            {
                foreach (var student in contest.Value) // <-- accecing all Keys in the NESTED dictionary. contest.Value is the nested dictionary and student is the keyValuePair.
                {
                    if (!studentsTotalPoints.ContainsKey(student.Key)) // since student is the KVP, I only need the .Key to check if the name exists in the new Dictionary.
                    {
                        studentsTotalPoints.Add (student.Key, 0); // adding the student in the new dictionary
                    }
                    studentsTotalPoints[student.Key] += student.Value; // summing his score
                }
            }
            Dictionary<string, int> orderedStudentsTotalPoints = studentsTotalPoints.OrderBy(x => x.Value).ToDictionary(x => x.Key, x=> x.Value); // creating a new dictionary which is sorted by Value
            KeyValuePair<string, int> firstKey = orderedStudentsTotalPoints.First(); // or you can use var for short. Taking the first KEY from the dictionary
            string bestStudent = firstKey.Key; // this is the name of the winner (taken from the dictionary)
            int bestScore = firstKey.Value; // taking the score of the winner from the dictionary

            Console.WriteLine($"The best candindate is{bestStudent} with total {bestScore}");

            SortedDictionary<string, SortedDictionary<int, string>> studentsFinalScore = new SortedDictionary< string, SortedDictionary<int, string>>(); // now creating new sorted dictionary to put the rest of the students

            // NOT THE CORRECT APPROACH TO THE TASK HOWEVER PLENTY OF GOOD NEW STUFF TO LOOK AT FOR REFFERENCE!!
        }
    }
}