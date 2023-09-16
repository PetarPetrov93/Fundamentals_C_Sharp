namespace _01.DataTypes_methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string input = Console.ReadLine();

            if (command == "int")
            {
                VarManipulation(int.Parse(input));
            }
            else if (command == "real")
            {
                VarManipulation(double.Parse(input));
            }
            else
            {
                VarManipulation(input);
            }

        }
        static void VarManipulation (int value)
        {
            Console.WriteLine(value*2);
        }
        static void VarManipulation (double value)
        {
            double newValue = value * 1.5;
            Console.WriteLine($"{newValue:f2}");
        }
        static void VarManipulation(string value)
        {
            Console.WriteLine('$' + value + '$');
        }  
    }
}