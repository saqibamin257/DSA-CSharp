using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Deletion
{
    public static class DeleteAllOccuranceOfGivenElement
    {
        public static int[] Delete(int[] arr, int element) 
        {
            //Input validation
            if (arr.Length == 0 || arr == null)
                return arr;

            //check given element existence in an array
            //As we need to initialize resultArray and we need to set the length of array excluding no. of counts of given array, so we use counter to find two things.
            //(a)- Does element exists in an array.
            //(b)- Total no. of occurence of that element,
            int elementCounter = 0;             
            foreach (int value in arr) 
            {
                if (value == element) 
                {                   
                    elementCounter++;
                }
            }
            
            //if element doesn't exists in the given array then retrun original array.
            if (elementCounter == 0)
                return arr;

            // Delete all elements from the array.
            //{10,20,30,20,40,50}
            //elemtent: 20 output {10,30,40,50}

            int[] resultArray = new int[arr.Length - elementCounter];
            int j = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == element)
                    continue;

                resultArray[j++] = arr[i];
            }
            return resultArray;
        }
    }
}
