using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioPro2.Entities;
using System.Diagnostics.CodeAnalysis;

namespace ExercicioPro2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char p = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double AnualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(p == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listPerson.Add(new Individual (name, AnualIncome, health)); 
                }

                if (p == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    listPerson.Add(new Company(name, AnualIncome, employees));
                }
            }

            double sum = 0;

            Console.WriteLine("\nTAXES PAID:");
            foreach (Person person in listPerson)
            {
                Console.WriteLine(person.Name + ": $ " + person.Calc().ToString("F2", CultureInfo.InvariantCulture));
                sum += person.Calc();
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}