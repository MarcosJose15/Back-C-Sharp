using System;
using Exercicio1.Entities;
using System.Security.Principal;
using System.Globalization;
using System.Text;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char t = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                char t1 = 'y';
                char t2 = 'Y';
                char e1 = 'n';
                char e2 = 'N';

                if (t == t1 || t == t2)
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

                if (t == e1 || t == e2)
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee empt in list)
            {
                Console.WriteLine(empt.Name + " - $" + empt.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}