using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaMetodosVirtuales
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona() {}

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void Saludar()
        {
            Console.WriteLine("Hola soy {0} y tengo {1} años",Nombre,Edad);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Nombre,Edad); 
        }
    }
}
