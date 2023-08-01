using SistemaPedidos.Entities.Enums;
using SistemaPedidos.Entities;

namespace SistemaPedidos.Entities
{
    class Product
    {
        public string Name {  get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
