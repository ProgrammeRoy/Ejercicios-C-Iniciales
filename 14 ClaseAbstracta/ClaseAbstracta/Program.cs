using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoHonorarios eh = new EmpleadoHonorarios("Eduardo", "Asesor", 1500);
            eh.Saludar();
            eh.Trabajar();
            Console.WriteLine("Salario por honorarios: {0}", eh.Sueldo);

            EmpleadoNomina en = new EmpleadoNomina("Julio", "Vendedor", 1200);
            en.Saludar();
            en.Trabajar();
            Console.WriteLine("Salario por nómina: {0}", en.Sueldo);
        }
    }
}
