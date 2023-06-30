using System;
using System.Globalization;
using System.Security.AccessControl;

namespace SistemaDolar
{

    class Program
    {
        static void Main(string[] args)
        {
            double cotacao;
            double dolares;
            double resultado;

            Console.Write("Qual a cotação do dólar? "); 
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = ConversorDeMoeda.converter(dolares, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2"));

            Console.WriteLine();
        }
    }
}