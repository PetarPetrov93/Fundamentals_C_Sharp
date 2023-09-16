namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> combinedNums = new List<int>();
            int a = 0;
            int b = 0;
            if (nums1.Count > nums2.Count)
            {
                a= nums1[nums1.Count-1];
                b= nums1[nums1.Count-2];
                nums1.RemoveRange(nums1.Count - 2, 2);
            }
            else if (nums2.Count > nums1.Count)
            {
                a = nums2[0];
                b = nums2[1];
                nums2.RemoveRange(0, 2);
            }
            for (int i = 0; i < nums1.Count; i++)
            {
                combinedNums.Add(nums1[i]);
                combinedNums.Add(nums2[nums2.Count-1-i]);
            }
             
             List<int> result = new List<int>();

            foreach (var item in combinedNums)
            {
                if (item < Math.Max(a, b) && item > Math.Min(a, b))
                {
                    result.Add(item);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}