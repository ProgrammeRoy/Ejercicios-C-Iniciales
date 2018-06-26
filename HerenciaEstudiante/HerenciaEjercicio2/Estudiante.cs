using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjercicio2
{
    abstract class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public abstract double PensionBeca { get;}

        public Estudiante() { }

        public Estudiante(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0} y tengo {1} años",Nombre,Edad);
        }

        public abstract void becado();
    }
}
