using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexação
            string nome = "Guilherme";
            char letra = nome[4];
            Console.WriteLine(letra);

            //Concatenar string
            string sobrenome = " Silva Sauro";
            string nomecompleto = nome + sobrenome;
            Console.WriteLine(nomecompleto);

            string nomecompleto2 = String.Concat(nome, sobrenome);
            Console.WriteLine(nomecompleto2);

            //Substituição de strings
            string endereco = "Rua das Rosas Verdes";
            endereco = endereco.Replace("Verdes", "Vermelhas");
            Console.WriteLine(endereco);

            //Remoção de strings
            string endereco2 = "Rua das Rosas Verdes";
            endereco2 = endereco2.Replace(" Verdes", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Rua das Rosas Verdes";
            endereco3 = endereco3.Remove(0, 4);
            Console.WriteLine(endereco3);

            //Capitalização de strings
            string nome2 = "Joao da Silva";
            nome2 = nome2.ToUpper();
            Console.WriteLine(nome2);
            nome2 = nome2.ToLower();
            Console.WriteLine(nome2);

            //Contém
            string nome3 = "Joao da Silva";
            bool contem = nome3.Contains("Joao");
            Console.WriteLine(contem);
            contem = nome3.Contains("Marcos");
            Console.WriteLine(contem);

            //Localização de textos
            string nome4 = "Joao da Silva";
            int indice = nome4.IndexOf("da");
            Console.WriteLine(indice);

            //Divisão de strings
            string nome5 = "Joao da Silva";
            string[] divisores = {"da"};
            string[] resultadoDaDivisao = nome5.Split(divisores, StringSplitOptions.None);
            foreach(string texto in resultadoDaDivisao)
            {
                Console.WriteLine(texto);
            }

            //Número de caracteres
            string nome6 = "Joao da Silva";
            int numerocaracteres = nome6.Length;
            Console.WriteLine(numerocaracteres);

            //Substring
            string nome7 = "Joao da Silva";
            string ultimoNome = nome7.Substring(8, 5);
            Console.WriteLine(ultimoNome);

            //Formatação composta
            string nome8 = "Joao {0} {1}";
            Console.WriteLine(nome8, "da Silva", "Sauro");
            string nomeCompleto6 = String.Format(nome8, "da Silva", "Sauro");
            Console.WriteLine(nomeCompleto6);

            Console.ReadKey();
        }
    }
}
