using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_logicos_entre_variaveis_numericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Negação - ~
            int var1 = 0b11001100;
            int resultadoNegacao = ~var1;
            Console.WriteLine("O resultado da negação de " + Convert.ToString(var1, 2) + " é: " + Convert.ToString(resultadoNegacao, 2));
            

            //Operador OU (OR) - |
            int var2 = 0b11001100;
            int var3 = 0b11110000;
            int resultadoOU = var2 | var3;
            Console.WriteLine("O resultado da operação OU entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoOU, 2));
            

            //Operador E (AND) - &
            int resultadoE = var2 & var3;
            Console.WriteLine("O resultado da operação E entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoE, 2));
            

            //Operador OU EXCLUSIVO (XOR) - ^
            int resultadoXOR = var2 ^ var3;
            Console.WriteLine("O resultado da operação XOR entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoXOR, 2));
            

            //Operador > e <
            int var4 = 10;
            int var5 = 20;
            Console.WriteLine("O valor " + var4 + " é maior que (>) " + var5 + "?:" + (var4>var5));
            Console.WriteLine("O valor " + var4 + " é menor que (<) " + var5 + "?:" + (var4 < var5));

            //Operador >= e <=
            Console.WriteLine("O valor " + var4 + " é maior ou igual a (>=) " + var5 + "?:" + (var4 >= var5));
            Console.WriteLine("O valor " + var4 + " é menor ou igual a (<=) " + var5 + "?:" + (var4 <= var5));
            Console.WriteLine("O valor " + var4 + " é maior ou igual a (>=) " + var4 + "?:" + (var4 >= var4));
            Console.WriteLine("O valor " + var5 + " é menor ou igual a (<=) " + var5 + "?:" + (var5 <= var5));


            //Operador igual - ==
            bool resultadoIgual = (var4 == var4);
            Console.WriteLine("O valor " + var4 + " é igual a " + var4 + "?:" + resultadoIgual);
            Console.WriteLine("O valor " + var4 + " é igual a " + var5 + "?:" + (var4 == var5));
            Console.ReadKey();
        }
    }
}
