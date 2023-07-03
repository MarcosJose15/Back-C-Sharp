using System;
using System.Globalization;
using System.Collections.Generic;

namespace CadastroFuncionario
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionarios irá cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> ListaFuncionarios = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("\n\nFuncionario #" + i  + ":");
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ListaFuncionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("\n\n");

            Console.Write("Informe um ID para aumentar o salario: ");
            int Id = int.Parse(Console.ReadLine());


            Funcionario funcionario = ListaFuncionarios.Find(x => x.Id == Id);

            if (funcionario != null)
            {
                Console.Write("\nInforme a porcentagem de aumento: ");
                double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(p);
            }
            else
            {
                Console.WriteLine("\nNÃO EXISTI FUNCIONARIO COM ESTE ID");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in ListaFuncionarios)
            {
                Console.WriteLine(obj);
            }

        }
    }
}