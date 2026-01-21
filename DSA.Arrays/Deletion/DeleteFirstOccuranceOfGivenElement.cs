using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Deletion
{
    public static class DeleteFirstOccuranceOfGivenElement
    {
        public static int[] Delete(int[] arr, int element) 
        {
            //first check that given element is present in array or not.

            bool isElementExists = false;
            foreach (int value in arr) 
            {
                if (value == element) 
                {
                    isElementExists = true;
                    break;
                }                    
            }

            //if element does not exists then return original array.
            if (!isElementExists)
                return arr;
            
            
            // Delete First Occurance by skipping that index

            int[] resultArray = new int[arr.Length - 1];
            int j = 0;
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == element && !isFound) 
                {
                    isFound = true;
                    continue;
                }
                resultArray[j++] = arr[i];
            }
            return resultArray;
        }
    }
}
