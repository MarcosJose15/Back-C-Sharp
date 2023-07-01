using System;
using System.Globalization;

namespace AlugueisAps
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantas pessoas iram alugar quartos? ");
            int n = int.Parse(Console.ReadLine());

            Quarto[] VetorApartamento = new Quarto[10];

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Aluguel #" + (i + 1));

                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();

                System.Console.Write("Email: ");
                string email = Console.ReadLine();

                System.Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                VetorApartamento[quarto] = new Quarto (nome, email);

                System.Console.WriteLine("");
            }

            System.Console.WriteLine("\nQuartos ocupados:");

            for (int i = 0; i < 10; i++)
            {

                if (VetorApartamento[i] != null)
                {
                    
                    Console.WriteLine(i + ": " + VetorApartamento[i]);
                }
            }

        }
    }
}
