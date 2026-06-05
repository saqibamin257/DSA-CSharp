using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class SortedSquaresOfNumbersInArray
    {
        public static int[] SortedSquares_BruteForce(int[] arr) 
        {

            //Input:[-4,-1,0,3,10]
            //Expected: [0, 1, 9, 16, 100]

            //logic
            //1- square of elements
            //2- sort array

            //Time Complexity: O(n) forloop  , O(log n) Array.Sort => O(n log n)
            //Space Complexity: O(1)
            if (arr is null || arr.Length == 0)
            {
                throw new ArgumentException("array cannot be null or empty");
            }

            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = arr[i] * arr[i];
            }
            Array.Sort(arr);
            return arr;        
        }

        public static int[] SortedSquares_Optimized(int[] arr) 
        {
            // Summary:
            //
            // The input array is already sorted.
            //
            // The largest squared value must come from either:
            // - leftmost element
            // - rightmost element
            //
            // Use two pointers:
            //
            // left  -> start
            // right -> end
            //
            // Compare absolute values.
            // Place the larger square at the end of result array.
            // Move the corresponding pointer.
            // Move write pointer backwards.
            //
            // Time Complexity : O(n)
            // Space Complexity: O(n)

            if (arr is null || arr.Length == 0)
            {
                throw new ArgumentException("array cannot be null or empty");
            }

            int[] result = new int[arr.Length];
            int left = 0;
            int right = arr.Length - 1;
            int write = arr.Length - 1;
            while (left <= right) 
            {
                if (Math.Abs(arr[left]) > Math.Abs(arr[right]))
                {
                    result[write] = arr[left]* arr[left];
                    left++;
                    write--;
                }
                else 
                {
                    result[write] = arr[right] * arr[right];
                    right--;
                    write--;
                }
            }
            return result;            
        }
    }
}
