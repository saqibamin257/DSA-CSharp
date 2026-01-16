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
    }
}
