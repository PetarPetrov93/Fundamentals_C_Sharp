using System.Threading.Channels;
using System.Xml.Serialization;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();

                if (inputArr[0] == "exchange")
                {
                    int index = int.Parse(inputArr[1]);
                    Exchange(nums, index);
                    
                }
                else if (inputArr[0] == "max")
                {
                    string maxCommand = inputArr[1];
                    Max(nums, maxCommand);
                }
                else if (inputArr[0] == "min")
                {
                    string minCommand = inputArr[1];
                    Min(nums, minCommand);
                }
                else if (inputArr[0] == "first")
                {
                    int count = int.Parse(inputArr[1]);
                    string evenOrOdd = inputArr[2];
                    First(nums, count, evenOrOdd);
                }
                else if (inputArr[0] == "last")
                {
                    int count = int.Parse(inputArr[1]);
                    string evenOrOdd = inputArr[2];
                    Last(nums, count, evenOrOdd);
                }
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");

        }
        static void Exchange(int[] nums, int index)
        {
            if (index < 0 || index >= nums.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            else if (index == 0 || index == nums.Length - 1)
            {
                return;
            }
            else
            {
                int[] subArrLeft = new int[index + 1];
                int[] subArrRight = new int[nums.Length - (index + 1)];

                for (int i = 0; i <= index; i++)
                {
                    subArrLeft[i] = nums[i];

                }
                for (int i = index + 1, j = 0; i < nums.Length; i++, j++)
                {
                    subArrRight[j] = nums[i];
                }

                int[] concatenatedArr = subArrRight.Concat(subArrLeft).ToArray();

                for (int i = 0; i < concatenatedArr.Length; i++)
                {
                    nums[i] = concatenatedArr[i];
                }
               
                

            }
        }
        static void Max(int[] nums, string command)
        {
            if (command == "even")
            {
                if (nums.Any(x => x%2 == 0))
                {
                    int indexOfEven = -1;
                    int maxEvenValue = int.MinValue;
                    foreach (int x in nums.Where(x => x%2 == 0))
                    {
                        if (maxEvenValue <= x)
                        {
                            maxEvenValue = x;
                            indexOfEven = Array.LastIndexOf(nums, x);
                        }
                        
                    }
                    Console.WriteLine(indexOfEven);

                }
                else
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            else if (command == "odd")
            {
                if (nums.Any(x => x % 2 != 0))
                {
                    int indexOfOdd = -1;
                    int maxOddValue = int.MinValue;
                    foreach (int x in nums.Where(x => x % 2 != 0))
                    {
                        if (maxOddValue <= x)
                        {
                            maxOddValue = x;
                            indexOfOdd = Array.LastIndexOf(nums, x);
                        }

                    }
                    Console.WriteLine(indexOfOdd);

                }
                else
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
        }
        static void Min(int[] nums, string command)
        {
            if (command == "even")
            {
                if (nums.Any(x => x % 2 == 0))
                {
                    int indexOfEven = -1;
                    int minEvenValue = int.MaxValue;
                    foreach (int x in nums.Where(x => x % 2 == 0))
                    {
                        if (minEvenValue >= x)
                        {
                            minEvenValue = x;
                            indexOfEven = Array.LastIndexOf(nums, x);
                        }
                    }
                    Console.WriteLine(indexOfEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (command == "odd")
            {
                if (nums.Any(x => x % 2 != 0))
                {
                    int indexOfOdd = -1;
                    int minOddValue = int.MaxValue;
                    foreach (int x in nums.Where(x => x % 2 != 0))
                    {
                        if (minOddValue >= x)
                        {
                            minOddValue = x;
                            indexOfOdd = Array.LastIndexOf(nums, x);
                        }
                    }
                    Console.WriteLine(indexOfOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }
        static void First(int[] nums, int count, string evenOrOdd)
        {
            if (count > nums.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            else
            {
                int counter = 0;
                List<int> list = new List<int>();
                if (evenOrOdd == "even")
                {
                    foreach (int x in nums.Where(x => x % 2 == 0))
                    {
                        counter++;
                        if (counter <= count)
                        {
                           list.Add(x);
                        }
                        
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                        list.Clear();
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    foreach (int x in nums.Where(x => x % 2 != 0))
                    {
                        counter++;
                        if (counter <= count)
                        {
                            list.Add(x);
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                        list.Clear();
                    }
                }
                
            }
        }
        static void Last(int[] nums, int count, string evenOrOdd)
        {
            if (count > nums.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int counter = 0;
                List<int> list = new List<int>();

                if (evenOrOdd == "even")
                {
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            counter++; 
                            if (counter <= count)
                            {
                                list.Add(nums[i]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        list.Reverse();
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                        list.Clear();
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        if (nums[i] % 2 != 0)
                        {
                            counter++;
                            if (counter <= count)
                            {
                                list.Add(nums[i]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        list.Reverse();
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                        list.Clear();
                    }
                }
            }
        }
    }
}