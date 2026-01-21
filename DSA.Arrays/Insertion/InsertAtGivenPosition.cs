using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Insertion
{
    public static class InsertAtGivenPosition
    {
        public static int[] Insert(int[] arr, int position, int element) 
        {
            //if postion is 2 it means place that element at index:1 in an array, As array index starts with 0.
            

            // input validation
            if (position < 1 || position > arr.Length + 1)
                throw new ArgumentOutOfRangeException(nameof(position));

            //create new arr with n+1 size of given array.
            int[] resultArray = new int [arr.Length+1];
            
            //insertedIndex
            int insertIndex = position - 1;

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i < insertIndex)
                {
                    resultArray[i] = arr[i];
                }
                else if (i == insertIndex)
                {
                    resultArray[i] = element;
                }
                else
                {
                    resultArray[i] = arr[i - 1];
                }
            }
            return resultArray;
        }
    }
}
