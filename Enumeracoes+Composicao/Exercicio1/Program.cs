using Exercicio1.Entities.Enums;
using Exercicio1.Entities;
using System.Globalization;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department´s name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);

            Worker worker = new Worker(name, level, baseSalary, dept);


            Console.Write("How many contracts to this worker? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdContracts; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                HourContract contract = new HourContract(date, valuePerHour, hours);
                //Instanciando o trabalhando e chamando o seu metodo de adicionar contrato, passando como parametro o contrato que acabou de ser preenchido.
                worker.AddContract(contract);
            }
            
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Department.Name);
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}