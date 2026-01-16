using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Traversing
{
    public static class ForwardTraversal
    {
        public static void Traverse(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
