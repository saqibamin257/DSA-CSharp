using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class ValidAnagram
    {
        //Same characters
        //Same frequency
        //Different order allowed

        //Example-1
        //s = "listen"
        //t = "silent"
        //true

        //Example-2
        //s = "rat"
        //t = "car"
        //false

        //Time Complexity:  O(n)
        //Space Complexity: O(n)
        public static bool isValid_By_TwoDictionaries(string firstString, string secondString)
        {
            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                throw new ArgumentException("input string can not be null or empty");
            }
            if (firstString.Length != secondString.Length)
            {
                return false;
            }

            // algorithm
            // both arrays must have same length
            // convert both string to char array
            // create two dictionaries to save character and its frequency.
            // loop through one array and check the frequency is same in both dictionaries, if same then true else false

            char[] firstArray = firstString.ToCharArray();
            char[] secondArray = secondString.ToCharArray();
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            // add character and  its frequency for firstString
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (!dict1.ContainsKey(firstArray[i]))
                {
                    dict1[firstArray[i]] = 1;
                }
                else
                {
                    dict1[firstArray[i]] = dict1[firstArray[i]] + 1;
                }
            }

            // add character and  its frequency for secondString

            for (int j = 0; j < secondArray.Length; j++)
            {
                if (!dict2.ContainsKey(secondArray[j]))
                {
                    dict2[secondArray[j]] = 1;
                }
                else
                {
                    dict2[secondArray[j]] = dict2[secondArray[j]] + 1;
                }
            }

            // Match character and frequency
            // issue: this loop will check same character again and again

            //for (int k = 0; k < firstArray.Length; k++) 
            //{
            //    if (!dict1.ContainsKey(firstArray[k]) || !dict2.ContainsKey(firstArray[k]))
            //    {
            //        return false;
            //    }
            //    else 
            //    {
            //        if (dict1[firstArray[k]] != dict2[firstArray[k]]) 
            //        {
            //            return false;
            //        }                   
            //    }                
            //}
            //return true;


            // Better solution match character and frequency from Dictionary
            foreach (var item in dict1)
            {
                // case: key doesn't exists
                if (!dict2.ContainsKey(item.Key))
                {
                    return false;
                }
                //case: frequency is not same
                if (dict1[item.Key] != dict2[item.Key])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool isValid_Optimized(string firstString, string secondString)
        {
            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                throw new ArgumentException("input string can not be null or empty");
            }
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
            char[] firstArray = firstString.ToCharArray();
            char[] secondArray = secondString.ToCharArray();
            Dictionary<char, int> dict1 = new Dictionary<char, int>();

            // add character and  its frequency for firstString
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (!dict1.ContainsKey(firstArray[i]))
                {
                    dict1[firstArray[i]] = 1;
                }
                else
                {
                    dict1[firstArray[i]] = dict1[firstArray[i]] + 1;
                }
            }

            // subtract frequency of characters from dictionary for secondString

            for (int j = 0; j < secondArray.Length; j++)
            {
                if (!dict1.ContainsKey(secondArray[j]))
                {
                    return false;
                }
                else
                {
                    dict1[secondArray[j]] = dict1[secondArray[j]] - 1;
                }
            }
            //Return true only if all frequencies are zero.

            //int result = dict1.Where(x => x.Value != 0).Count();
            //return result > 0 ? false : true;

            return !dict1.Any(x => x.Value != 0); 
        }
    }
}

