using System;
using ExercicioProposto.Entities;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char p = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (p == 'c')
                {
                    list.Add(new Product(name, price));
                }

                if (p == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuFactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manuFactureDate));
                }

                if (p == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}