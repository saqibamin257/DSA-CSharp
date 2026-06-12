using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays._7DaysProblemSolvingExercise
{
    public static class FirstNonRepeatingCharacter
    {
        // Summary:
        //
        // Count frequency of each character using a Dictionary.
        //
        // Second pass through the string:
        //
        // The first character whose frequency is 1
        // is the first non-repeating character.
        //
        // Return its index.
        //
        // If no unique character exists,
        // return -1.
        //
        // Time Complexity : O(n)
        // Space Complexity: O(n)
        public static int FindIndexOfNonRepeatingCharacter(string str) 
        {
            if (string.IsNullOrEmpty(str))
            { return -1; }

            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();            

            // Add character wih its frequencies to indexMap
            for (int i = 0; i < str.Length; i++) 
            {
                if (!frequencyMap.ContainsKey(str[i]))
                {
                    frequencyMap[str[i]] = 1;
                }
                else 
                {
                    frequencyMap[str[i]] ++;  //increment
                }
            }
            // check first character
            for (int j = 0; j < str.Length; j++) 
            {
                if (frequencyMap[str[j]] == 1) 
                {
                    return j;
                }
            }
            return -1;
        }
    }
}
