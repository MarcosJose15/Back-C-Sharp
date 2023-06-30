using System;
using System.Globalization;

namespace SistemaRetangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return (Largura * Altura);
        }

        public double Perimetro()
        {
            double P = 2*(Largura + Altura);

            return P;
        }

        public double Diagonal()
        {
            double D = Math.Sqrt(Altura * Altura + Largura * Largura);

            return D;
        }

    }
}
