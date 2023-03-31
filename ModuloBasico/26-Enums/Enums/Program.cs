using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        enum NotasDeReal_e
        {
            NotaDe2 = 2,
            NotaDe5 = 5,
            NotaDe10 = 10
        };

        enum NotaDaProva_e
        {
            Nota_1 = -1,
            Nota0,
            Nota1,
            Nota2,
            Nota3,
            Nota4
        }

        static void Main(string[] args)
        {
            NotasDeReal_e minhaNota = NotasDeReal_e.NotaDe10;
            Console.WriteLine(minhaNota + " vale " + Convert.ToUInt32(minhaNota));
            NotaDaProva_e minhaNotaDaProva = NotaDaProva_e.Nota2;
            Console.WriteLine(minhaNotaDaProva + " vale " + Convert.ToInt32(minhaNotaDaProva));
            Console.ReadKey();
        }
    }
}
