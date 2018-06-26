using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaMetodosVirtuales
{
    class Estudiante: Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante() { }

        public Estudiante(string nombre, int edad, double promedio, string grado) :base(nombre, edad)
        {
            Promedio = promedio;
            Grado = grado;
        }

        public void Estudiar()
        {
            Console.WriteLine("{0} está estudiando",Nombre);
        }

        public void IrAClase()
        {
            Console.WriteLine("{0} está llendo a clase y cursa el {1} grado", Nombre, Grado);
        }

        public override void Saludar()
        {
            Console.WriteLine("Me llamo {0}, curso el {1} grado y tengo una nota promedio de {2}", Nombre, Grado, Promedio);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} años, promedio: {2}, Grado: {3}", Nombre, Edad, Promedio, Grado);
        }
    }
}
