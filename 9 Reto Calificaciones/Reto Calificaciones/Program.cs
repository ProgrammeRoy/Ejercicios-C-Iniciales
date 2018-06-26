using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear una aplicacion de consola que solicite al usuario la cantidad 
            de calificaciones a ingresar, despúes leer dichas calificaciones y 
            guardarlas en un arreglo.
            Calcular el promedio de las calificaciones y mostrarlas como resultado.
            */
            Console.WriteLine("SAM: Ingrese la cantidad de calificaciones a ingresar");
            int cantidadCalificaciones = Int32.Parse( Console.ReadLine());

            int[] Calificaciones = new int[cantidadCalificaciones];

            for (int i= 0; i<cantidadCalificaciones; i++)
            {
                Console.Write("Ingresa la calificación " + (i+1) + ": ");
                Calificaciones[i] = Int32.Parse( Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Las calificaciones son: ");
            for (int i= 0; i<cantidadCalificaciones; i++)
            {
                Console.WriteLine("Calificación " + (i+1) + " : "+ Calificaciones[i]);
            }

            int Suma = 0;
            for (int i=0; i<cantidadCalificaciones; i++)
            {
                int almacena = Calificaciones[i];
                Suma = Suma + almacena;
            }

            int Promedio = Suma / cantidadCalificaciones;
            Console.WriteLine("El promedio de las calificaciones es: " + Promedio);
        }
    }
}
