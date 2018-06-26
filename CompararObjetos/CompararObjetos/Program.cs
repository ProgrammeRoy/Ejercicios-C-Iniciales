using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto P1 = new Producto { Codigo = "A1", Precio = 123 };
            Producto P2 = new Producto { Codigo = "A2", Precio = 34.5m };
            Producto P3 = new Producto { Codigo = "A3", Precio = 99.9m };

            Producto[] productos = new Producto[] { P1, P2, P3 };
            Array.Sort(productos);

            foreach (var prod in productos)
            {
                Console.WriteLine("Codigo: {0}, Precio {1}", prod.Codigo, prod.Precio);
            }
        }
    }
}
