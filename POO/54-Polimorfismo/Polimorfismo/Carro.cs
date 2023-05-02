using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Carro: Veiculo
    {
        override public void Anda()
        {
            base.Anda();
            Console.WriteLine("O carro está andando");
        }
    }
}
