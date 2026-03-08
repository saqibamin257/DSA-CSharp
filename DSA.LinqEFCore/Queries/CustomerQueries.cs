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
    }
}
