using SistemaPedidos.Entities.Enums;
using SistemaPedidos.Entities;
using System;
using System.Text;
using System.Globalization;


namespace SistemaPedidos.Entities
{
    class Order
    {
        public DateTime Moment {  get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order() { }

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
            
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double valor = 0.0;

            foreach (OrderItem item in Items)
            {
                valor += item.SubTotal();
            }
            return valor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine($"Client {Client.Name} ({Client.BirthDate}) - {Client.Email}");
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items) 
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}
