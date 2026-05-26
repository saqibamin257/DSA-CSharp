using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class ReverseArray
    {
        //Time Complexity = O(n)  --> single for loop
        //Space Complexity = O(n) --> because of resultArray initialization

        public static int[] Reverse(int[] arr) 
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            int[] resultArray =  new int [arr.Length];
            //int j = 0;
            for (int i = arr.Length - 1, j=0; i >= 0; i--)
            {
                resultArray[j++] = arr[i];               
            }
            return resultArray;
        }

        //Time Complexity = O(n) --> n/2 because while (left < right) will run half way but in big O notation n/2 is also represents as O(n).
        //Space Complexity = O(1) 

        public static int[] Reverse_TwoPointersAndSwapping(int[] arr)
        {
              if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
            return arr;            
        }
    }
}
