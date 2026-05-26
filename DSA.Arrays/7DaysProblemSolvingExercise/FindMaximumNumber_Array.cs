using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class FindMaximumNumber_Array
    {
        //Time Complexity = O(n)
        //Space Complexity = O(1)
        public static int FindMaximumNumber(int[] arr) 
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++) 
            {
                if (arr[i] > max) 
                {
                    max = arr[i];
                }   
            }
            return max;
        }       
    }
}
