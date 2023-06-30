using System;
using System.Globalization;

namespace SistemaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo p = new Retangulo();

            Console.Write("\nLargura: ");
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nAltura: ");
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Area = p.Area();
            Console.WriteLine("\nArea = " + Area);

            double Perimetro = p.Perimetro();
            Console.WriteLine("\nPerimetro = " + Perimetro);

            double Diagonal = p.Diagonal();
            Console.WriteLine("\nDiagonal = " + Diagonal.ToString("F2") + "\n");
        }
    }
}