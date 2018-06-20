using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Clase_Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Humano1 = new Persona { Nombre = "Roy", Apellido = "Martínez", Edad = 29 };
            Persona Humano2 = new Persona { Nombre = "Samuel", Apellido = "Martínez", Edad = 31 };

            Humano1.Saludar();
            Humano2.Saludar();

            Console.WriteLine(Humano1.ToString());
            Console.WriteLine(Humano2.ToString());
        }
    }
}
