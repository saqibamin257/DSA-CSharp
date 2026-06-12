using DSA.Arrays._7DaysProblemSolvingExercise;
using System;
using System.Collections.Generic;
using System.Text;
using static DSA.Arrays._7DaysProblemSolvingExercise.KadaneAlgorithm_FindContigousSubArrayOfLargestSum;

namespace DSA.Arrays.Tests
{
    public class _7DaysProblemSolvingExercise
    {

        [Fact]
        public void FindMaximumNumber_Should_Return_Max_Number()
        {
            //arrange
            int[] arr = { 1, 5, 12, 30, 25 };

            //act
            int result = FindMaximumNumber_Array.FindMaximumNumber(arr);
            //int expectedMax = arr.Max();
            int expectedMaxValue = arr.OrderByDescending(x => x).FirstOrDefault();
            //Assert
            Assert.Equal(result, expectedMaxValue);
        }

        [Fact]
        public void ReverseIntegerArray_Should_Run_Successfully()
        {
            //arrange
            int[] arr = { 1, 2, 3, 4, 5 };

            //act
            int[] resultArray = ReverseArray.Reverse(arr);

            //Assert
            Assert.Equal(arr[0], resultArray[resultArray.Length - 1]);
        }


        [Fact]
        public void ReverseIntegerArray_ByTwoPointerAndSwapping_Should_Run_Successfully()
        {
            //arrange
            int[] arr = { 1, 2, 3, 4, 5 };

            //act
            int[] resultArray = ReverseArray.Reverse_TwoPointersAndSwapping(arr);

            //Assert
            Assert.Equal(arr[0], 5);
        }

