namespace _09.KamonoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// longest subsequence of 1s - done
            //// if equal length - print the one with lefmost starting index - done
            //// if all of the above are queal - select the one with the greater sum of indexes
            
            //string inputDNA;
            //int counterOfOnes = 1;
            //int longestSequence = 0;
            //int sumOfIndexes = 0;
            //int longestSequenceSum = 0;
            //int counterSampleNumber = 0;
            //int bestCounterSampleNumber = 0;

            //while ((inputDNA = Console.ReadLine()) != "Clone them!")
            //{
            //    counterSampleNumber++;
            //    int[] DNA = inputDNA.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    for (int k = 0; k < DNA.Length; k++)
            //    {
            //        sumOfIndexes += DNA[k];
            //    }
                
            //    for (int i = 0; i < DNA.Length; i++)
            //    {
                    
            //        if (DNA[i] == 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            for (int j = i+1; j < DNA.Length; j++)
            //            {
            //                if (DNA[j] == 0)
            //                {
            //                    break;
            //                }
            //                else if (DNA[j] == 1)
            //                {
            //                    counterOfOnes++;
            //                    if (longestSequence < counterOfOnes)
            //                    {
            //                        longestSequence = counterOfOnes;
            //                        longestSequenceSum += sumOfIndexes;
            //                        bestCounterSampleNumber = counterSampleNumber;

            //                    }
            //                    else if (longestSequence == counterOfOnes)
            //                    {
            //                        if (longestSequenceSum < sumOfIndexes)
            //                        {
            //                            longestSequenceSum = sumOfIndexes;
            //                            bestCounterSampleNumber = counterSampleNumber;

            //                        }
                                    
            //                    }
            //                }
            //            }
            //            counterOfOnes = 1;
            //            sumOfIndexes = 0;
            //        }
            //    }
            //}
            //Console.WriteLine(counterSampleNumber);
            //Console.WriteLine(longestSequenceSum);

            int DNAlength = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                
            }


        }
    }
}