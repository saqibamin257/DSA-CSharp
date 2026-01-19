using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Insertion
{
    public static class InsertAtEnd
    {
        public static int[] Insert(int[] arr, int element) 
        {
            int[] resultArray = new int[arr.Length + 1];
            int lastIndex = resultArray.Length - 1;
            
            //first copy exsting elements to new array
            for (int i = 0; i < arr.Length; i++) 
            {
                resultArray[i] = arr[i];
            }
            //insert at last index
            resultArray[lastIndex] = element;
            return resultArray;
        } 
    }
}
