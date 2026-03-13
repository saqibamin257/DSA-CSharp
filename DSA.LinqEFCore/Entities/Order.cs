using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = "Pending";

        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
