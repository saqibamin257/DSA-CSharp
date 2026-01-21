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
            int n = arr.Length;
            for (int i = 1; i < n; i++) 
            {
                arr[i - 1] = arr[i];
            }
            n--;
            return arr;
        }
    }
}
