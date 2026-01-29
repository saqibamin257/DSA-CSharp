using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.TwoPointers
{
    public static class PairSumTwoPointers
    {
        public static bool HasPairWithSum(int[] arr, int target) 
        {
            //consider input array is alway a sorted array

            //Input validation
            if (arr == null ||arr.Length < 2 )
                return false;

            int left = 0;
            int right = arr.Length-1;
            
            while (left < right) 
            {
                int sum = arr[left] + arr[right];

                if (sum == target)
                    return true;

                else if (sum > target)                    
                    right--;

                else
                    left++;                     
            }
            return false;
        }
    }
}
