using System;
using Store.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Store.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order (DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + ", Birth Date: " + Client.Date.ToShortDateString() );
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name + ", $" + item.Product.Price + " Quantity: " + item.Quantity + ", Subtotal: $" + item.subTotal());
            }
            sb.AppendLine("Total price: $" + Total());
            return sb.ToString();
        }
    }
}
