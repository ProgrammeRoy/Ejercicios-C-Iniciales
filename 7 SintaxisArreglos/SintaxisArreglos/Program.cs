using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxisArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Sintaxis 1
            int[] arreglo = new int[5];
            arreglo[0] = 1;
            arreglo[1] = 0;
            arreglo[2] = 20;
            arreglo[3] = -4;
            arreglo[4] = 8;

            Console.WriteLine(arreglo[4]);

            // Sintaxis 2
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine(vocales[2]);

            // Sintaxis 3
            double[] numeros = { 1.1, 2.2, 3.4, 5.8 };
            Console.WriteLine("Tamaño de números: {0}", numeros.Length);

            // mostrar último elemento
            Console.WriteLine(numeros[numeros.Length - 1]);
            */

            // Sintaxis 4
            string[] palabras = new string[] { "Auto", "Avión", "Cometa", "Tren", "Buque" };
            for(int i = 0; i<palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
            }

            int[] numeros = new int[8];

            char[] letras = new char[6];
            char[] vocales = new char[] {'a','e','i','o','u'};
            Console.WriteLine(vocales[0]);
            Console.WriteLine(vocales.Length);
        }
    }
}
