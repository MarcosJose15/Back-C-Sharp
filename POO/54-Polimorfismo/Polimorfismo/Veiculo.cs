using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Veiculo
    {
        virtual public void Anda()
        {
            Console.WriteLine("O veículo está andando");
        }
    }
}
