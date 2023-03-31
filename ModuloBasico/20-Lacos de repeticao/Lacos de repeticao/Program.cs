using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_de_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laço/Loop for
            for( int i = 0/*Inicialização da nossa variável*/; i < 10/*Condição*/; i++/*Alteração da variável*/)
            {
                Console.WriteLine(i);
            }

            //Laço while
            int j = 0;
            while(j<100/*Condição*/)
            {
                Console.WriteLine("Bom dia!");
                j += 10;
            }

            //laço do...while
            int k = 0;
            do
            {
                Console.WriteLine("Boa tarde!");
                k += 100;
            } while (k<1000/*Condição*/);

            //Laço foreach
            string[] nomes = { "Guilherme", "João", "Pedro", "Maria", "Paula" };
            foreach(string nome in nomes/*Funcionamento do nosso array*/)
            {
                Console.WriteLine(nome);
            }


            Console.ReadKey();

        }
    }
}
