using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int CountDuplicates_By_HashSet(int[] arr) 
        {
            // input: [1,1,1,2,2,3,3,4]
            // output: 4

             // input: [1,1,2]
            // output: 2

            // Time Complexity: O(n): only single loop
            // Space Complexity: HashSet O(n) : because HashSet will store array unique elements i.e {1,2,3,4,5}
            //                  Initialize int i :O(1)
            //                  HashSet Add and contain method : O(1)
            // Total SpaceComplexity :O(n)

            if (arr is null || arr.Length == 0) 
            {
                throw new ArgumentException("array cannot be null or empty");
            }

            HashSet<int> uniqueSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++) 
            {
                if ( !uniqueSet.Contains(arr[i]) ) 
                {
                    uniqueSet.Add(arr[i]);                    
                }
            }
            return uniqueSet.Count;
        }


        public static int CountDuplicate_SortedArray_Optimization(int[] arr)
        {
            // input will always be sorted array
            // input: [1,1,2,2,3,3,4]
            // output: 4

            // Summary
            // As we already have sorted array, so the next value could be equal or greater than current value but the next value can never be less than current value,
            // That is Why this logic would work if(arr[i]==arr[i+1]) count++;
            // Algorithm:
            // Count how many times an element is getting repeated and subtract from array length to get the unique elements count, This is very important concepts,
            // i can summarize it like check how many times single elements is repeated [1,1] = repeatation=1   [3,3,3] repeatation = 2 
            
            //e.g {1,1,1,2,2}
            // 1 is repeated 2 times and 2 is repeated 1 time.
            // Total repeatation = 3
            // UniqueElements = arr length - repeats = 5-3=2

            //Time

            //Time Complexity: O(n): only single loop
            //Space Complexity: var count,i and uniqueElementsCount initialization: O(1)

            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i] == arr[i + 1]) 
                {
                    count++;
                }
            }
            int uniqueElementsCount= arr.Length - count;
            return uniqueElementsCount;
        }


        public static int CountDuplicates_And_Replace_RepeatedElements(int[] arr)
        {
            // input will always be sorted array
            // input: [1,1,1,2,2,3,3,4] =====>[1,2,3,4,-1,-1,-1]

            //repeatedElementsIndex =1,2,4,6
            // output: 4

            if (arr is null || arr.Length == 0) 
            {
                throw new ArgumentException("array cannot be null or empty");
            }


            //Step-1
            // store index positions of repeated elements
            List<int> repeatedElementsIndex = new List<int>();
            int count = 0;
            for (int i = 0; i < arr.Length-1; i++) 
            {
                if (arr[i] == arr[i + 1]) 
                {
                    repeatedElementsIndex.Add(i + 1);
                    count++;
                }
            }
            //Step-2

            //replace repeated elements with -1
            // 1,-1,-1,2,-1,3,-1,4

            for (int j = 0; j < repeatedElementsIndex.Count; j++) 
            {
                int index = repeatedElementsIndex[j];
                arr[index] = -1;
            }


            //Step-3
            // replace non repeatative numbers with -1
            // 1,2,3,4,-1,-1,-1,-1

            int nonRepeatedElementIndex = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] != -1)
                {
                   
                  (arr[nonRepeatedElementIndex], arr[i]) = (arr[i], arr[nonRepeatedElementIndex]);
                  nonRepeatedElementIndex++;
                                        
                }
            }
            return arr.Length-count;            

        }

        public static int RemoveDuplicates_CountDuplicate_Best_Solution(int[] arr)
        {
            // Summary:
            // The array is already sorted, which means duplicate values are always adjacent.
            //
            // We use the Read Pointer + Write Pointer pattern:
            //
            // - readIndex scans every element in the array.
            // - writeIndex tracks the position where the next unique element should be placed.
            //
            // The first element is always unique, so writeIndex starts at 1.
            //
            // Whenever the current value differs from the last accepted unique value
            // (arr[writeIndex - 1]), we copy it to arr[writeIndex] and advance writeIndex.
            //
            // After the loop:
            // - The first writeIndex elements contain all unique values in sorted order.
            // - Elements after writeIndex are irrelevant and can contain any values.
            // - writeIndex represents the count of unique elements.
            //
            // Example:
            // Input : [1,1,1,2,2,3,3,4]
            // Output: [1,2,3,4,_,_,_,_]
            // Return: 4
            //
            // Time Complexity : O(n)
            // Space Complexity: O(1)


            if (arr is null || arr.Length == 0)
            {
                throw new ArgumentException("array cannot be null or empty");
            }

            int writeIndex = 1;

            for (int readIndex = 1; readIndex < arr.Length; readIndex++)
            {
                if (arr[readIndex] != arr[writeIndex-1])
                {
                    arr[writeIndex] = arr[readIndex];
                    writeIndex++;
                }   
            }
            return writeIndex;
        }
        //Dry Run    arr=[1,1,1,2,2,3,3,4]

        // read               write               arr[readIndex] != arr[writeIndex-1]       arr=[1,1,1,2,2,3,3,4]

        // 1                    1                          false                                [1,1,1,2,2,3,3,4]

        // 2                    1                          false                                [1,1,1,2,2,3,3,4]

        // 3                    1                          true                                 [1,2,1,2,2,3,3,4]     writeIndex++

        // 4                    2                          false                                [1,2,1,2,2,3,3,4]

        // 5                    2                          true                                 [1,2,3,2,2,3,3,4]     writeIndex++

        // 6                    3                          false                                [1,2,3,2,2,3,3,4]     

        // 7                    3                          true                                 [1,2,3,4,2,3,3,4]     

    }
}
