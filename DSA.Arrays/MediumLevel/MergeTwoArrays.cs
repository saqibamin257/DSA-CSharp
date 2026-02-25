using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.Arrays.MediumLevel
{
    public static class MergeTwoArrays
    {
        public static int[] Merge(int[] arr1, int[] arr2) 
        {
            int[] resultArray = new int[arr1.Length + arr2.Length];

            //input validation
            if ((arr1 is null || arr2 is null) && (arr1.Length == 0 || arr2.Length == 0))
                return arr1;


            //arr1=[1,4,7]   arr2=[2,3,6]

            int left = 0;  //arr1 pointer
            int right = 0; //arr2 pointer
            int index = 0; //resultArray index counter

            while (left < arr1.Length && right < arr2.Length) 
            {
                if (arr1[left] < arr2[right])
                {
                    resultArray[index] = arr1[left];
                    left++;
                    index++;
                }
                else if (arr2[right] < arr1[left]) 
                {
                    resultArray[index] = arr2[right];
                    right++;
                    index++;
                }
            }

            //The main loop runs while both arrays have elements.
            //When one array finishes, the other may still contain elements.
            //Since arrays are already sorted, the remaining elements are guaranteed to be larger and can be appended directly without comparison.
            //Therefore, separate loops are required to copy leftover elements.

            //remainig elements
            while (left < arr1.Length) 
            {
                resultArray[index] = arr1[left];
                left++;
                index++;
            }
            while (right < arr2.Length) 
            {
                resultArray[index] = arr2[right];
                right++;
                index++;
            }
            return resultArray;
        }
    }
}
