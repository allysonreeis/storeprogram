using System;

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

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");//Interpolation
                Console.WriteLine("Product name: ");
                Console.WriteLine("Product price: ");
                Console.WriteLine("Quantity: ");
            }
        }
    }
}
