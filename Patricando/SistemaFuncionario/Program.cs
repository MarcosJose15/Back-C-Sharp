using System;
using System.Globalization;

namespace SistemaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p = new Funcionario();

            Console.WriteLine("Entre com os dados do Funcionario");
            Console.WriteLine();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Salario bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.CalcularSalarioLiquido();

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + p);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            p.porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.AumentarSalario(p.porcentagem);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
        }
    }
}