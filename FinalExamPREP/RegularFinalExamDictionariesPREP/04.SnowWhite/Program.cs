using System.Text;

namespace _04.SnowWhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;

            Dictionary<string, Dictionary<string, int>> dwarves = new Dictionary<string, Dictionary<string, int>>();

            while ((cmd = Console.ReadLine()) != "Once upon a time")
            {
                string[] cmdArr = cmd.Split(" <:> ");
                string dwarfName = cmdArr[0];
                string dwarfHatColor = cmdArr[1];
                int dwarfPhysics = int.Parse(cmdArr[2]);

                if (!dwarves.ContainsKey(dwarfHatColor))
                {
                    dwarves.Add(dwarfHatColor, new Dictionary<string, int>());
                }
                if (dwarves[dwarfHatColor].ContainsKey(dwarfName))
                {
                    if (dwarves[dwarfHatColor][dwarfName] < dwarfPhysics)
                    {
                        dwarves[dwarfHatColor][dwarfName] = dwarfPhysics;
                    }
                }
                else
                {
                    dwarves[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                }
            }

            foreach (var dwarfHatColor in dwarves)
            {
                foreach (var dwarf in dwarfHatColor.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($" {dwarf.Key} {dwarf.Value}");
                }
            }
        }
    }
}