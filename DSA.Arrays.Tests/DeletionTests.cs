using DSA.Arrays.Deletion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Tests
{
    public static class DeletionTests
    {
        [Fact]
        public static void DeleteFromBeginning_Should_Run_Without_Error() 
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40 };
            //Act

            int[] resultArray = DeleteFromBeginning.Delete(arr);

            //Assert
            Assert.Equal(resultArray.Length, 3);
        }

        [Fact]
        public static void DeleteAtGivenPosition_Should_Run_Without_Error()
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40 };
            int position = 2;
            //Act

            int[] resultArray = DeleteAtGivenPosition.Delete(arr,position);

            //Assert
            Assert.Equal(resultArray.Length, arr.Length-1);
            Assert.Equal(resultArray[1], arr[2]);
        }

        [Fact]
        public static void DeleteFirstOccurenceOfGivenElement_Should_Run_Without_Error()
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40,20 };
            int element = 20;
            //Act

            int[] resultArray = DeleteFirstOccuranceOfGivenElement.Delete(arr, element);

            //Assert
            Assert.Equal(resultArray.Length, arr.Length - 1);
            Assert.NotEqual(resultArray[1], element);
        }

        [Fact]
        public static void DeleteFirstOccurenceOfGivenElement_Should_Return_OriginalArray_WhenElement_Is_Not_In_Array()
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40, 20 };
            int element = 200;
            //Act

            int[] resultArray = DeleteFirstOccuranceOfGivenElement.Delete(arr, element);

            //Assert
            Assert.Equal(arr, resultArray);
            Assert.Equal(resultArray.Length, arr.Length);
        }
    }
}
