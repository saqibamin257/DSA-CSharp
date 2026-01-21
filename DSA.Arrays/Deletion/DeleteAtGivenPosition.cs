using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Deletion
{
    public static class DeleteAtGivenPosition
    {
        public static int[] Delete(int[] arr, int position) 
        {
            if (arr == null || arr.Length == 0 || position < 0)
                return arr;

            int[] resultArray = new int[arr.Length - 1];
            int j = 0;
            
            for (int i = 0; i < arr.Length; i++) 
            {
                if (i == position - 1)
                    continue;
                
                resultArray[j++] = arr[i];
               
            }
            return resultArray;
        }
    }
}
