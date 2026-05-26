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
                               Name = $"{x.FirstName} {x.LastName}",
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


        public IEnumerable<CustomerBasicInformation> GetCustomerByProjection()
        {
            var result = context.Customers
                        .Select(x => new CustomerBasicInformation
                        {
                            Name = $"{x.FirstName} {x.FirstName}",
                            Email = x.Email,
                            City = x.City
                        })
                        .ToList();
            return result;
        }

        public int CountCustomers()
        {
            int total = context.Customers.Count();
            return total;
        }


        //EF: Any  SQL:Exists
        public bool IsCustomerOfCityExists(string city)
        {
            return context.Customers
               .Any(x => x.City == city);
        }

        //EF:Contains   SQL: IN
        public IEnumerable<CustomerBasicInformation> GetCustomerByCityList(string[] cities)
        {
            var customer = context.Customers
                           .Where(c => cities.Contains(c.City))
                           .Select(x => new CustomerBasicInformation
                           {
                               Name = x.FirstName + " " + x.LastName,
                               Email = x.Email,
                               City = x.City
                           })
                           .ToList();
            return customer;
        }



        //---------------------------Joins, Relations ------------------------------//



        public CustomerOrderDetailDto GetCustomerOrderData(string email) 
        {
            var cust = context.Customers
                      .Where(c => c.Email == email)
                      .ToList();


            var customer = context.Customers
                          .Where(c => c.Email == email)
                          .Select(c => new CustomerOrderDetailDto
                          {
                              CustomerName = c.FirstName + " " + c.LastName,
                              Email = c.Email,
                              Orders = c.Orders.Select(o => new OrderDto
                              {
                                  OrderId = o.Id,
                                  Status = o.Status,
                                  TotalAmount = o.TotalAmount
                              }).ToList()
                          })
                          .FirstOrDefault();
            return customer;

        }

        public class CustomerOrderDetailDto
        {
            public string CustomerName { get; set; }
            public string Email { get; set; }
            public List<OrderDto> Orders { get; set; }
        }

        public class OrderDto
        {
            public int OrderId { get; set; }
            public string Status { get; set; }
            public decimal TotalAmount { get; set; }
        }




    }
}
