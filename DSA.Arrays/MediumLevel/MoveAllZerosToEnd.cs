using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.MediumLevel
{
    public static class MoveAllZerosToEnd
    {
        public static int[] MoveZeros(int[] arr) 
        {
            //input validation
            if (arr == null || arr.Length == 0)
                return arr;

            int[] resultArray = new int[arr.Length];
            int indexForZero = arr.Length - 1;
            int j = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == 0)
                {
                    resultArray[indexForZero] = arr[i];
                    indexForZero--;
                }
                else 
                {
                    resultArray[j] = arr[i];
                    j++;
                }
            }
            return resultArray;
        }
        // Time Complexity: O(n)
        // Space Complexity: O(n)


        //------------Improved version -----------------//
        //This is in place operation, so we dont need another array because we use new array in case of insert/delete values from original array.
        //Introducing new array  int[] resultArray = new int[arr.Length] is actually causing space complexity : O(n), which is unneccessary and we can achieve the target by using original Array.
        //Single loop swap Approach
        public static int[] MoveZeros_ImprovedVersion(int[] arr) 
        {
            int lastNonZero = 0;
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i] != 0) 
                {
                    (arr[lastNonZero], arr[i]) = (arr[i], arr[lastNonZero]);
                    lastNonZero++;
                }
            }
            return arr;
        }
        // Time Complexity: O(n)
        // Space Complexity: O(1): we have not initialized any thing like array or list which cause O(n), only one variable lastNonZero which is constant.
    }
}
