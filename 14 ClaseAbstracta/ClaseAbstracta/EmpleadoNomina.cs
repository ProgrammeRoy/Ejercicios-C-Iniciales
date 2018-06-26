using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class EmpleadoNomina: Empleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Sueldo
        {
            get
            {
                return SueldoBase;
            }
        }

        public EmpleadoNomina(string nombre, string puesto, decimal sueldoBase): base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por Nómina");
        }
    }
}
