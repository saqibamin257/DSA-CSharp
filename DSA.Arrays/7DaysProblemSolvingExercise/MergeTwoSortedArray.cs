using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class MergeTwoSortedArray
    {
        public static int[] MergeSortArray_BruteForce(int[] firstArray, int[] secondArray) 
        {
            //
            //int arr1 = {1,3,5.7}
            //int arr2 = {2,4,6,8}
            //int resultArray = {1,2,3,4,5,6,7,8}

            //logic merge both arrays to resultArray then sort the result Array in the end
            
            
            int[] resultArray = new int[firstArray.Length + secondArray.Length];
            int counter = 0;
            for (int i = 0; i < firstArray.Length; i++) 
            {
                resultArray[counter] = firstArray[i];
                counter++;
            }

            for (int j = 0; j < secondArray.Length; j++)
            {
                resultArray[counter] = secondArray[j];
                counter++;
            }

            Array.Sort(resultArray);
            return resultArray;            
        }

        public static int[] MergeSortArray_Optimized(int[] firstArray, int[] secondArray) 
        {   
            // Summary:

            //
            // Both input arrays are already sorted.
            //
            // Use two pointers:
            //
            // firstPointer  -> first array
            // secondPointer -> second array
            //
            // Compare current elements from both arrays.
            // Insert the smaller element into result array.
            // Move the corresponding pointer.
            //
            // Once one array is exhausted,
            // copy all remaining elements from the other array.
            //
            // Time Complexity : O(m + n)
            // Space Complexity: O(m + n)
            //int arr1 = {1,3,4}
            //int arr2 = {1,2,5,6,7,8}
            //int resultArray = {1,1,2,3,4,5,6,7,8}

            if (firstArray is null || secondArray is null)
                throw new ArgumentException("array cannot be null");
            if (firstArray.Length == 0 && secondArray.Length == 0)
                return new int[] {};


            int[] resultArray = new int[firstArray.Length + secondArray.Length];
            int firstPointer = 0;
            int secondPointer = 0;
            int counter = 0;            


            while(firstPointer < firstArray.Length && secondPointer < secondArray.Length)
            {
                if (firstArray[firstPointer] <= secondArray[secondPointer])
                {
                        resultArray[counter] = firstArray[firstPointer];
                        firstPointer++;
                        counter++;
                }
                else 
                {
                        resultArray[counter] = secondArray[secondPointer];
                        secondPointer++;
                        counter++;
                }                
            }

            while (firstPointer < firstArray.Length) 
            {
                resultArray[counter] = firstArray[firstPointer];
                firstPointer++;
                counter++;
            }
            while (secondPointer < secondArray.Length) 
            {
                resultArray[counter] = secondArray[secondPointer];
                secondPointer++;
                counter++;
            }
            return resultArray;
        }
    }
}
