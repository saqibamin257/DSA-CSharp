using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Deletion
{
    public static class DeleteFromBeginning
    {
        public static int[] Delete(int[] arr) 
        {
            //int[] arr = { 10, 20, 30, 40 };
            
            //input validation
            if (arr == null || arr.Length == 0)
                return arr;

            int[] resultArray = new int[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++) 
            {
                resultArray[i-1] = arr[i];
            }
            
            return resultArray;
        }
    }
}
