using System;
using System.Globalization;
using System.Security.AccessControl;

//EXPLIQUE O ERRO

namespace SistemaBanco
{

    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            int numero;
            string titular;
            double saldo = 0;

            Conta C = null;

            void Cadastrar()
            {
                //Saldo = 0;

                System.Console.Write("\nNumero da conta: ");
                numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.Write("Titular da conta: ");
                titular = (Console.ReadLine());

                System.Console.Write("Haverá depósito inicial (s/n)? ");
                string di = (Console.ReadLine());

                if (di == "s" || di == "S")
                {
                    Depositar();
                    C = new Conta(numero, titular, saldo);
                }

                else
                {
                    C = new Conta(numero, titular);
                }
            }


            void Depositar()
            {
                double deposito;

                System.Console.Write("\nValor para depósito: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                saldo += deposito;

            }

            void Sacar()
            {
                double saque;

                System.Console.Write("\nValor para saque: ");
                saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Uma função local estática não pode conter uma referência a 'saldo'. [SistemaBanco]csharp(CS8421)
                saldo -= saque;
            }

            //Cadastrar();

            for (int n = -1; n < 0; n--)
            {

                while (escolha <= 0)
                {
                    System.Console.WriteLine("--------------------------------------");
                    System.Console.WriteLine("\nBanco do Brasil");
                    System.Console.WriteLine("");

                    System.Console.WriteLine("1 - Cadastrar uma nova conta");
                    System.Console.WriteLine("2 - Verificar dados da conta");
                    System.Console.WriteLine("3 - Depositar um valor");
                    System.Console.WriteLine("4 - Sacar um valor");
                    System.Console.WriteLine("");

                    System.Console.Write("Digite um valor para continuar: ");
                    escolha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                System.Console.WriteLine("");

                switch (escolha)
                {
                    case 1:
                        Cadastrar();
                        System.Console.WriteLine(C);
                        break;

                    case 2:
                        //ERRO: Uso de variável local não atribuída "C" [SistemaBanco]csharp(CS0165)
                        if (C == null)
                        {
                            System.Console.WriteLine("PRIMEIRO CADASTRE UMA CONTA!!");
                        }
                        else
                        {
                            System.Console.WriteLine(C);
                        }

                        break;

                    //ERRO: Controle não pode passar através de um rótulo case ("case 3:") para outro [SistemaBanco]csharp(CS0163)
                    case 3:
                        if (C == null)
                        {
                            System.Console.WriteLine("PRIMEIRO CADASTRE UMA CONTA!!");
                            break;
                        }
                        else
                        {
                            Depositar();
                            Console.WriteLine("DEPOSITO CONFIRMADO!!!");
                            System.Console.WriteLine(C);
                            break;
                        }


                    case 4:
                        if (C == null)
                        {
                            System.Console.WriteLine("PRIMEIRO CADASTRE UMA CONTA!!");
                            break;
                        }
                        else
                        {
                            Sacar();
                            Console.WriteLine("SAQUE CONFIRMADO!!!");
                            System.Console.WriteLine(C);
                            break;
                        }

                }
                System.Console.Write("\nDeseja fazer outra operação (s/n)?");
                string continuar = Console.ReadLine();

                if (continuar == "s" || continuar == "S")
                {
                    escolha = 0;
                }

                else
                {
                    System.Console.Write("\nOPERAÇÃO CANCELADA!!!");
                    n = 100;
                }
            }
        }
    }
}