using DSA.LinqEFCore.Data;
using DSA.LinqEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Seed
{
    public static class DataSeeder
    {
        public static void SeedAll(AppDBContext context) 
        {
            //context.Database.Migrate();
            SeedCustomer(context);
            SeedCategories(context);
            SeedProducts(context);   // must come before Orders
            SeedOrders(context);
        }
        public static void SeedCustomer(AppDBContext context)
        {
            try
            {
                if (context.Customers.Any())
                    return;

                var customers = new List<Customer>
            {
                new Customer { FirstName="Ali", LastName="Khan", Email="ali@gmail.com", City="Karachi",IsActive=true },
                new Customer { FirstName="Sara", LastName="Ahmed", Email="sara@gmail.com", City="Lahore",IsActive=true },
                new Customer { FirstName="John", LastName="Doe", Email="john@gmail.com", City="Islamabad",IsActive=false }
            };

                context.AddRange(customers);
                context.SaveChanges();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }            
        }

        public static void SeedCategories(AppDBContext context)
        {
            try
            {
                if (context.Categories.Any())
                    return;

                var categories = new List<Category>
            {
                new Category { Name = "Electronics" },
                new Category { Name = "Books" },
                new Category { Name = "Clothing" }
            };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }

        public static void SeedProducts(AppDBContext context)
        {
            try
            {
                if (context.Products.Any())
                    return;

                var products = new List<Product>
            {
                new Product { Name="Laptop", SKU="ELEC-001", Price=1500, StockQuantity=10, CategoryId=1, IsActive=true },
                new Product { Name="Mobile Phone", SKU="ELEC-002", Price=800, StockQuantity=20, CategoryId=1, IsActive=true },
                new Product { Name="Headphones", SKU="ELEC-003", Price=150, StockQuantity=0, CategoryId=1, IsActive=true }, // zero inventory scenario

                new Product { Name="C# in Depth", SKU="BOOK-001", Price=50, StockQuantity=15, CategoryId=2, IsActive=true },
                new Product { Name="Clean Code", SKU="BOOK-002", Price=45, StockQuantity=30, CategoryId=2, IsActive=true },

                new Product { Name="T-Shirt", SKU="CLTH-001", Price=25, StockQuantity=50, CategoryId=3, IsActive=true },
                new Product { Name="Jeans", SKU="CLTH-002", Price=70, StockQuantity=40, CategoryId=3, IsActive=true }
            };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }

        public static void SeedOrders(AppDBContext context)
        {
            try
            {

                if (context.Orders.Any())
                    return;

                var ali = context.Customers.First(x => x.Email == "ali@gmail.com");
                var sara = context.Customers.First(x => x.Email == "sara@gmail.com");

                var orders = new List<Order>
            {
                new Order
                {
                    
                    CustomerId = ali.Id,
                    OrderDate = DateTime.UtcNow.AddDays(-5),
                    Status = "Completed",
                    TotalAmount = 1650,
                    Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            
                            ProductId = 1,
                            Quantity = 1,
                            UnitPrice = 1500,
                            TotalPrice = 1500
                        },
                        new OrderItem
                        {
                            
                            ProductId = 4,
                            Quantity = 3,
                            UnitPrice = 50,
                            TotalPrice = 150
                        }
                    }
                },

                new Order
                {
                    
                    CustomerId = sara.Id,
                    OrderDate = DateTime.UtcNow.AddDays(-3),
                    Status = "Completed",
                    TotalAmount = 845,
                    Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            
                            ProductId = 2,
                            Quantity = 1,
                            UnitPrice = 800,
                            TotalPrice = 800
                        },
                        new OrderItem
                        {
                            
                            ProductId = 5,
                            Quantity = 1,
                            UnitPrice = 45,
                            TotalPrice = 45
                        }
                      }
                 },

                        new Order
                        {
                            
                            CustomerId = ali.Id,
                            OrderDate = DateTime.UtcNow.AddDays(-1),
                            Status = "Pending",
                            TotalAmount = 95,
                            Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    
                                    ProductId = 6,
                                    Quantity = 1,
                                    UnitPrice = 25,
                                    TotalPrice = 25
                                },
                                new OrderItem
                                {
                                   
                                    ProductId = 5,
                                    Quantity = 1,
                                    UnitPrice = 45,
                                    TotalPrice = 45
                                },
                                new OrderItem
                                {
                                  
                                    ProductId = 4,
                                    Quantity = 1,
                                    UnitPrice = 25,
                                    TotalPrice = 25
                                }
                            }
                        }
                    };
                context.Orders.AddRange(orders);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
