namespace _05.CompareCharArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            string firstArrToStr = string.Join("", arr1);
            string secondArrToStr = string.Join("", arr2);
            List<string> list = new List<string>();
            list.Add(firstArrToStr);
            list.Add(secondArrToStr);
            list.Sort();
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}