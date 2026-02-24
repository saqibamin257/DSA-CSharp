using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DSA.Arrays.MediumLevel
{
    public static class CheckPalindrome
    {
        //public static bool PalindromeByTwoPointers(string str)
        //{
        ////Input validation
        //if (string.IsNullOrEmpty(str) || str.Length < 2)
        //    return false;

        //int length = str.Length;
        //int start = 0;            
        //int end = length - 1;

        //int mid = 0;
        //if (length % 2 != 0)   //ODD length
        //    mid = length - 1 / 2;
        //else
        //    mid = length / 2;  //Even length

        //char[] wordArray = str.ToLower().ToCharArray(); // avoid capital and small letters difference.
        //while (start < mid) 
        //{
        //    if (wordArray[start] != wordArray[end])
        //        return false;
        //    else
        //    {
        //        start++;
        //        end--;
        //    }
        //}
        //return true;
        //}

        //Time Complexity: O(n)
        //Space Complexity: O(n) (because of ToCharArray())

        //char[] wordArray = str.ToLower().ToCharArray();
        //New lowercase string
        //New char array





        //------------------Better Approach ------------------------//
        //1- No need to calculate mid as it is already being handle in while condition. As we are increasing Start and decreasing End
        //2- A and emptyspace "" --Single letter is also palindrome, so improve condtion.
        //3- Reduce space complexity by removing conversion process to small letters, it creates another string

        public static bool PalindromeByTwoPointers(string str)
        {
            //Input validation
            if (str == null)
                return false;


            int start = 0;
            int end = str.Length - 1;


            while (start < end)
            {
                if (char.ToLower(str[start]) != char.ToLower(str[end]))
                    return false;
                else
                {
                    start++;
                    end--;
                }
            }
            return true;
        }
        //Time Complexity: O(n)
        //Space Complexity: O(1)
        
        
        
        
        //------------------Advance Approach ------------------------//
        // "A man, a plan, a canal: Panama"
        // 1- Check if the character on left side is not Letter or Digit then Start++, Same with Right side End--.

        public static bool Advance_PalindromeByTwoPointer(string str)
        {
            if (str == null)
                return false;
            
            int start = 0;
            int end = str.Length - 1;

            while (start < end) 
            {
                if (!char.IsLetterOrDigit(str[start])) 
                {
                    start++;
                    continue;
                }
                if (!char.IsLetterOrDigit(str[end]))
                {
                    end--;
                    continue;
                }
                if (char.ToLower(str[start]) != char.ToLower(str[end])) 
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;            
        }
    }
}




