using DSA.Arrays.TwoPointers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Tests
{
    public static class TwoPointersTests
    {
        [Fact]
        public static void PairSumBruteForce_AllPairWithSum_Should_Run_WithoutError() 
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 60;

            //Act
            List<string> pairs = PairSumBruteForce.AllPairWithSum(arr, target);
            List<string> expectedPairs = new List<string>() {"(10,50)","(20,40)"};
           
            
            //Assert
            Assert.Equal(pairs.Count(), expectedPairs.Count());
            foreach (var expected in expectedPairs) 
            {
                Assert.Contains(expected, pairs);
            }
        }

        [Fact]
        public static void PairSumBruteForce_HasPairWithSum_Should_Run_WithoutError()
        {
            //Arrange
            int[] arr = { -8, 1, 4, 6, 10,45 };
            int target = 16;

            //Act
            bool pairs = PairSumBruteForce.HasPairWithSum(arr, target);

            //Assert
            Assert.Equal(pairs,true);            
        }

        [Fact]
        public static void PairSumTwoPointers_HasPairWithSum_Should_Run_WithoutError()
        {
            //Arrange
            int[] arr = { -8, 1, 4, 6, 10, 45 };
            int target = 16;

            //Act
            bool pairs = PairSumBruteForce.HasPairWithSum(arr, target);

            //Assert
            Assert.Equal(pairs, true);
        }


    }
}
