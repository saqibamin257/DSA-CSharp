using DSA.LinqEFCore.Data;
using DSA.LinqEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Queries
{
    public class CustomerQueries
    {
        //GetAll()
        //GetByCity()
        //GetOrderedByName()
        //GetCustomerByEmail()
        //GetProjection()
        //CountCustomers()
        
        private readonly AppDBContext context;
        public CustomerQueries(AppDBContext context) 
        {
            this.context = context;
        }

        public List<Customer> GetAll() 
        {
            //get all customers
            var customers = context.Customers
                            .AsNoTracking()             
                            .ToList();

            return customers;
        }
        public List<Customer> GetByCity(string city) 
        {
            //get customers by city
            var customers = context.Customers
                           .AsNoTracking()
                           .Where(x => x.City == city)
                           .ToList();

            return customers;            
        }
        public Customer GetCustomerByEmail(string email) 
        {
            var customer = context.Customers
                          .Where(x => x.Email == email)
                          .FirstOrDefault();
            
            return customer;
        }

        public List<CustomerBasicInformation> GetCustomerInfoByProjection()
        {
            var customers = context.Customers
                           .Select(x => new CustomerBasicInformation
                           {
                               Name = $"{x.FirstName} {x.FirstName}",
                               Email = x.Email,
                               City = x.City
                           })
                           .ToList();        
            return customers;
        }

        public class CustomerBasicInformation() 
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
        }

        public int CountCustomers() 
        {
            int total = context.Customers.Count();
            return total;
        }
    }
}
