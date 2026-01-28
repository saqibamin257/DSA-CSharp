using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Deletion
{
    public static class DeleteLastElementOfArray
    {
        public static int[] Delete(int[] arr) 
        {
            //input validation
            if (arr == null || arr.Length == 0)
                return arr;

            int[] resultArray = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                resultArray[i] = arr[i];
            }
            return resultArray;
        }
    }
}
