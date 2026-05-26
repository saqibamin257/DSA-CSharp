using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class TwoSum
    {
        //Time Complexity = O(n^2) ----> because of inner loop
        //Space Complexity = O(1).
        public static int[] FindPairOfTwoSum_BruteForce(int[] arr, int target) 
        {
            // nums = [3,2,4]
            // target = 6
            // output indexes = [1,2]
            // algorithm Brute Force

            if (arr is null || arr.Length < 2) // because two sum required atleast two elements
            {
                throw new ArgumentException("array cannot be null or empty");
            }
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for (int j = i+1; j < arr.Length; j++) 
                {
                    if (arr[i] + arr[j] == target) 
                    {                        
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        public static int[] FindTwoSum_Optimized(int[] arr, int target) 
        {

            // Time Complexity : O(n)
            // Space Complexity: O(n)

            if (arr is null || arr.Length < 2) // because two sum required atleast two elements
            {
                throw new ArgumentException("array cannot be null or empty");
            }

            Dictionary<int, int> indexMap = new Dictionary<int, int>();
                      //key:number,value:index

            for (int i = 0; i < arr.Length; i++) 
            {
                int needed = target - arr[i]; // arr[i]= current number
                if (indexMap.ContainsKey(needed))
                {
                    return new int[] { indexMap[needed], i };
                }
                else 
                {
                    //indexMap.Add(arr[i], i);
                    indexMap[arr[i]] = i;
                }                
            }
            return new int[] { };
        } 
    }
}
