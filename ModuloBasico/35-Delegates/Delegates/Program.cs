using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate double MeuDelegateOperacoes(double a, double b);
        public static double Soma (double a, double b)
        {
            double resultadoSoma = a + b;
            Console.WriteLine("A soma de " + a + " mais " + b + " é: " + resultadoSoma);
            return resultadoSoma;
        }
        public static double Multiplicacao(double a, double b)
        {
            double resultadoMultiplicacao = a * b;
            Console.WriteLine("A multiplicacao de " + a + " e " + b + " é: " + resultadoMultiplicacao);
            return resultadoMultiplicacao;
        }
        public static double Divisao(double a, double b)
        {
            double resultadoDivisao = a / b;
            Console.WriteLine("A divisao de " + a + " por " + b + " é: " + resultadoDivisao);
            return resultadoDivisao;
        }
        public static void ExecutaOperacao(MeuDelegateOperacoes minhasOperacoes)
        {
            Console.WriteLine("Executando o método passado como parâmetro de entrada...");
            minhasOperacoes(50, 20);
        }
        static void Main(string[] args)
        {
            MeuDelegateOperacoes minhasOperacoes;
            minhasOperacoes = Soma;
            double resultadoDelegate = minhasOperacoes(10, 20);
            Console.WriteLine("O resultado do delegate é: " + resultadoDelegate);

            minhasOperacoes += Multiplicacao;
            minhasOperacoes += Divisao;
            Console.WriteLine("--------------------------");
            resultadoDelegate = minhasOperacoes(30, 5);
            Console.WriteLine("O resultado do delegate é: " + resultadoDelegate);
            Console.WriteLine("--------------------------");
            ExecutaOperacao(Multiplicacao);

            Console.ReadKey();
        }
    }
}
