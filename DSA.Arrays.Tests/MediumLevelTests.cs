using DSA.Arrays.MediumLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Tests
{
    public static class MediumLevelTests
    {
        [Fact]
        public static void ReverseString_Should_Run_Without_Error()
        {
            //Arrange
            string str = "ABCDEF";
            string expectedString = "FEDCBA";


            //Act
            string result = ReverseString.Reverse(str);


            //Assert
            Assert.Equal(result, expectedString);

        }

        [Fact]
        public static void ReverseString_TwoPointers_Should_Run_Without_Error()
        {
            //Arrange
            string str = "ABCDEF";
            string expectedString = "FEDCBA";


            //Act
            string result = ReverseStringTwoPointers.Reverse(str);


            //Assert
            Assert.Equal(result, expectedString);

        }


        [Theory]
        [InlineData("MADAM", true)]
        [InlineData("SAS", true)]
        [InlineData("RADAR", true)]
        [InlineData("NOON", true)]
        [InlineData("LEVEL", true)]
        [InlineData("HELLO", false)]
        [InlineData("WORLD", false)]
        public static void CheckPalindromeByTwoPointer_Should_Run_Successfully(string str, bool expected)
        {
            //Arrange
            //string str = "MADAM";

            //Act
            bool result = CheckPalindrome.PalindromeByTwoPointers(str);


            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("Was it a car or a cat I saw?", true)]
        [InlineData("No 'x' in Nixon", true)]
        [InlineData("Able was I ere I saw Elba", true)]
        [InlineData("Never odd or even", true)]
        [InlineData("Madam In Eden, I'm Adam", true)]
        [InlineData("Step on no pets", true)]
        [InlineData("12321", true)]
        [InlineData("1234321", true)]
        [InlineData("Hello, World!", false)]
        [InlineData("This is not palindrome", false)]
        [InlineData("race a car", false)]
        [InlineData("", true)]                 // empty string case
        [InlineData(" ", true)]                // only space
        [InlineData("a", true)]                // single character
        [InlineData(".,,,!!!", true)]          // only special characters
        public static void Advance_PalindromeByTwoPointer_Should_Run_Successfully(string str,bool expected) 
        {
            //Arrange
            //string str = "A man, a plan, a canal: Panama";
            
            //Act
            bool result = CheckPalindrome.Advance_PalindromeByTwoPointer(str);

            //Assert
            Assert.Equal(result, expected);

        }
    }
}
