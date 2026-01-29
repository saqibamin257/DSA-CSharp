using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.TwoPointers
{
    public static class PairSumBruteForce
    {
        public static bool HasPairWithSum(int[] arr, int target) 
        {
            
            //Theory
            //{10,20,30,40,50 }
            //pairs: 10: 20,30,40,50 => (10,20),(10,30),(10,40),(10,50)
            //pairs: 20: 30,40,50 => (20,30),(20,40),(20,50)
            //pairs: 30: 40,50 => (30,40),(30,50)
            //pairs: 40: 50 => (40,50)
            //target = 60, possible pairs (10,50), (20,40)
            
            
            // Return true if pair exists for target, here we will return on first successful pair.

            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    if (arr[i] + arr[j] == target)
                        return true;
                }
            }
            return false;
        }

        public static List<string> AllPairWithSum(int[] arr, int target)
        {

            //Theory
            //{10,20,30,40,50 }
            //pairs: 10: 20,30,40,50 => (10,20),(10,30),(10,40),(10,50)
            //pairs: 20: 30,40,50 => (20,30),(20,40),(20,50)
            //pairs: 30: 40,50 => (30,40),(30,50)
            //pairs: 40: 50 => (40,50)
            //target = 60, possible pairs (10,50), (20,40)


            // Return all pairs whose sum makes target, 
            List<string> pairs = new List<string>();
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                        pairs.Add($"({arr[i]},{arr[j]})");
                }
            }
            return pairs;
        }
    }
}
