using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSA.LinqEFCore.Entities
{
    public class Customer
    {
        public int Id { get; set; } //primary key        
        public string FirstName { get; set; }= null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; }        
        public string City { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
