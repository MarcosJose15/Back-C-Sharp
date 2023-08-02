using System;
using System.Collections.Generic;
using System.Globalization;
using MetodoAbstrato.Entities.Enums;
using MetodoAbstrato.Entities;

namespace Enumeracoes_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listShapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(tipo == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listShapes.Add(new Rectangle(width, height, color));
                }

                if(tipo == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listShapes.Add(new Circle(radius, color));
                }   
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in listShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}