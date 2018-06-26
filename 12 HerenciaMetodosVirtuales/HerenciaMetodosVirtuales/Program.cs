using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaMetodosVirtuales
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona H1 = new Persona("Pablo", 32);
            H1.Saludar();
            Empleado E1 = new Empleado("Abraham", 800, "Predicador", 2);
            E1.Saludar();
            Console.WriteLine(E1);
            Console.WriteLine();
            Estudiante Roy = new Estudiante("Roy", 29, 16.7, "Onceavo");
            Roy.Estudiar();
            Roy.IrAClase();
            Roy.Saludar();
            Roy.ToString();
            Console.WriteLine(Roy);
        }
    }
}
