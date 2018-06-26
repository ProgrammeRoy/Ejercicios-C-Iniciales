using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjercicio2
{
    class EstudianteMediaBeca: Estudiante
    {
        public double _Beca { get; set; }

        public override double PensionBeca
        {
            get
            {
                return _Beca*0.5;
            }
            
        }

        public EstudianteMediaBeca(string nombre, int edad, double _beca): base(nombre,edad)
        {
            _Beca = _beca;
        }

        public override void becado()
        {
            Console.WriteLine("La pensión regular para mi carrera es {0} soles",_Beca);
            Console.WriteLine("Mi pensión por beca es {0} soles",PensionBeca);
        }

        public override string ToString()
        {
            return string.Format("{0},{1} años, 50 % de beca",Nombre,Edad); 
        }
    }
}
