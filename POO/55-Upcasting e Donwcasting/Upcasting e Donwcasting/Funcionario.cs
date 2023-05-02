using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_e_Donwcasting
{
    internal class Funcionario: Pessoa
    {
        private uint salario;
        public void ImprimeSalario()
        {
            Console.WriteLine("O salário de " + Nome + " é: " + salario);
        }
        public Funcionario(string pNome, uint pSalario): base(pNome)
        {
            salario = pSalario;
        }
    }
}
