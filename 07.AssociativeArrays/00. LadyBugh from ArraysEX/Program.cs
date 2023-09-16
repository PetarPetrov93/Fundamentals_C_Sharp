namespace _00._LadyBugh_from_ArraysEX
{
     internal class Program
     {
            static void Main(string[] args)
            {
                int fieldSize = int.Parse(Console.ReadLine());


                int[] initialIndexOfLadybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int[] field = new int[fieldSize];

                foreach (int index in initialIndexOfLadybugs)
                {
                    if (index >= 0 && index < field.Length)
                    {
                        field[index] = 1;
                    }
                }

                string command;

                while ((command = Console.ReadLine()) != "end")
                {
                    string[] cmdArr = command.Split();
                    int startingIndex = int.Parse(cmdArr[0]);
                    int steps = int.Parse(cmdArr[2]);

                    if (startingIndex < 0 || startingIndex >= field.Length || field[startingIndex] == 0 || steps == 0)
                    {
                        continue;
                    }

                    if (cmdArr[1] == "right")
                    {
                        Right(field, startingIndex, steps);
                    }
                    else if (cmdArr[1] == "left")
                    {
                        Left(field, startingIndex, steps);
                    }

                }
                Console.WriteLine(string.Join(" ", field));
            }
            static void Right(int[] field, int startingIndex, int steps)
            {
                field[startingIndex] = 0;

                if (steps < 0)
                {
                    Left(field, startingIndex, Math.Abs(steps));
                    return;
                }

                if (startingIndex + steps >= field.Length)
                {
                    return;
                }

                while (field[startingIndex + steps] == 1)
                {

                    steps += steps;
                    if (startingIndex + steps >= field.Length)
                    {

                        return;
                    }

                    field[startingIndex + steps] = 1;
                }

                if (field[startingIndex + steps] == 0)
                {

                    field[startingIndex + steps] = 1;
                }


            }
            static void Left(int[] field, int startingIndex, int steps)
            {
                field[startingIndex] = 0;

                if (steps < 0)
                {
                    Right(field, startingIndex, Math.Abs(steps));
                    return;
                }

                if (startingIndex - steps < 0)
                {
                    return;
                }

                while (field[startingIndex - steps] == 1)
                {
                    steps += steps;
                    if (startingIndex - steps < 0)
                    {
                        return;
                    }
                }

                if (field[startingIndex - steps] == 0)
                {
                    field[startingIndex - steps] = 1;
                }

            }
     }
}