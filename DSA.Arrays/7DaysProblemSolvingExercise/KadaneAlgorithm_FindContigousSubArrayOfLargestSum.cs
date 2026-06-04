using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class KadaneAlgorithm_FindContigousSubArrayOfLargestSum
    {
        public static KadaneAlgorithmResponse ContigousSubArrayOfLargestSum_BruteForce(int[] arr)
        {
            //[-2,1,-3,4,-1,2,1,-5,4]
            //sum =6
            //subArray = {4,-1,2,1}

            //Time Complexity : O(n^2)
            //Space Complexity :

            if (arr is null || arr.Length == 0)
                throw new ArgumentException("input array cannot be null or empty");

            int maxSum = arr[0];
            int startIndex = 0;
            int endIndex = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }

            return new KadaneAlgorithmResponse
            {
                MaxSum = maxSum,
                SubArray = arr.Skip(startIndex)                   // skip 3 elements from the beginning of the array
                               .Take(endIndex - startIndex + 1)  // take endIndex=6  startIndex=3 ==> 6-3+1 = 4 (take elements)
                               .ToArray()
            };
        }

        public class KadaneAlgorithmResponse
        {
            public int MaxSum { get; set; }
            public int[] SubArray { get; set; }
        }

        // DryRun
        // i               j              CurrentSum                  maxSum

        // 0               0                 -2                         -2
        // 0               1                -2+1 = -1                   -1
        //                 2                -1-3= -4                    -1
        //                 3                -4+4 = 0                     0
        //                 4                 0-1=-1                      0
        //                 5                 1+2=3                       3
        //                 6                 3+1=4                       4
        //                 7                 4-5=-1                      4
        //                 8                 -1+4=3                      4 

        public static KadaneAlgorithmResponse ContigousSubArrayWithLargestSum_Optimized(int[] arr)
        {
            int maxSum = arr[0];
            int currentSum = arr[0];
            int currentStartIndex = 0;
            int bestStartIndex = 0;
            int bestEndIndex = 0;


            //[-2,1,-3,4,-1,2,1,-5,4]
            //sum =6
            //subArray = {4,-1,2,1}

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > currentSum + arr[i])
                {
                    currentSum = arr[i];
                    currentStartIndex = i;
                }
                else
                {
                    currentSum += arr[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestStartIndex = currentStartIndex;
                    bestEndIndex = i;
                }
            }


            return new KadaneAlgorithmResponse
            {
                MaxSum = maxSum,
                SubArray = arr.Skip(bestStartIndex)
                          .Take(bestEndIndex - bestStartIndex + 1)
                          .ToArray()
            };
        }

        public static int MaxSum_By_Kadane_Algorithm_Optimized(int[] arr) 
        {
            int maxSum = arr[0];
            int currentSum =arr[0];
            for (int i = 1; i < arr.Length; i++) 
            {
                currentSum = Math.Max(arr[i], currentSum + arr[i]);
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }





        public static KadaneAlgorithmResponse GetSubArrayWithLargestSum(int[] arr)
        {
            // If current element alone is better than
            // extending the current subarray,
            // start a new subarray from current index.


            if (arr is null || arr.Length == 0)
                throw new ArgumentException("array can not be null or empty");

            int maxSum = arr[0];
            int currentSum = arr[0];
            int bestStartIndex = 0;
            int bestEndIndex = 0;
            int currentStartIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > currentSum + arr[i])
                {
                    currentSum = arr[i];
                    currentStartIndex = i;
                }
                else
                {
                    currentSum += arr[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestStartIndex = currentStartIndex;
                    bestEndIndex = i;
                }
            }

            return new KadaneAlgorithmResponse
            {
                MaxSum = maxSum,
                SubArray = arr.Skip(bestStartIndex)
                            .Take(bestEndIndex - bestStartIndex + 1)
                            .ToArray()
            };

            // Dry Run [4, -1, 2, 1]

            // i          (arr[i] > currentSum + arr[i])          currentSum         currentIndex     currentSum > maxSum     maxSum         bestStartIndex       bestEndIndex

            // 0                                                    4                   0                                        4                   0                 0

            // 1              false                                 4-1=3               0                   false                4                   0                 0

            // 2              false                                 3+2=5               0                    true                5                   0                 2

            // 3              false                                  5+1=6              0                     true               6                   0                 3     

            //output
            //maxSum = 6
            //startIndex=0      endIndex=3
            //subArray [4,-1,2,1]

            // ------------------------- Very Important Concept ---------------------------------//


            // Test Case to fail logic using only bestStartIndex without CurrentStart Index
            //logic

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > currentSum + arr[i])
            //    {
            //        currentSum = arr[i];
            //        bestStartIndex = i;
            //    }
            //    else
            //    {
            //        currentSum += arr[i];
            //    }

            //    if (currentSum > maxSum)
            //    {
            //        maxSum = currentSum;
            //        //bestStartIndex = currentStartIndex;
            //        bestEndIndex = i;
            //    }
            //}




            // input { -5, -2, -8 },
            // output : -2,
            // subArray: { -2 }

            // i          (arr[i] > currentSum + arr[i])          currentSum     bestStartIndex   currentSum > maxSum      maxSum         bestEndIndex

            //0                                                      -5            0                                       -5                0
            //1                  true                                -2            1                   true                -2                1
            //2                  true                                -8            2                   false               -2                1           

            //This is impossible to create array whose startIndex > endIndex


            // Important:
            //
            // currentStartIndex tracks the start of the CURRENT candidate subarray.
            //
            // bestStartIndex tracks the start of the BEST subarray found so far.
            //
            // They cannot be merged because a new candidate subarray may start
            // without becoming the best solution.
            //
            // Example:
            // [-5,-2,-8]
            //
            // At index 2 a new candidate starts,
            // but maxSum remains -2 from index 1.
            //
            // Using only bestStartIndex would produce:
            // startIndex = 2
            // endIndex = 1
            //
            // which is an invalid subarray.



        }
    }
}
