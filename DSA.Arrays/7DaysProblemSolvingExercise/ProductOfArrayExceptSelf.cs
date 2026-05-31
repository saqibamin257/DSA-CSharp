using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] Product(int[] arr) 
        {

            // input  [1,2,3,4]
            // output [24,12,8,6]
            // 24 = 2×3×4
            // 12 = 1×3×4
            // 8 = 1×2×4
            // 6 = 1×2×3

            //Time Complexity : O(n)
            //Space Complexity : O(n) because of resultArray

            //Conclusion This approach will fail if array contain any 0 element, in that case the product will always be zero.
            
            int productOfNumbers = 1;

            for (int i = 0; i < arr.Length; i++) 
            {
                productOfNumbers = productOfNumbers * arr[i];
            }
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) 
            {
                result[i] = productOfNumbers / arr[i];
            }
            return result;
        }

        public static int[] Product_By_BruteForce(int[] arr) 
        {
            if (arr is null || arr.Length == 0)
                throw new ArgumentException("input array cannot be null or empty");

            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++) 
            {
                int leftProduct = 1;
                int rightProduct = 1;

                //next product                
                {
                    for (int next = i + 1; next < arr.Length; next++)
                    {
                        rightProduct = rightProduct * arr[next];
                    }
                }
                

                // previous products
                if (i > 0) 
                {
                    for (int previous = i - 1; previous >= 0; previous--)
                    {
                        leftProduct = leftProduct * arr[previous];
                    }
                }
                result[i] = rightProduct * leftProduct;                
            }
            return result;
        }

        //Dry Run
        // input  [1,2,3,4]
        // i             leftProduct            RightProduct          result = nextProduct + previousProduct

        // 0               1                          2*3*4 =24          result[0]= 24           {24,0,0,0}

        // 1               1*1 = 1                    3*4 = 12           result[1]= 12*1 = 12    {24,12,0,0}

        // 2               2*1 = 2                    4 = 4              result[2]= 4*2 = 8      {24,12,8,0}

        // 3               3*2*1 = 6                  1                  result[3] =6*1=6        {24,12,8,6}


        public static int[] Product_Optimized(int[] arr) 
        {
            if (arr is null || arr.Length == 0)
                throw new ArgumentException("input array cannot be null or empty");

            //left product Array
            int[] leftProductsArray = new int[arr.Length];  //input  [1,2,3,4] output  [1,1,2,6]
            int leftProduct = 1;
            for (int i = 0; i < arr.Length; i++) 
            {
                leftProduct = i == 0 ? leftProduct : leftProduct * arr[i-1];
                leftProductsArray[i] = leftProduct;
            }

            //Dry Run
            // i            //leftProduct                 //leftProductArray

            // 0             1                              1

            // 1             1                              1

            // 2             2                              2

            // 3             6                              6




            //right product Array

            int[] rightProductArray = new int[arr.Length]; // input  [1,2,3,4] output [24,12,4,1]
            int rightProduct = 1;
            for (int right= arr.Length-1; right>=0; right--) 
            {
                rightProduct = right == arr.Length-1 ? rightProduct : rightProduct * arr[right+1];
                rightProductArray[right] = rightProduct;
            }

            //Dry Run


            // i            //rightProduct                 //rightProductArray

            // 0             1                               1

            // 1             4                               4

            // 2             12                              12

            // 3             24                              24

            int[] resultArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) 
            {
                resultArray[i] = leftProductsArray[i] * rightProductArray[i];
            }

            return resultArray;
                       
        }


        public static int[] FindProduct_Except_itself_Optimized_Cleaned(int[] arr) 
        {
            // Summary:
            //
            // For each index:
            //
            // Result[i] = Product of all elements before i
            //           * Product of all elements after i
            //
            // To avoid recalculating products repeatedly:
            //
            // 1. Build a prefix product array.
            //    prefix[i] contains the product of all elements
            //    before index i.
            //
            // 2. Build a postfix product array.
            //    postfix[i] contains the product of all elements
            //    after index i.
            //
            // 3. Multiply prefix[i] and postfix[i]
            //    to get the final answer.
            //
            // Example:
            //
            // Input : [1,2,3,4]
            //
            // Prefix : [1,1,2,6]
            // Postfix: [24,12,4,1]
            //
            // Result : [24,12,8,6]
            //
            // Time Complexity : O(n)
            // Space Complexity: O(n)

            if (arr is null || arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }


            //Prefix Product   //input  [1,2,3,4] output  [1,1,2,6]

            int prefixProduct = 1;
            int[] prefixProductArray = new int[arr.Length];           
            for (int i = 0; i < arr.Length; i++) 
            {
                prefixProduct = i == 0 ? 1 : prefixProduct * arr[i - 1];
                prefixProductArray[i] = prefixProduct;
            }


            // Postfix Product   input  [1,2,3,4] output [24,12,4,1]
            int postfixProduct = 1;
            int[] postfixProductArray = new int[arr.Length];
            for (int j = arr.Length - 1; j >= 0; j--) 
            {
                postfixProduct = j == arr.Length - 1 ? 1 : postfixProduct * arr[j+1];
                postfixProductArray[j] = postfixProduct;
            }

            // result
            int[] result = new int[arr.Length];
            for (int k = 0; k < arr.Length; k++)             
            {
                result[k] = prefixProductArray[k] * postfixProductArray[k];
            }

            return result;
        }
    }
}
