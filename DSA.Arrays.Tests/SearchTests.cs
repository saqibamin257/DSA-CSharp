using System;
using System.Collections.Generic;
using System.Text;
using DSA.Arrays.Searching;

namespace DSA.Arrays.Tests
{
    public class SearchTests
    {
        [Fact]
        public void SearchElement_Should_Return_Correct_Index() 
        {
            //Arranage
             int[] arr = { 1, 2, 3, 4, 5 };
            int target = 2;
            int expectedIndex = 1;

            //Act
            int actualIndex = SearchElement.Search(arr, target);

            //Assert
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void SearchElement_Should_Return_Minus_One_Index()
        {
            //Arranage
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 20;
            int expectedIndex = -1;

            //Act
            int actualIndex = SearchElement.Search(arr, target);

            //Assert
            Assert.Equal(expectedIndex, actualIndex);
        }
        [Fact]
        public static void BinarySearch_Iterative_Should_Run_Without_Error()
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int element = 20;

            //Act
            int result = BinarySearch_Iterative.BinarySearch(arr, element);

            //Assert
            Assert.Equal(1, result);

        }

        [Fact]
        public static void BinarySearch_Recursive_Should_Run_Without_Error()
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int element = 20;
            int low = 0;
            int high = arr.Length - 1;

            //Act
            int result = BinarySearch_Recursive.BinarySearch(arr,low,high, element);

            //Assert
            Assert.Equal(1, result);

        }


    }
}
