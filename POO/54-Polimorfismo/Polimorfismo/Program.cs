using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro objCarro = new Carro();
            Bicicleta objBicicleta = new Bicicleta();

            objCarro.Anda();
            objBicicleta.Anda();

            Console.ReadKey();
        }
    }
}
