using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloMiltidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando arreglo multidimensional
            int[,] arregloMulti = new int[3, 2] { { 1, 2 }, { 2, 3 },{ 3, 2 } };

            //Recorriendo arreglo por filas y columnas
            for (int i=0; i<arregloMulti.GetLength(0);i++)
            {
                for (int j=0; j<arregloMulti.GetLength(1);j++)
                {
                    //Console.WriteLine("Arreglo Fila {0} y columna {1} es: {2}",i,j,arregloMulti[i,j]);
                    Console.WriteLine("ArregloMulti: [{0},{1}] Valor:{2}",(i + 1),(j + 1),arregloMulti[i,j]);
                }
            }

            //Declarando arreglo multidimensional con forma de matriz 3x3
            int[,] matriz = new int[3, 3] { { 2, 2, 1 }, { 1, 2, 5 }, { 3, 4, 5 } };
            //Mostrando en formato matriz
            for (int i = 0; i < matriz.GetLength(0) ; i++)
            {
                for(int j=0; j<matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
