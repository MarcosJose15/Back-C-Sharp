using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade = 18;
            Idade = 18;
            Console.WriteLine(Idade);

            Idade = 20;
            Console.WriteLine(Idade);

            string NomeCompleto = "Guilherme Alvez";

            Console.WriteLine("Guilherme Alvez");
            Console.WriteLine(NomeCompleto);

            NomeCompleto = "Joana Martins";
            Console.WriteLine(NomeCompleto);

            //byte b = 10000; O valor 10000 é muito grande para uma variável do tipo byte. VAI DAR ERRO

            var Salario = 10000;
            var NomeDaMae = "Joana";
            //NomeDaMae = 10000; Isso não é possível, pois o compilador já atribuiu o tipo string para a nossa variável

            DateTime DataDeNascimento = new DateTime(1988, 7, 10, 7, 15, 10);
            Console.WriteLine(DataDeNascimento.Year);
            Console.WriteLine(DataDeNascimento.Month);
            Console.WriteLine(DataDeNascimento.Day);
            Console.WriteLine(DataDeNascimento.Hour);
            Console.WriteLine(DataDeNascimento.Minute);
            Console.WriteLine(DataDeNascimento.Second);


            string NumeroDaCasa = "65";
            int NumeroDaCasaInt = Convert.ToInt32(NumeroDaCasa);
            Console.WriteLine(NumeroDaCasaInt);

            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaInt);
            Console.WriteLine(NumeroDaCasa2);

            byte b = 50;
            char c = Convert.ToChar(b); // Utiliza a tabela ASCII
            Console.WriteLine(c);

            int charC = Convert.ToInt32(c);
            Console.WriteLine(charC);

            double d = 1.3;
            Console.WriteLine(d);

            int conversaoDoDouble = Convert.ToInt32(d);
            Console.WriteLine(conversaoDoDouble);

            //Teremos um erro, pois o valor 1000 é muito grande para uma variável do tipo byte
            //int NumeroGrande = 1000;
            //byte NumeroPequeno = Convert.ToByte(NumeroGrande);
            //Console.WriteLine(NumeroPequeno);

            Console.ReadKey();
        }
    }
}
