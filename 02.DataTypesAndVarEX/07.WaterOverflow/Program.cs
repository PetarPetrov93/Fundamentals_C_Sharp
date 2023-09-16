namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte totalBuckets = sbyte.Parse(Console.ReadLine());
            ushort totalLeters = 0;

            for (int i = 1; i <= totalBuckets; i++)
            {
                ushort bucket = ushort.Parse(Console.ReadLine());
                if (totalLeters + bucket > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalLeters += bucket;
                }
            }
            Console.WriteLine(totalLeters);
        }
    }
}