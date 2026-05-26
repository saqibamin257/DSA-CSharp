using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class MoveZerosToEnd
    {
        public static int[] MoveZeros(int[] arr) 
        {
            // {3,0,5,0,6,0} ===> {3,5,6,0,0,0}
            // Important point: How do i keep index for next non zero value

            //Time Complexity: O(n)
            //Space Complexity: O(1)

            int nonZeroIndex = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] != 0)
                {
                    if (arr[i]!=nonZeroIndex) // avoid elements self comparision like index 0th element comparision with itself and so on.
                    {
                        (arr[nonZeroIndex], arr[i]) = (arr[i], arr[nonZeroIndex]);
                        nonZeroIndex++;
                    }
                }
                                
            }
            return arr;
        }
    }
}

//           { 3,5,0,0,0,6,7,0}
// i            actualValue          nonZeroIndex                    arr
//                                                                     - 
// 0             3                     1                             { 3,5,0,0,0,6,7,0}      swap index 0 with 0 and increase nonZeroIndex to 1
//                                                                       - 
// 1             5                     2                             { 3,5,0,0,0,6,7,0}      swap index 1 with 2 and increase nonZeroIndex to 2
//                                                                         - 
// 2             0                     2                             { 3,5,0,0,0,6,7,0}
//                                                                           - 
// 3             0                     2                             { 3,5,0,0,0,6,7,0}
//                                                                             - 
// 4             0                     2                             { 3,5,0,0,0,6,7,0}
//                                                                               - 
// 5             6                     3                             { 3,5,6,0,0,0,7,0}     swap index 2 with 5 and increase nonZeroIndex to 3
//                                                                                 - 
// 6             7                     2                             { 3,5,6,7,0,0,0,0}     swap index 3 with 6 and increase nonZeroIndex to 4
