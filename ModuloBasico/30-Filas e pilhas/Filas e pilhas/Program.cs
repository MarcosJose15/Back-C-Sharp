using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas_e_pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> FilaDeNomes = new Queue<string>();
            //Adicionando elementos
            FilaDeNomes.Enqueue("Guilherme");
            FilaDeNomes.Enqueue("Maria");
            FilaDeNomes.Enqueue("João");
            FilaDeNomes.Enqueue("Vagner");

            //Removendo elementos
            string nomeremovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeremovido);
            nomeremovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeremovido);

            //Espiando elementos
            Console.WriteLine("---------------------");
            string nomeEspiado = FilaDeNomes.Peek();
            Console.WriteLine(nomeEspiado);

            //Stack
            Console.WriteLine("---------------------");
            Stack<string> PilhaDeNomes = new Stack<string>();

            //Adicionando elementos
            PilhaDeNomes.Push("Mariana");
            PilhaDeNomes.Push("Joaquina");
            PilhaDeNomes.Push("José");
            PilhaDeNomes.Push("alana");

            //removendo elementos
            string nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            Console.WriteLine("---------------------");

            //Espiar elementos
            string Nomeespiado2 = PilhaDeNomes.Peek();
            Console.WriteLine(Nomeespiado2);

            //Possuem os mesmos métodos das listas
            //Count
            //Clear
            //Concat
            //Contains
            //...

            Console.ReadKey();
        }
    }
}
