﻿namespace Store.Entities
{
    class OrderItem
    {
        //Properties
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem (int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal ()
        {
            return Price * Quantity;
        }
    }
}
