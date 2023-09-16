namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UNFINISHED !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! YES I WAS REALY ANGRY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            string input = Console.ReadLine();

            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '>')
                {
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            bombPower += int.Parse(input[j].ToString());
                            
                        }
                        if (input[j] == '>')
                        {
                            bombPower += int.Parse(input[j + 1].ToString());
                            continue;
                        }
                        input = input.Remove(j, 1);
                        bombPower--;
                        if (bombPower == 0)
                        {
                            i = j;
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(input);
        }
    }
}