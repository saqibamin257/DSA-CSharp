using DSA.LinqEFCore.Entities;
using FluentAssertions;
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using DSA.LinqEFCore.Queries;
using DSA.LinqEFCore.Seed;

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

        [Fact]
        public void Get_GetByCity_Should_Return_One_Result()
        {
            //Arrange
            var context = TestDbContextFactory.Create();

            context.Customers.AddRange(
                new Customer { FirstName = "Ali", LastName = "Muhammad", City = "Karachi", Email = "ali@test.com", CreatedDate = DateTime.UtcNow },
                new Customer { FirstName = "Sara", LastName = "Muhammad", City = "Lahore", Email = "sara@test.com", CreatedDate = DateTime.UtcNow }
            );
            context.SaveChanges();

            var queries = new CustomerQueries(context);

            //Act
            string city = "Karachi";
            var result = queries.GetByCity(city);


            //Assert
            Assert.Equal(result.First().City, city);
            result.Should().HaveCount(1);
        }


        [Fact]
        public void Get_GetCustomerByEmail_Should_Return_One_Result()
        {
            //Arrange
            var context = TestDbContextFactory.Create();

            context.Customers.AddRange(
                new Customer { FirstName = "Ali", LastName = "Muhammad", City = "Karachi", Email = "ali@test.com", CreatedDate = DateTime.UtcNow },
                new Customer { FirstName = "Sara", LastName = "Muhammad", City = "Lahore", Email = "sara@test.com", CreatedDate = DateTime.UtcNow }
            );
            context.SaveChanges();

            var queries = new CustomerQueries(context);

            //Act
            string email = "ali@test.com";
            var result = queries.GetCustomerByEmail(email);


            //Assert
            Assert.Equal(result.Email, email);            
        }


        [Fact]
        public void Get_GetCustomerOrderData_Should_Run_Without_Error()
        {
            //Arrange
            var context = TestDbContextFactory.Create();
            DataSeeder.SeedAll(context); //seed data for test in memory, it will be created only for this test as soon as the test completed this database and data will be removed from memory.

            var queries = new CustomerQueries(context);

            
            
            //Act
            string email = "ali@gmail.com";
            var customer = context.Customers.ToList();
            var result = queries.GetCustomerOrderData(email);


            //Assert
            // Assert
            Assert.NotNull(result);

            Assert.Equal("Ali Khan", result.CustomerName);
            Assert.Equal("ali@gmail.com", result.Email);

            Assert.NotNull(result.Orders);
            Assert.Equal(2, result.Orders.Count);   // Ali has 2 orders in seed

            Assert.Contains(result.Orders, o => o.Status == "Completed");
            Assert.Contains(result.Orders, o => o.Status == "Pending");
        }

    }
}
