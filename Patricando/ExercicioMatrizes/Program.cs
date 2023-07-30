using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int [n, n];

            //Este for de dentro é para as colunas
            for (int i = 0; i < n; i++){

                string[] values = Console.ReadLine().Split(' ');

                //Este for de dentro é para as colunas
                for (int j = 0; j < n; j++){
                        mat [i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat [i,j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: "+ count);
        }
    }
}