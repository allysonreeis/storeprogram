using System;
using Store.Entities.Enums;
using System.Collections.Generic;

namespace Store.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public Order (DateTime moment, OrderStatus status, OrderItem items)
        {
            Moment = moment;
            Status = status;
            Items.Add(items);
        }

        public Order(DateTime moment, OrderStatus status, Client client) : this(moment, status)
        {
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total ()
        {
            double totalValue = 0;
            foreach (var value in Items)
            {
                 totalValue += (value.Price * value.Quantity);
            }
            return totalValue;
        }
    }
}
