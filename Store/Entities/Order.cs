using System;
using Store.Entities.Enums;
using System.Collections.Generic;

namespace Store.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order (DateTime moment, OrderStatus status, List<OrderItem> items)
        {
            Moment = moment;
            Status = status;
            Items = items;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            Items.Remove(item);
        }
    }
}
