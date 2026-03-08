using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.TwoPointers
{
    public static class ClosestPairSum
    {
        // Example

        //Array:

        //[10, 22, 28, 29, 30, 40]

        //Target:

        //54

        //Possible sums:

        //Pair Sum
        //10 + 40	32
        //10 + 28	38
        //22 + 28	50
        //22 + 29	51
        //22 + 30	52
        //28 + 29	57

        //Closest to 54 is:

        //22 + 30 = 52

        //constraint : Closest pair Sum <= Target.

        public static int FindClosestPairSumUnderTarget(int[] arr, int target) 
        {
            //let assume we already have sorted array in this problem.
            //Algorithm
            //two pointers,
            // Sum=0, lastPairSum=0
            //add left and right as Sum and compare with target, if Sum<=target and Sum<=LastPairSum then LastPairSum=Sum.

            if (arr is null || arr.Length == 0)
                return 0;

            int lastSum = int.MinValue;
            int left = 0, right = arr.Length - 1;            
            
            while (left < right) 
            {
                int sum = arr[left] + arr[right];
                if (sum <= target)
                    left++;
                else                
                    right--;
                
                if(sum <=target && lastSum <= sum)
                    lastSum = sum;
            }
            //Console.WriteLine($"Closes Pair Sum: ({left},{right}) ");
            return lastSum;
        }

        public static int FindClosestPairSum(int[] arr, int target) 
        {

            //arr = [-10,-5,-2]   -12,-15,-7
            //target = -3
            //output = -7
            
            //input validation
            if (arr is null || arr.Length == 0)
                return 0;

            int left = 0, right = arr.Length - 1;
            int closestSum = arr[left] + arr[right];

            while (left < right) 
            {
                int sum = arr[left] + arr[right];   //52
                if (Math.Abs(closestSum - target) > Math.Abs(sum - target))
                     // 2    //1
                    closestSum = sum;

                if (sum < target)
                    left++;
                else
                    right--;
            }
            return closestSum;
        }


        public class SumWithPair 
        {
            public int Sum { get; set; }
            public string Pair { get; set; } //(2,3) 
        }

        public static SumWithPair FindPairWithClosestSum(int[] arr, int target)
        {

            //arr = [-10,-5,-2]   -12,-15,-7
            //target = -3
            //output = -7(sum) , -5,-2 (pair)

            //input validation
            if (arr is null || arr.Length == 0)
                return null;


            SumWithPair pair = new SumWithPair();
            int left = 0, right = arr.Length - 1;
            int closestSum = arr[left] + arr[right];

            while (left < right)
            {
                int sum = arr[left] + arr[right];   //52
                if (Math.Abs(closestSum - target) > Math.Abs(sum - target))
                    // 2    //1
                {
                    closestSum = sum;
                    pair.Sum = sum;
                    pair.Pair = $"({arr[left]},{arr[right]})";
                }                      

                if (sum < target)
                    left++;
                else
                    right--;
            }
            return pair;
        }

    }
}
