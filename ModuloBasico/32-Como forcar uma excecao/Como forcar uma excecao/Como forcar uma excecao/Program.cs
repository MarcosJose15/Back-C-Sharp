using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_forcar_uma_excecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva um número positivo:");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)
                    //É assim que a gente força uma exceção
                    throw new Exception("O número " + numero + " é menor que zero!");
                else
                    Console.WriteLine("Você digitou o número " + numero);
            }
            catch(Exception e)
            {
                Console.WriteLine("EXCEÇÃO: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
