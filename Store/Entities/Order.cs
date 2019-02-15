using System;
using Store.Entities.Enums;
using System.Collections.Generic;

namespace Store.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus MyProperty { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    }
}
