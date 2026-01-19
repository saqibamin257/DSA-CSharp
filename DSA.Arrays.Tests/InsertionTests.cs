using DSA.Arrays.Insertion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Tests
{
    public static class InsertionTests
    {
        [Fact]
        public static void InsertAtBeginning_Should_Run_Without_Error() 
        {
            //Arrange
            int[] arr = { 2, 3, 4, 5 };
            int valueToInsert = 1;

            //Act
            int[] firstResultArray = InsertAtBeginning.InsertAtZero_ByCreatingNewArray(arr, valueToInsert);
            int[] secondResultArray = InsertAtBeginning.InsertAtZero_ByUsingList(arr, valueToInsert);

            //Assert
            Assert.Equal(firstResultArray[0], valueToInsert);
            Assert.Equal(secondResultArray[0], valueToInsert);
        }
        [Fact]
        public static void InsertAtGivePosition_Should_Return_Correct_Array() 
        {
            //Arrange
            int[] arr = { 10, 20, 30, 40 };
            int position = 2;
            int element = 50;
            
            //Act
            //output array= {10,50,20,30,40};
            int[] resultArray = InsertAtGivenPosition.Insert(arr, position, element);

            Assert.Equal(resultArray[position - 1], element);
        }

        [Fact]
        public static void InsertAtEnd_Should_Provide_Correct_Result() 
        {
            //Arrange
            int[] arr = {10,20,30,40 };
            int element = 50;

            //Act
            int[] resultArray = InsertAtEnd.Insert(arr, element);

            //Assert
            Assert.Equal(resultArray[resultArray.Length - 1], element);

        }


    }
}
