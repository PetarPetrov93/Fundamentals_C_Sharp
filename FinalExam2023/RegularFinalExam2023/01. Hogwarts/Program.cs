namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string cmd;

            while ((cmd = Console.ReadLine()) != "Abracadabra")
            {
                string[] cmdArr = cmd.Split(" ");

                string command = cmdArr[0];

                if (command == "Abjuration") // works
                {
                    for (int i = 0; i < spell.Length; i++)
                    {
                        if (char.IsLetter(spell[i]) && char.IsLower(spell[i]))
                        {
                            spell = spell.Replace(spell[i], char.ToUpper(spell[i]));  // -> that way it will change all the occurances but it should be ok since we want all the letters to be upper anyways                    
                        }
                    }
                    Console.WriteLine(spell);
                }
                else if (command == "Necromancy") // works
                {
                    for (int i = 0; i < spell.Length; i++)
                    {
                        if (char.IsLetter(spell[i]) && char.IsUpper(spell[i]))
                        {
                            spell = spell.Replace(spell[i], char.ToLower(spell[i])); // -> that way it will change all the occurances but it should be ok since we want all the letters to be lower anyways
                        }
                    }
                    Console.WriteLine(spell);
                }
                else if (command == "Illusion") // works
                {
                    int index = int.Parse(cmdArr[1]);
                    string letter = cmdArr[2];

                    if (index >= 0 && index < spell.Length)
                    {
                        spell = spell.Remove(index, 1);
                        spell = spell.Insert(index, letter);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if(command == "Divination") // works
                {
                    string substringToReplace = cmdArr[1];
                    string substringToInsert = cmdArr[2];

                    if (spell.Contains(substringToReplace))
                    {
                        spell = spell.Replace(substringToReplace, substringToInsert);
                        Console.WriteLine(spell);
                    }
                }
                else if (command == "Alteration")
                {
                    string substringToRemove = cmdArr[1];

                    if (spell.Contains(substringToRemove))
                    {
                        int startingIndex = spell.IndexOf(substringToRemove);
                        int length = substringToRemove.Length;
                        spell = spell.Remove(startingIndex, length);
                        Console.WriteLine(spell);
                    }                   

                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }

        }
    }
}