using System;
using System.Collections Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oitavo_projeto
{
    internal class InterfaceGrafica
    {

        //Enum - projeto 7
        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2
        }


        //Metodos antigos - do projeto 7
        public void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
                retorno = Resultado_e.Sair;
            else
            {
                minhaString = temp;
                retorno = Resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {

                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem("EXCECAO: " + e.Message);
                    retorno = Resultado_e.Excecao;
                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public Resultado_e PegaUInt32(ref UInt32 numeroUInt32, string mensagem)
        {
            Resultado_e retorno;
            do
            {

                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        numeroUInt32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem("EXCECAO: " + e.Message);                    
                    retorno = Resultado_e.Excecao;
                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        //Atributo que aponta para base dados
        BaseDeDados baseDeDados;

        //Construtor
        public InterfaceGrafica(BaseDeDados pBaseDeDados)
        {
            baseDeDados = pBaseDeDados;
        }

        //Metodos novos
        public void ImprimeDadosNaTela(CadastroPessoa pPessoa)
        {
            Console.WriteLine("Nome: " + pPessoa.Nome);
            Console.WriteLine("Número do documento: " + pPessoa.NumeroDoDocumento);
            Console.WriteLine("Data de nascimento: " + pPessoa.DataDeNascimento);
            Console.WriteLine("Nome da rua: " + pPessoa.NomeDaRua);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}