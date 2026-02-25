using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace DSA.Arrays.MediumLevel
{
    public static class RemoveDuplicateFromSortedArray
    {
        public static int[] Remove(int[] arr) 
        {
            //input validation
            if (arr is null || arr.Length == 0)
                return arr;

            //First Count the No. of repitions of numbers, to set length of new array
            int count = 0;
            int resultCounter = 0;
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i] == arr[i + 1])
                    count++;
            }
            
            // Declare new resultArray
            int[] resultArray = new int[arr.Length - count];
            
            //Remove Duplicate Process
            for (int j = 0; j < arr.Length; j++) 
            {
                //important concept here: arr[j-1] should show exception when j=0 because j-1 would be exception error,
                //but C# in OR condition ||, evaluate the left expression first if that is true then it wont evaluate the right expression, which is the case here when j=0.
                if (j == 0 || arr[j] != arr[j - 1]) 
                {
                    resultArray[resultCounter] = arr[j];
                    resultCounter++;
                }                                
            }            
            return resultArray;
        }
    }
}
