namespace Store.Entities
{
    class OrderItem
    {
        //Properties
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public double subTotal ()
        {
            return Price * Quantity;
        }
    }
}
