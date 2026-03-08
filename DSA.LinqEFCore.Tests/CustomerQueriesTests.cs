using DSA.LinqEFCore.Entities;
using FluentAssertions;
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using DSA.LinqEFCore.Queries;

namespace DSA.LinqEFCore.Tests
{
    public class CustomerQueriesTests
    {
        [Fact]
        public void Get_All_Should_Return_All_Customers() 
        {
            //Arrange
            var context = TestDbContextFactory.Create();

            context.Customers.AddRange(
                new Customer { FirstName = "Ali", LastName = "Muhammad", City = "Karachi", Email = "ali@test.com", CreatedDate=DateTime.UtcNow },
                new Customer { FirstName = "Sara", LastName = "Muhammad", City = "Lahore", Email = "sara@test.com", CreatedDate = DateTime.UtcNow }
            );
            context.SaveChanges();

            var queries = new CustomerQueries(context);

            //Act
            var result = queries.GetAll();


            //Assert
            result.Should().HaveCount(2);

        }
    }
}
