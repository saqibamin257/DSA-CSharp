using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSA.LinqEFCore.Entities
{
    public class Customer
    {
        public int Id { get; set; } //primary key        
        public string FirstName { get; set; }        
        public string LastName { get; set; }        
        public string? Email { get; set; }        
        public string City { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
