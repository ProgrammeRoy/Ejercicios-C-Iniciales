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

    // Propiedad abstract debe definirse en las clases hereadads
    public abstract double PensionBeca { get; }

    //primer constructor sin parametros
    public Estudiante() { }

    //segundo constructor con 2 parametros
    public Estudiante(string nombre, int edad)
    {
      // Inicializando 2 propiedades según los 2 parámetros de ingreso
      Nombre = nombre;
      Edad = edad;

    }

    // implemnetado en clase abstracta, en las clases heredadas NO SE PUEDE MODIFICAR
    public void Saludar()
    {
      Console.WriteLine("Hola, mi nombre es {0} y tengo {1} años", Nombre, Edad);
    }
    //Metodo implemnetado en clase abstracta, en las clases heredadas SI SE PUEDE MODIFICAR
    public virtual void MetodoCambiable()
    {
      Console.WriteLine("Este metodo está definido pero puede cambiarse");
    }

    // Metodo que debe implementarse obligatoriamente en los hijos
    public abstract void becado();
  }
}
