using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesConMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = { { 1.2, 2 }, { 3.2, 4.3 } };
            double[,] matrizB = { { 0, 5 }, { 3, 2.3 } };

            Console.WriteLine("MatrizA");
            MostrarMatriz(matrizA);
            Console.WriteLine("MatrizB");
            MostrarMatriz(matrizB);

            double[,] suma = new double[matrizA.GetLength(0),matrizA.GetLength(1)];
            for (int i=0; i<matrizA.GetLength(0);i++ )
            {
                for (int j=0;j<matrizA.GetLength(1);j++)
                {
                    suma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            Console.WriteLine("Suma de Matrices");
            MostrarMatriz(suma);
        }
        static void MostrarMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0:0.#0}  ",matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
