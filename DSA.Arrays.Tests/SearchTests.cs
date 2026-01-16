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
    }
}
