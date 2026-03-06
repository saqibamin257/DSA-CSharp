using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.MediumLevel
{
    public static class SquaresOfSortedArray
    {
        // Approach1: Brute Force
        // Find squares of all elements.
        // Sort Array in Ascending Order.
        public static int[] square_ByBruteForce(int[] arr) 
        {
            //input validation
            if (arr is null || arr.Length == 0)
                return arr;

            int[] resultArray = new int[arr.Length];
            
            //Square
            for (int i = 0; i < arr.Length; i++) 
            {
                resultArray[i] = arr[i] * arr[i];
            }

            //Sorting
            for (int i = 0; i < resultArray.Length; i++) 
            {
                for (int j = i + 1; j < resultArray.Length; j++) 
                {
                    //tuple swapping
                    if (resultArray[i] > resultArray[j]) 
                    {
                        (resultArray[i], resultArray[j]) = (resultArray[j], resultArray[i]);
                    }
                }
            }
            return resultArray;
        }

        public static int[] square_TwoPointers(int[] arr) 
        {

            //input validation
            if (arr is null || arr.Length == 0)
                return arr;


            //Approach-2: Two Pointers
            //- left at 0 and right at n-1;
            // Take resultArray for sorted square values.
            // if abs[left] > abs[right], then insert square of left in resultArray,
            // insert in resultArray from end as large values should be inserted at last, Ascending order.


            int[] resultArray = new int[arr.Length];
            int left = 0;
            int right = arr.Length - 1;
            int index = arr.Length - 1;

            while (left <= right) 
            {
                if (Math.Abs(arr[left]) > Math.Abs(arr[right]))
                {
                    resultArray[index] = arr[left] * arr[left];
                    left++;
                    index--;
                }
                else 
                {
                    resultArray[index] = arr[right] * arr[right];
                    right--;
                    index--;
                }
            }
            return resultArray;

        }
    }
}
