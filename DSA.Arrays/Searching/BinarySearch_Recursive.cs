using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Searching
{
    public static class BinarySearch_Recursive
    {
        public static int BinarySearch(int[] arr, int low, int high, int element) 
        {
            if (low <= high) 
            {
                int mid = low + (high - low) / 2;
                
                if (arr[mid] == element) 
                    return 1;

                //if element is greater than mid, use right half side for next search
                else if (element > arr[mid])
                    return BinarySearch(arr, mid + 1, high, element);

                //if element is less than mid, use left half side for next search
                else if (element < arr[mid])
                    return BinarySearch(arr, low, mid-1, element);
            }
            //if we reach here, it means element is not present in an array.
            return -1;            
        }
    }
}
