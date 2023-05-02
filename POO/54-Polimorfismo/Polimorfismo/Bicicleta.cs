using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Bicicleta: Veiculo
    {
        override public void Anda()
        {
            Console.WriteLine("A bicleta está andando");
        }
    }
}
