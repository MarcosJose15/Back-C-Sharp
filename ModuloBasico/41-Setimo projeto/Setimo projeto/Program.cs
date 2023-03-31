﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Setimo_projeto
{
    internal class Program
    {
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagDataNasicmento;
        static string tagNomeDaRua;
        static string tagNumeroDaCasa;
        static string tagNumeroDeDocumento;
        static string caminhoArquivo;
        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNascimento;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
            public string NumeroDoDocumento;
        }
        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2
        }
        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static Resultado_e PegaString(ref string minhaString, string mensagem)
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
        public static Resultado_e PegaData(ref DateTime data, string mensagem)
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
                    Console.WriteLine("EXCECAO: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaUInt32(ref UInt32 numeroUInt32, string mensagem)
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
                    Console.WriteLine("EXCECAO: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e CadastraUsuario(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.Nome = "";
            cadastroUsuario.DataDeNascimento = new DateTime();
            cadastroUsuario.NomeDaRua = "";
            cadastroUsuario.NumeroDaCasa = 0;
            cadastroUsuario.NumeroDoDocumento = "";
            if (PegaString(ref cadastroUsuario.Nome, "Digite o nome completo ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaData(ref cadastroUsuario.DataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref cadastroUsuario.NumeroDoDocumento, "Digite o número do documento ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref cadastroUsuario.NomeDaRua, "Digite o nome da rua ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaUInt32(ref cadastroUsuario.NumeroDaCasa, "Digite o número da casa ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            ListaDeUsuarios.Add(cadastroUsuario);
            GravaDados(caminhoArquivo, ListaDeUsuarios);
            return Resultado_e.Sucesso;
        }

        public static void GravaDados(string caminho, List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            try
            {
                string conteudoArquivo = "";
                foreach (DadosCadastraisStruct cadastro in ListaDeUsuarios)
                {
                    conteudoArquivo += delimitadorInicio + "\r\n";
                    conteudoArquivo += tagNome + cadastro.Nome + "\r\n";
                    conteudoArquivo += tagDataNasicmento + cadastro.DataDeNascimento.ToString("dd/MM/yyyy") + "\r\n";
                    conteudoArquivo += tagNumeroDeDocumento + cadastro.NumeroDoDocumento + "\r\n";
                    conteudoArquivo += tagNomeDaRua + cadastro.NomeDaRua + "\r\n";
                    conteudoArquivo += tagNumeroDaCasa + cadastro.NumeroDaCasa + "\r\n";
                    conteudoArquivo += delimitadorFim + "\r\n";
                }
                File.WriteAllText(caminho, conteudoArquivo);

            }
            catch (Exception e)
            {
                Console.WriteLine("EXCECAO: " + e.Message);
            }
        }

        public static void CarregaDados(string caminho, ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            try
            {
                if (File.Exists(caminho))
                {
                    string[] conteudoArquivo = File.ReadAllLines(caminho);
                    DadosCadastraisStruct dadosCadastrais;
                    dadosCadastrais.Nome = "";
                    dadosCadastrais.DataDeNascimento = new DateTime();
                    dadosCadastrais.NomeDaRua = "";
                    dadosCadastrais.NumeroDaCasa = 0;
                    dadosCadastrais.NumeroDoDocumento = "";

                    foreach (string linha in conteudoArquivo)
                    {
                        if (linha.Contains(delimitadorInicio))
                            continue;
                        if (linha.Contains(delimitadorFim))
                            ListaDeUsuarios.Add(dadosCadastrais);
                        if (linha.Contains(tagNome))
                            dadosCadastrais.Nome = linha.Replace(tagNome, "");
                        if (linha.Contains(tagDataNasicmento))
                            dadosCadastrais.DataDeNascimento = Convert.ToDateTime(linha.Replace(tagDataNasicmento, ""));
                        if (linha.Contains(tagNumeroDeDocumento))
                            dadosCadastrais.NumeroDoDocumento = linha.Replace(tagNumeroDeDocumento, "");
                        if (linha.Contains(tagNomeDaRua))
                            dadosCadastrais.NomeDaRua = linha.Replace(tagNomeDaRua, "");
                        if (linha.Contains(tagNumeroDaCasa))
                            dadosCadastrais.NumeroDaCasa = Convert.ToUInt32(linha.Replace(tagNumeroDaCasa, ""));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCECAO: " + e.Message);
            }
        }

        public static void BuscaUsuarioPeloDoc(List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            Console.WriteLine("Digite o número do documento para buscar o usuário ou digite S para sair");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s")
                return;
            else
            {
                List<DadosCadastraisStruct> ListaDeUsuariosTemp = ListaDeUsuarios.Where(x => x.NumeroDoDocumento == temp).ToList();
                if(ListaDeUsuariosTemp.Count>0)
                {
                    foreach(DadosCadastraisStruct usuario in ListaDeUsuariosTemp)
                    {
                        Console.WriteLine(tagNome + usuario.Nome);
                        Console.WriteLine(tagDataNasicmento + usuario.DataDeNascimento.ToString("dd/MM/yyyy"));
                        Console.WriteLine(tagNumeroDeDocumento + usuario.NumeroDoDocumento);
                        Console.WriteLine(tagNomeDaRua + usuario.NomeDaRua);
                        Console.WriteLine(tagNumeroDaCasa + usuario.NumeroDaCasa);
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum usuário possui o documento: " + temp);
                }
                //
                MostraMensagem("");
            }
        }

        public static void ExcluiUsuarioPeloDoc(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            Console.WriteLine("Digite o número do documento para excluir o usuário ou digite S para sair");
            string temp = Console.ReadLine();
            bool alguemFoiExcluido = false;
            if (temp.ToLower() == "s")
                return;
            else
            {
                List<DadosCadastraisStruct> ListaDeUsuariosTemp = ListaDeUsuarios.Where(x => x.NumeroDoDocumento == temp).ToList();
                if(ListaDeUsuariosTemp.Count>0)
                {
                    foreach(DadosCadastraisStruct usuario in ListaDeUsuariosTemp)
                    {
                        ListaDeUsuarios.Remove(usuario);
                        alguemFoiExcluido = true;
                    }
                    if (alguemFoiExcluido)
                        GravaDados(caminhoArquivo, ListaDeUsuarios);
                    Console.WriteLine(ListaDeUsuariosTemp.Count + " usuário(s) com documento " + temp + " excluído(s)");
                }
                else
                {
                    Console.WriteLine("Nenhum usuário possui o documento: " + temp);
                }
            }
            MostraMensagem("");
        }

        static void Main(string[] args)
        {
            List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";
            delimitadorInicio = "##### INICIO #####";
            delimitadorFim = "##### FIM #####";
            tagNome = "NOME: ";
            tagDataNasicmento = "DATA_DE_NASCIMENTO: ";
            tagNomeDaRua = "NOME_DA_RUA: ";
            tagNumeroDaCasa = "NUMERO_DA_CASA: ";
            tagNumeroDeDocumento = "NUMERO_DO_DOCUMENTO: ";
            caminhoArquivo = @"baseDeDados.txt";

            CarregaDados(caminhoArquivo, ref ListaDeUsuarios);

            do
            {
                Console.WriteLine("Pressione C para cadastrar um novo usuário");
                Console.WriteLine("Pressione B para buscar um usuário");
                Console.WriteLine("Pressione E para excluir um usuário");
                Console.WriteLine("Pressione S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    //Cadastrar um novo usuário
                    CadastraUsuario(ref ListaDeUsuarios);   
                }
                else if (opcao == "b")
                {
                    //buscar usuário
                    BuscaUsuarioPeloDoc(ListaDeUsuarios);
                }
                else if (opcao == "e")
                {
                    //Excluir usuário
                    ExcluiUsuarioPeloDoc(ref ListaDeUsuarios);
                }
                else if (opcao == "s")
                {
                    //Sair da aplicação
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    //Opção desconhecida
                    MostraMensagem("Opção desconhecida");
                }
            } while (opcao != "s");
        }
    }
}
