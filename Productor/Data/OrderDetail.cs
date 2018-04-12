﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productor.Data
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public string OrderNo { get; set; }
        public string Sku { get; set; }
        public string SkuName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
    }
}