using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.MediumLevel
{
    public static class ReverseStringTwoPointers
    {
        public static string Reverse(string str) 
        {
            //input validation
            if (string.IsNullOrEmpty(str))
                return str;

            //we will use tuple here, it swaps without the need of temp variable.
            char[] chars = str.ToCharArray();
            
            int left = 0;
            int right = chars.Length - 1;
            
            while (left < right) 
            {
                (chars[left], chars[right]) = (chars[right], chars[left]);
                right--;
                left++;
            }
            return new string(chars);
        }
    }
}
