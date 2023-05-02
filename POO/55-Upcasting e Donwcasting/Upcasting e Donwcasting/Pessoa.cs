using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_e_Donwcasting
{
    internal class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
        }
        public void ImprimeNome()
        {
            Console.WriteLine("O nome da pessoa é: " + nome);
        }
        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }
}
