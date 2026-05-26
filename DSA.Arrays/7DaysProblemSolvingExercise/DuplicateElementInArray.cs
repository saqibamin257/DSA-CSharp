using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class DuplicateElementInArray
    {
        //return true if any duplicate value occurs in given array
        //arr ={1,2,3,4,2,5}

        //Time Complexity = O(n^2) ----> because of loop into loop
        //Space Complexity = O(1) 
        public static bool Duplicate(int[] arr) 
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            for (int i = 0; i < arr.Length-1; i++) 
            {
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    if (arr[i] == arr[j])
                        return true;
                }
            }
            return false;
        }


        //Time Complexity = O(n) ----> because of single loop
        //Space Complexity = foreach loop O(n).
        //                   HashSet operations Contains and Add O(1)
        //                   Total = O(n) * O(1) = O(n).     
        public static bool Duplicate_By_HashSet(int[] arr) 
        {
            if (arr is null || arr.Length == 0) 
            {
                throw new ArgumentException("array cannot be null or empty");
            }
            HashSet<int> uniqueSet = new HashSet<int>();
            
            foreach(int num in arr) 
            {
                if (uniqueSet.Contains(num)) 
                {
                    return true;
                }
                uniqueSet.Add(num);
            }
            return false;
        }
    }
}
