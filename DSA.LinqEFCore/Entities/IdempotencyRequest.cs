using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Entities
{
    public class IdempotencyRequest
    {
        public int Id { get; set; }

        public string IdempotencyKey { get; set; } = null!;

        public string RequestPath { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public string? Response { get; set; }
    }
}
