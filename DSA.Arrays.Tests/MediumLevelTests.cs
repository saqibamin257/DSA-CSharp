using DSA.Arrays.MediumLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Tests
{
    public static class MediumLevelTests
    {
        [Fact]
        public static void ReverseString_Should_Run_Without_Error ()
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
    }
}
