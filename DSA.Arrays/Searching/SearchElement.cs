using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Searching
{
    public static class SearchElement
    {
        // search for an element in the array and return its index, or -1 if not found
        public static int Search(int[] arr, int target) 
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == target) 
                {
                    return i;
                }               
            }
            return -1;
        }
    }
}
