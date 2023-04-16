using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_matematicos_avancados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Potenciação
            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine(potenciacao);

            //Radiciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1/raiz);
            Console.WriteLine(radiciacao);

            //Máximo e o mínimo
            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);

            double minimo = Math.Min(4, 8);
            Console.WriteLine(minimo);

            //Módulo
            double modulo = Math.Abs(-10);
            Console.WriteLine(modulo);

            //Operações trigonométricas
            double angulo = 30 * (2 * Math.PI) / 360;
            //Seno - Sin
            //Cosseno - Cos
            //Tangente - Tan
            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);

            //Arcseno - Asin
            //Arccosseno - Acon
            //ArcTangente - Atan
            double arseno = Math.Asin(seno);
            Console.WriteLine(arseno);
            double arcsenoGraus = arseno * 360 / (2 * Math.PI);
            Console.WriteLine(arcsenoGraus);

            //Arredondando números
            double numero = 3.33;
            double arredondandoParaCima = Math.Ceiling(numero);
            Console.WriteLine(arredondandoParaCima);

            double arredondandoParaBaixo = Math.Floor(numero);
            Console.WriteLine(arredondandoParaBaixo);

            //Logaritmo
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);

            double baseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(baseE);

            Console.ReadKey();
        }
    }
}
