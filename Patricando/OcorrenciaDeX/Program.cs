using System;

namespace ExercicioMatrizes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe m x n para matriz: ");
            //recebe linha e dividi
            string[] line = Console.ReadLine().Split(' ');

            //aponta m n a um pedaço do array
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            //Criando matriz e instanciando com valores m n referentes ao tamanho da matriz.
            int[,] mat = new int[m, n];

            Console.WriteLine("Digite toda matriz.");
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Informe um numero para procurar as suas ocorrencias na matriz.");

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            //NUMERO A ESQUERDA
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            //NUMERO A CIMA
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            //NUMERO A DIREITA
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            //NUMERO A BAIXO
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                        Console.WriteLine("\n");
                    }
                }
            }






            /* // m = 3;  Number of rows - linhas i
            // n = 4; Number of columns - colunas j

            Console.WriteLine("Informe quantidade de linha x coluna:");
            string[] values = Console.ReadLine().Split(' ');
            int m, n;
        

            int[,] mat = new int (value[m, n]); */

        }
    }
}