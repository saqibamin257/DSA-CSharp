using DSA.LinqEFCore.Data;
using DSA.LinqEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Seed
{
    public class DataSeeder
    {
        public static void SeedCustomer(AppDBContext context) 
        {
            if (context.Customers.Any())
                return;

            var customers = new List<Customer>
            {
                new Customer { FirstName="Ali", LastName="Khan", Email="ali@gmail.com", City="Karachi" },
                new Customer { FirstName="Sara", LastName="Ahmed", Email="sara@gmail.com", City="Lahore" },
                new Customer { FirstName="John", LastName="Doe", Email="john@gmail.com", City="Islamabad" }
            };

            context.AddRange(customers);
            context.SaveChanges();
        }
    }
}
