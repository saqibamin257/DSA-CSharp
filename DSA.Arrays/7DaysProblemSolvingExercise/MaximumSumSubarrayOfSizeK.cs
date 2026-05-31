using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class MaximumSumSubarrayOfSizeK
    {
        public static int MaxSum_For_WindowSize_3(int[] arr, int k=3) 
        {
            //arr = [2,1,5,1,3,2]
            //k = 3

            //[2, 1, 5] => 8
            //[1, 5, 1] => 7
            //[5, 1, 3] => 9
            //[1, 3, 2] => 6

            //Time Complexity: O(n)
            //Space Complexity: O(1)


            if (arr is null || arr.Length < k) 
            {
                throw new ArgumentException("array cannot be null or smaller than k size");
            }

            int arrayLength = arr.Length - k;   // 6-3 = 3
            int maxSum = 0;
            
            for (int i = 0; i <= arrayLength; i++) 
            {
                int sum = arr[i] + arr[i + 1] + arr[i + 2]; // only valid for window size 3
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }

        //Dry Run

        // i            window           Sum          MaxSum

        // 0            2,1,5            8              8

        // 1            1,5,1            7              8

        // 2            5,1,3            9              9

        // 3            1,3,2            6              9



        public static int MaxSum_For_WindowSize_k(int[] arr, int k)
        {
            // Summary:
            // For each possible starting position, calculate the sum
            // of the next k contiguous elements.
            //
            // Keep track of the maximum window sum found.
            //
            // This is a brute-force approach because every window
            // is recalculated from scratch.
            //
            // Example:
            // [2,1,5,1,3,2], k=3
            //
            // Windows:
            // [2,1,5] = 8
            // [1,5,1] = 7
            // [5,1,3] = 9
            // [1,3,2] = 6
            //
            // Maximum Sum = 9
            //
            // Time Complexity : O(n * k)
            // Space Complexity: O(1)


            if (arr is null || arr.Length < k)
            {
                throw new ArgumentException("array cannot be null or smaller than k size");
            }

            int arrayLength = arr.Length - k;   // 6-3 = 3
            int maxSum = int.MinValue; ;

            for (int i = 0; i <= arrayLength; i++)
            {
                int sum = 0;
                for (int j = 0; j < k; j++) 
                {
                    sum += arr[i + j];                    //window + sum creation
                }
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }

        public static int MaxSum_For_WindowSize_k_Optimized(int[] arr, int k)
        {
            // Summary:
            // This solution uses the Sliding Window pattern.
            //
            // First, calculate the sum of the initial window of size k.
            //
            // Then slide the window one position at a time:
            //
            // - Remove the element leaving the window.
            // - Add the element entering the window.
            // - Update the maximum sum found so far.
            //
            // This avoids recalculating every window from scratch
            // and reduces the complexity from O(n * k) to O(n).
            //
            // Example:
            // [2,1,5,1,3,2], k=3
            //
            // Window 1: [2,1,5] = 8
            // Window 2: [1,5,1] = 7
            // Window 3: [5,1,3] = 9
            // Window 4: [1,3,2] = 6
            //
            // Maximum Sum = 9
            //
            // Time Complexity : O(n)
            // Space Complexity: O(1)


            if (arr is null || arr.Length < k)
            {
                throw new ArgumentException("array cannot be null or smaller than k size");
            }
            
            int maxSum = int.MinValue; 
            int sum = 0;
           
            //calculate first window sum
            for (int firstWindow = 0; firstWindow < k; firstWindow++)
            {   
                sum += arr[firstWindow];                    
            }
            maxSum = Math.Max(maxSum, sum);

            // Sum of sliding window by subtracting previous value and adding current value
            int previousElementIndex = 0;               
            // Note:  arr[i-k] is always a leaving element, so it can also be used instead of previousElementIndex
            for (int i = k; i < arr.Length; i++) 
            {
                sum = sum - arr[previousElementIndex] + arr[i];
                previousElementIndex++;
                maxSum = Math.Max(maxSum, sum);
            }
             return maxSum;
        }
    }
}
