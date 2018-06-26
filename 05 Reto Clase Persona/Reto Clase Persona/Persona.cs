using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Clase_Persona
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private int _edad;

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value < 0 ? 0 : value;
            }
        }

        #region Constructores
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(string nombre, string apellido) : this(nombre)
        {
            Apellido = apellido;
        }

        public Persona(string nombre, string apellido, int edad) : this(nombre,apellido)
        {
            Edad = edad;
        }

        public Persona()
        {

        }
        #endregion

        public void Saludar()
        {
            Console.WriteLine("Hola " +Nombre + " " + Apellido);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}. Apellido: {1}, Edad: {2}",Nombre,Apellido,Edad); 
        }
    }
}
