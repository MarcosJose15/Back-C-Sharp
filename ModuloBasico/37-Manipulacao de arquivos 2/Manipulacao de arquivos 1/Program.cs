using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_de_arquivos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\Users\CANCI\source\repos\Manipulacao de arquivos 1\Manipulacao de arquivos 1\bin\Debug\teste.txt";
            string caminhoArquivo2 = @"C:\Users\CANCI\source\repos\Manipulacao de arquivos 1\Manipulacao de arquivos 1\bin\Debug\teste2.txt";
            string texto1 = "João subiu no telhado. \r\n";
            string texto2 = "Luana, sua mãe, brigou com ele. \r\n";

            //Maneira não muito correta
            string conteudoInicial = File.ReadAllText(caminhoArquivo);
            string conteudoFinal = conteudoInicial + texto1 + texto2;
            File.WriteAllText(caminhoArquivo, conteudoFinal);

            //Maneira mais correta
            //File.AppendAllText(caminhoArquivo2, texto1);
            //File.AppendAllText(caminhoArquivo2, texto2);
            File.AppendAllText(caminhoArquivo2, texto1+texto2);
        }
    }
}
