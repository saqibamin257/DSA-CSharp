using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Searching
{
    public static class BinarySearch_Iterative
    {
        public static int BinarySearch(int[] arr, int element) 
        {
            //assume we already have  sorted array for binary search.

            //low and high indexes
            int low = 0; int high = arr.Length - 1;

            while (low <= high)             
            {
                int mid = low + (high - low) / 2;

                //if element found at mid
                if (arr[mid] == element)
                    return 1;

                //if element is greater than mid, use right half side for next search
                if (element > arr[mid])
                {
                    low = mid + 1;
                }
                //if element is less than mid, use left half side for next search
                else
                {
                    high = mid - 1;
                }
            }
            //if we reach here, it means element is not present in an array.
            return -1;
        }
    }
}
