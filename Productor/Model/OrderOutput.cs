﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productor.Model
{
    public class OrderOutput
    {
        public OrderOutput()
        {
            Details = new List<OrderDetailOutput>();
        }

        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateTime { get; set; }
        public string AppUser { get; set; }

        public IList<OrderDetailOutput> Details { get; set; }
    }

    public class OrderDetailOutput
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public string Sku { get; set; }
        public string SkuName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
