using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        struct DadosCadastrais
        {
            public string Nome;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
            public DateTime DataDeNascimento;
        }
        static void Main(string[] args)
        {
            DadosCadastrais meuCadastro;
            meuCadastro.Nome = "João";
            meuCadastro.NomeDaRua = "Rua das flores";
            meuCadastro.NumeroDaCasa = 24;
            meuCadastro.DataDeNascimento = Convert.ToDateTime("21/12/1985");

            Console.WriteLine(meuCadastro.Nome);
            Console.WriteLine(meuCadastro.NomeDaRua);
            Console.WriteLine(meuCadastro.NumeroDaCasa);
            Console.WriteLine(meuCadastro.DataDeNascimento.Day + "/" + meuCadastro.DataDeNascimento.Month + "/" + meuCadastro.DataDeNascimento.Year);
            Console.ReadKey();
        }
    }
}
