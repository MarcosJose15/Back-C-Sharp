using SistemaPedidos.Entities.Enums;
using SistemaPedidos.Entities;
using System.Globalization;

namespace SistemaPedidos
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
            DateTime moment = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, moment);

            Console.WriteLine("");
            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment,Processing, Shipped, Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Order order = new Order(client, DateTime.Now, status);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"\nEnter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(product, quantity, price);
                order.AddItem(item);
            }
            
            Console.WriteLine(order);

        }
    }

}