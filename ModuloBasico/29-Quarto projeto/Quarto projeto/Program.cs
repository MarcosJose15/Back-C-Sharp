using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto_projeto
{
    internal class Program
    {
        struct DadosCadastrais_Strcut
        {
            public string Nome;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
            public string NumeroDoDocumento;
        };
        static void Main(string[] args)
        {
            List<DadosCadastrais_Strcut> ListaDeCadastros = new List<DadosCadastrais_Strcut>();
            string opcao;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair:");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if(opcao == "c")
                {
                    //Cadastrar um novo usuário
                    DadosCadastrais_Strcut dadosCadastrais;
                    Console.WriteLine("Digite o nome completo:");
                    dadosCadastrais.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o nome da rua:");
                    dadosCadastrais.NomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite o número da casa:");
                    dadosCadastrais.NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Digite número do documento");
                    dadosCadastrais.NumeroDoDocumento = Console.ReadLine();
                    ListaDeCadastros.Add(dadosCadastrais);
                    Console.Clear();
                }
                else if(opcao == "s")
                {
                    //Encerrar a aplicação
                    Console.WriteLine("Encerrando a aplicação.");
                }
                else
                {
                    //Opção desconhecida
                    Console.WriteLine("Opção desconhecida!");
                }
            } while (opcao != "s");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
