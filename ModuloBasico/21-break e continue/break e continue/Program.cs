using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_e_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Pressione C para continue");
                Console.WriteLine("Pressione B para break");
                string tecla = Console.ReadKey().KeyChar.ToString();
                if(tecla == "c")
                {
                    continue;
                }
                else if(tecla == "b")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
