using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string SKU { get; set; } = null!;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public bool IsActive { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public byte[] RowVersion { get; set; } = null!;
    }
}
