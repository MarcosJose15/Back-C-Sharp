using System;
using System.Globalization;
using ExercicioExcecoes.Entities;
using ExercicioExcecoes.Entities.Exceptions;

namespace ExercicioExcecoes
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, limit);

                Console.Write("\nEnter amount for withdraw: ");
                double valueToWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(valueToWithdraw);
                Console.WriteLine("New balance " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }

            //Catch bem generico para pegar qualquer error que surgir
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}