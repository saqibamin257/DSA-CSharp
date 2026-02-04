using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.MediumLevel
{
    public static class ReverseString
    {
        public static string Reverse(string str) 
        {
            //input validation
            if (str == null || str.Length < 1)
                return str;

            
            // string resultString = string.Empty; 
            // for (int i = str.Length - 1; i >= 0; i--)
            // {
            //    resultString += str[i];
            // }

            // lesson:
            // concatenating string inside loop like resultString+= str[i]; will result O(n^2)
            // Every += will create new string as strings are immutable
            // Best Approach is use stringBuilder instead of string.

            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                sb.Append(str[i]);
            }            
            return sb.ToString();
        }        
    }
}
