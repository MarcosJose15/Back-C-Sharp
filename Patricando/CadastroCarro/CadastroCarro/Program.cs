using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CadastroCarro
{
    internal class Program
    {
        struct Carro_Struct
        {
            public string nome;
            public string marca;
            public UInt32 ano;
            public bool novo;
            public string placa;
        };


        static void Main(string[] args)
        {
            List<Carro_Struct> ListaDeCarros = new List<Carro_Struct>();
            string opcao;
            do
            {
                Console.WriteLine("Digite 'c' para CADASTRAR ou 's' para SAIR ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    //Cadastrar um novo usuário
                    Carro_Struct Carro;
                    Console.WriteLine("Informe o nome do carro: ");
                    Carro.nome = Console.ReadLine();

                    Console.WriteLine("Informe o modelo do carro: ");
                    Carro.marca = Console.ReadLine();

                    Console.WriteLine("Informe o ano do carro: ");
                    Carro.ano = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Informe se o carro é novo: ");
                    Carro.novo = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Informe a placa do carro: ");
                    Carro.placa = Console.ReadLine();

                    ListaDeCarros.Add(Carro);
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    //Fechar aplicação
                    Console.WriteLine("Encerrando a aplicaçõa");
                }
                else
                {
                    //Opcao desconhecida
                    Console.WriteLine("Opção desconhecida");
                }
            }
            while (opcao != "s");
            {
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}