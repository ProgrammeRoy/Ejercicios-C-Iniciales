using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjercicio2
{
  class EstudianteBecaCompleta : Estudiante
  {
    public double _Beca { get; set; }

    //Sobreescribiendo necesariamente (porque era abstract) el método GET de la propiedad "PensionBeca"
    public override double PensionBeca
    {
      get
      {
        return _Beca * 0;
      }
    }

    //Recibe 3 parámetros, pero en esta clase solo inicializa uno, los otros 2 son inicianlizados en la clase "base" (osea Estudiante)
    public EstudianteBecaCompleta(string nombre, int edad, double _beca) : base(nombre, edad)
    {
      _Beca = _beca;
    }

    public override void becado()
    {
      Console.WriteLine("La pensión regular para mi carrera es {0} soles", _Beca);
      Console.WriteLine("Mi pensión por beca es {0} soles", PensionBeca);
    }

    public override void MetodoCambiable()
    {
      Console.WriteLine("Modifique el metodo");
    }

    public override string ToString()
    {
      return string.Format("{0}, {1} años, 100 % de beca", Nombre, Edad);
    }

  }
}