        [Fact]
        public void AnyDuplicateValueinArray_Shoudld_Run_Successfully()
        {
            //arrange
            int[] arr = { 1, 2, 3, 4, 5, 5 };
            int[] arr2 = { 1, 2, 3, 4, 5 };

            //act
            //bool result = DuplicateElementInArray.Duplicate(arr);
            bool result = DuplicateElementInArray.Duplicate(arr2);

            //assert
            //Assert.Equal(true, result);
            Assert.Equal(false, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, false)]
        [InlineData(new int[] { 1, 2, 3, 3, 4, 56 }, true)]
        [InlineData(new int[] { 2, 3, 4, 5, 5, 6, 0 }, true)]
        public void Duplicate_By_HashSet_Shoudld_Run_Successfully(int[] arr, bool expectedResult)
        {
            //arrange
            //int[] arr = { 1, 2, 3, 4, 5, 5 };
            //int[] arr2 = { 1, 2, 3, 4, 5 };

            //act
            //bool result = DuplicateElementInArray.Duplicate(arr);
            bool result = DuplicateElementInArray.Duplicate_By_HashSet(arr);

            //assert
            //Assert.Equal(true, result);
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> TwoSumTestData =>
        new List<object[]>
        {
            // normal case
            new object[]
            {
                new int[] { 3, 2, 4 },
                6,
                new int[] { 1, 2 }
            },

            // first two numbers
            new object[]
            {
                new int[] { 2, 7, 11, 15 },
                9,
                new int[] { 0, 1 }
            },

            // duplicate numbers
            new object[]
            {
                new int[] { 3, 3 },
                6,
                new int[] { 0, 1 }
            },

            // negative numbers
            new object[]
            {
                new int[] { -1, -2, -3, -4, -5 },
                -8,
                new int[] { 2, 4 }
            },
            
            // no solution
            new object[]
            {
                new int[] { 1, 2, 3 },
                100,
                Array.Empty<int>()
            }
        };

        [Theory]
        [MemberData(nameof(TwoSumTestData))]
        public void FindPairOfTwoSum_BruteForce_Should_Return_Expected_Result(int[] arr, int target, int[] expected)
        {
            // Act
            int[] result = TwoSum.FindPairOfTwoSum_BruteForce(arr, target);

            // Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [MemberData(nameof(TwoSumTestData))]
        public void FindTwoSum_Optimized_Should_Return_Expected_Result(int[] arr, int target, int[] expected)
        {
            // Act
            int[] result = TwoSum.FindTwoSum_Optimized(arr, target);

            // Assert
            Assert.Equal(expected, result);
        }




        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 5 }, new int[] { 1, 2, 3, 5, 0 })]
        [InlineData(new int[] { 1, 2, 3, 0, 5, 0, 0, 10 }, new int[] { 1, 2, 3, 5, 10, 0, 0, 0 })]
        [InlineData(new int[] { 0, 0, 3, 0, 5, 0, 0, 10 }, new int[] { 3, 5, 10, 0, 0, 0, 0, 0 })]
        public void MoveZerosToEnd_Shoudld_Run_Successfully(int[] arr, int[] expectedResult)
        {
            //arrange
            //int[] arr = { 1, 2, 3, 4, 5, 5 };
            //int[] arr2 = { 1, 2, 3, 4, 5 };

            //act
            //bool result = DuplicateElementInArray.Duplicate(arr);
            int[] result = MoveZerosToEnd.MoveZeros(arr);

            //assert
            //Assert.Equal(true, result);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 3, 3, 4, 5 }, 6)]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 4, 5, 5, 6, 6 }, 6)]
        public void RemoveDuplicateFromSortedArray_Using_HashSet_Should_Run_Successfully(int[] arr, int expectedResult)
        {
            //arrange


            //act
            int result = RemoveDuplicatesFromSortedArray.CountDuplicates_By_HashSet(arr);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 3, 3, 4, 5 }, 6)]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 4, 5, 5, 6, 6 }, 6)]
        public void RemoveDuplicateFromSortedArray_Using_BruteForce_WithSimpleLoop_Should_Run_Successfully(int[] arr, int expectedResult)
        {
            //arrange


            //act
            int result = RemoveDuplicatesFromSortedArray.CountDuplicate_SortedArray_Optimization(arr);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountDuplicates_And_Replace_RepeatedElements_Should_Run_Successfully()
        {
            //arrange
            int[] arr = { 1, 1, 1, 2, 2, 3, 3, 4 };
            //act
            int result = RemoveDuplicatesFromSortedArray.CountDuplicates_And_Replace_RepeatedElements(arr);
            //assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void RemoveDuplicates_CountDuplicate_Best_Solution_Should_Run_Successfully()
        {
            // Arrange
            int[] arr = { 1, 1, 1, 2, 2, 3, 3, 4 };

            // Act
            int uniqueCount =
                RemoveDuplicatesFromSortedArray
                    .RemoveDuplicates_CountDuplicate_Best_Solution(arr);

            // Assert
            Assert.Equal(4, uniqueCount);

            int[] expectedUniqueValues = { 1, 2, 3, 4 };

            Assert.Equal(
                expectedUniqueValues,
                arr.Take(uniqueCount).ToArray());
        }

        [Fact]
        public void MaxProfit_BruteForce()
        {
            //arrange
            int[] arr = { 7, 1, 5, 3, 6, 4 };

            //act
            int result = MaxProfit_BestTimeToBuyAndSell.MaxProfit_BruteForce(arr);

            //assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void MaxProfit_Optimized()
        {
            //arrange
            int[] arr = { 7, 1, 5, 3, 6, 4 };

            //act
            int result = MaxProfit_BestTimeToBuyAndSell.MaxProfit_Optimized(arr);

            //assert
            Assert.Equal(5, result);
        }



        [Fact]
        public void MaximumSumSubarrayOfSize_3_Should_Run_Successfully()
        {
            //arrange
            int[] arr = { 2, 1, 5, 1, 3, 2 };
            int k = 3;

            //act
            int maxSum = MaximumSumSubarrayOfSizeK.MaxSum_For_WindowSize_3(arr, k);
            //assert

            Assert.Equal(9, maxSum);
        }

        [Fact]
        public void MaximumSumSubarrayOfSizeK_Should_Run_Successfully()
        {
            //arrange
            int[] arr = { 2, 1, 5, 1, 3, 2 };
            int k = 3;

            //act
            //int maxSum = MaximumSumSubarrayOfSizeK.MaxSum_For_WindowSize_k(arr, k);
            int maxSum = MaximumSumSubarrayOfSizeK.MaxSum_For_WindowSize_k_Optimized(arr, k);

            //assert

            Assert.Equal(9, maxSum);
        }


        [Fact]
        public void ProductOfArray_Should_Run_Successfully()
        {
            //arrange

            int[] inputArray = { 1, 2, 3, 4 };
            int[] outputArray = { 24, 12, 8, 6 };

            //act
            //int[] resultArray = ProductOfArrayExceptSelf.Product(inputArray);
            int[] resultArray = ProductOfArrayExceptSelf.Product_By_BruteForce(inputArray);

            //assert

            Assert.Equal(outputArray, resultArray);
        }



        [Fact]
        public void ProductOfArray_Optimized_Should_Run_Successfully()
        {
            //arrange

            int[] inputArray = { 1, 2, 3, 4 };
            int[] outputArray = { 24, 12, 8, 6 };

            //act
            //int[] resultArray = ProductOfArrayExceptSelf.Product(inputArray);
            int[] resultArray = ProductOfArrayExceptSelf.Product_Optimized(inputArray);

            //assert

            Assert.Equal(outputArray, resultArray);
        }


        [Fact]
        public void FindProduct_Except_itself_Optimized_Cleaned_Should_Run_Successfully()
        {
            //arrange

            int[] inputArray = { 1, 2, 3, 4 };
            int[] outputArray = { 24, 12, 8, 6 };

            //act
            //int[] resultArray = ProductOfArrayExceptSelf.Product(inputArray);
            int[] resultArray = ProductOfArrayExceptSelf.FindProduct_Except_itself_Optimized_Cleaned(inputArray);

            //assert

            Assert.Equal(outputArray, resultArray);
        }

        [Fact]
        public void Kadane_ContigousSubArrayOfLargestSum_BruteForce_Should_Run_Successfully()
        {
            //arrange

            int[] inputArray = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int expectedSum = 6;
            int[] expectedSubArray = { 4, -1, 2, 1 };
            //int[] outputArray = { 24, 12, 8, 6 };

            //act
            //int[] resultArray = ProductOfArrayExceptSelf.Product(inputArray);
            KadaneAlgorithmResponse response = KadaneAlgorithm_FindContigousSubArrayOfLargestSum.ContigousSubArrayOfLargestSum_BruteForce(inputArray);

            //assert

            Assert.Equal(expectedSum, response.MaxSum);
            Assert.Equal(expectedSubArray, response.SubArray);
        }




        [Fact]
        public void Kadane_ContigousSubArrayOfLargestSum_Optimized_Should_Run_Successfully()
        {
            //arrange

            int[] inputArray = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int expectedSum = 6;
            int[] expectedSubArray = { 4, -1, 2, 1 };
            //int[] outputArray = { 24, 12, 8, 6 };

            //act
            //int[] resultArray = ProductOfArrayExceptSelf.Product(inputArray);
            //KadaneAlgorithmResponse response = KadaneAlgorithm_FindContigousSubArrayOfLargestSum.ContigousSubArrayOfLargestSum_BruteForce(inputArray);
            int result = KadaneAlgorithm_FindContigousSubArrayOfLargestSum.MaxSum_By_Kadane_Algorithm_Optimized(inputArray);



            //assert
            Assert.Equal(expectedSum, result);

        }


        [Fact]
        public void ContigousSubArrayWithLargestSum_Optimized_Should_Run_Successfully()
        {
            //arrange

            int[] inputArray = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int expectedSum = 6;
            int[] expectedSubArray = { 4, -1, 2, 1 };
            //int[] outputArray = { 24, 12, 8, 6 };

            //act
            //int[] resultArray = ProductOfArrayExceptSelf.Product(inputArray);
            KadaneAlgorithmResponse response = KadaneAlgorithm_FindContigousSubArrayOfLargestSum.ContigousSubArrayWithLargestSum_Optimized(inputArray);

            //assert

            Assert.Equal(expectedSum, response.MaxSum);
            Assert.Equal(expectedSubArray, response.SubArray);
        }


        public static IEnumerable<object[]> KadaneTestData =>
                                            new List<object[]>
                                            {
                                                // Classic example
                                                //new object[]
                                                //{
                                                //    new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },
                                                //    6,
                                                //    new int[] { 4, -1, 2, 1 }
                                                //},

                                                //// All positive numbers
                                                //new object[]
                                                //{
                                                //    new int[] { 1, 2, 3, 4 },
                                                //    10,
                                                //    new int[] { 1, 2, 3, 4 }
                                                //},

                                                // All negative numbers
                                                new object[]
                                                {
                                                    new int[] { -5, -2, -8 },
                                                    -2,
                                                    new int[] { -2 }
                                                },

                                                // Single element
                                                //new object[]
                                                //{
                                                //    new int[] { 5 },
                                                //    5,
                                                //    new int[] { 5 }
                                                //},

                                                //// Restart subarray scenario
                                                //new object[]
                                                //{
                                                //    new int[] { 1, -10, 5, 6 },
                                                //    11,
                                                //    new int[] { 5, 6 }
                                                //}
                                            };

        [Theory]
        [MemberData(nameof(KadaneTestData))]
        public void GetSubArrayWithLargestSum_Should_Return_Correct_Result(int[] inputArray,int expectedMaxSum,int[] expectedSubArray)
        {
            // Act
            KadaneAlgorithmResponse result =
                KadaneAlgorithm_FindContigousSubArrayOfLargestSum
                    .GetSubArrayWithLargestSum(inputArray);

            // Assert
            Assert.Equal(expectedMaxSum, result.MaxSum);
            Assert.Equal(expectedSubArray, result.SubArray);
        }

        [Fact]
        public void MergeArray_BruteForce_Should_Run_Successfully()
        {
            //arrange
            int[] firstArray = { 1, 3, 4 };
            int[] secondArray = { 1, 2, 5, 6, 7, 8 };
            int[] expectedArray = { 1, 1, 2, 3, 4, 5, 6, 7, 8 };



            //act
            int[] resultArray = MergeTwoSortedArray.MergeSortArray_BruteForce(firstArray, secondArray);
            //assert
            Assert.Equal(expectedArray, resultArray);
        }
        [Fact]
        public void MergeSortArray_Optimized_Should_Run_Successfully()
        {
            //arrange
            int[] firstArray = { 1, 3, 4 };
            int[] secondArray = { 1, 2, 5, 6, 7, 8 };
            int[] expectedArray = { 1, 1, 2, 3, 4, 5, 6, 7, 8 };



            //act
            int[] resultArray = MergeTwoSortedArray.MergeSortArray_Optimized(firstArray, secondArray);
            //assert
            Assert.Equal(expectedArray, resultArray);
        }

        [Fact]
        public void SortedSquare_BruteForce_Should_Run_Successfully()
        {
            //arrange
            int[] inputArray = {-4,-1,0,3,10};
            int[] expectedArray = { 0, 1, 9, 16, 100 };

            //act
            int[] resultArray = SortedSquaresOfNumbersInArray.SortedSquares_BruteForce(inputArray);

            //assert
            Assert.Equal(expectedArray, resultArray);
        }


        [Fact]
        public void SortedSquare_Optimized_Should_Run_Successfully()
        {
            //arrange
            int[] inputArray = { -4, -1, 0, 3, 10 };
            int[] expectedArray = { 0, 1, 9, 16, 100 };

            //act
            int[] resultArray = SortedSquaresOfNumbersInArray.SortedSquares_Optimized(inputArray);

            //assert
            Assert.Equal(expectedArray, resultArray);
        }



        [Theory]
        [InlineData("aabbaa", "aaaabb", true)]
        //[InlineData("silent", "listen", true)]
        //[InlineData("aab", "bab", false)]
        //[InlineData("car", "cats", false)]
        public void ValidAnagram_By_Two_Dictionaries_Should_Run_Successfully(string firstString, string secondString, bool expectedResult)
        {
            //arrange            

            //act
            bool result = ValidAnagram.isValid_By_TwoDictionaries(firstString, secondString);

            //assert
            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("aabbaa", "aaaabb",true)]
        //[InlineData("silent", "listen", true)]
        //[InlineData("aab", "bab", false)]
        //[InlineData("car", "cats", false)]
        public void ValidAnagram_Optimized_Should_Run_Successfully(string firstString,string secondString,bool expectedResult) 
        {
            //arrange            

            //act
            bool result = ValidAnagram.isValid_Optimized(firstString, secondString);

            //assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void FirstNonRepeatingCharacter_Should_Run_Successfully() 
        {
            //arrange
            string str = "leetcode";
            int expectedIndex = 0;
            
            //act
            int result = FirstNonRepeatingCharacter.FindIndexOfNonRepeatingCharacter(str);

            //assert
            Assert.Equal(expectedIndex, result);
        }
    }
}
