using DSA.Arrays._7DaysProblemSolvingExercise;
using System;
using System.Collections.Generic;
using System.Text;

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
            int[] arr = { 1, 2, 3, 4, 5,5 };
            int[] arr2 = { 1, 2, 3, 4, 5 };

            //act
            //bool result = DuplicateElementInArray.Duplicate(arr);
            bool result = DuplicateElementInArray.Duplicate(arr2);

            //assert
            //Assert.Equal(true, result);
            Assert.Equal(false, result);
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4,5 },false) ]
        [InlineData(new int[] {1,2,3,3,4,56 },true)]
        [InlineData(new int[] {2,3,4,5,5,6,0},true)]
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
            Assert.Equal(expectedResult,result);
        }



    }
}
