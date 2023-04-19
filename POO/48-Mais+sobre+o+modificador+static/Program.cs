using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mais_sobre_o_modificador_static
{
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public static void ImprimeNome(Pessoa pPessoa)
        {
            Console.WriteLine("O nome é: " + pPessoa.nome);
        }
        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }

    public static class Calculadora
    {
        public static double PI = 3.1415;
        public static double CalculaAreaCircunferencia(double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa.ImprimeNome(pessoa1);
        }
    }
}
