using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            //Creaciones de instancias con su relación
            IFigura f1 = new Circulo { Radio = 5 };
            IFigura f2 = new Triangulo { Base = 10, Altura = 8 };
            IFigura f3 = new Rectangulo { Base = 4, Altura = 3 };
            IFigura f4 = new Circulo { Radio = 9 };

            //Crea un array de las clases
            IFigura[] figuras = new IFigura[] { f1, f2, f3, f4 };

            //Recorre todo el array
            foreach (var fig in figuras)
            {
                Console.WriteLine(fig.CalcularArea());
            }
            Console.WriteLine("");


            //Downcasting, esto permite usar los metodos especificos de cada clase
            Circulo c = f1 as Circulo;
            Console.Write("Datos del circulo: ");
            c.DatosCirculo();
            Console.WriteLine("");

            Triangulo t = f2 as Triangulo;
            Console.Write("Datos del triangulo: ");
            t.DatosTriangulo();
            Console.WriteLine("");

            Rectangulo r = f3 as Rectangulo;
            Console.Write("Datos del Rectangulo: ");
            r.DatosRectangulo();
            Console.WriteLine("");
        }
    }
}
