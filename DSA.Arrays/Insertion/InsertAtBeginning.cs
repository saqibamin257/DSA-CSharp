using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Insertion
{
    public static class InsertAtBeginning
    {
        public static int[] InsertAtZero_ByCreatingNewArray(int[] arr,int value) 
        {
            int[] resultArray = new int [arr.Length + 1];
            resultArray[0] = value;
            for (int i = 0; i < arr.Length; i++) 
            {
                resultArray[i + 1] = arr[i];  
            }
            return resultArray;
        }
        public static int[] InsertAtZero_ByUsingList(int[] arr, int value) 
        {
            List<int> arrayList = new List<int>(arr);
            arrayList.Insert(0, value);
            return arrayList.ToArray();
        }
    }
}
