using System;
using Store.Entities;
using Store.Entities.Enums;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            string dateConvert = Console.ReadLine();
            DateTime date = DateTime.Parse(dateConvert);
            
            Client client = new Client(name, email, date);
            OrderStatus status = OrderStatus.PROCESSING;

            Console.WriteLine("Enter order data:");
            Console.WriteLine($"Status: {status}");
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            OrderItem orderItem;
            Order order = new Order(DateTime.Now, status, client);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");//Interpolation
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Client: " + order.Client.Name);
            Console.WriteLine("Order items: ");
            foreach (OrderItem value in order.Items)
            {
                Console.WriteLine(value.Product.Name + ", " + "$" + value.Product.Price + " Quantity: " + value.Quantity + ", Subtotal: $" + value.subTotal());
            }
            Console.WriteLine("Total price: " + order.Total());

        }
    }
}
