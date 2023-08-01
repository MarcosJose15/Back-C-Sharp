using SistemaPedidos.Entities.Enums;
using SistemaPedidos.Entities;
using System.Text;
using System.Globalization;

namespace SistemaPedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Product.Name}, ${Price}, Quantity: {Quantity}, Subtotal:{SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
