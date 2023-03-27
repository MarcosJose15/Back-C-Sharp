using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastramento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Sistema de Cadastro--");
            Console.WriteLine("\n\n");

            Console.WriteLine("Informe o seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade: ");
            sbyte idade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Informe sua data de nascimento: ");
            String dataNascimento = Console.ReadLine();


            Console.WriteLine("\nNome = " + nome + "\nIdade = " + idade + "\nData de nascimento = " + dataNascimento);
            Console.ReadLine();
        }
    }
}
