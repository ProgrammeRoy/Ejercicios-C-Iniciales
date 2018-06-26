using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararObjetos
{
    // Luego de los dos puntos crea un metodo para comparar <>
    class Producto: IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        //Este es el método creado para comparar
        public int CompareTo(Producto otro)
        {
            // >0 mayor
            if (this.Precio > otro.Precio) return 1;
            // == 0 igual
            if (this.Precio == otro.Precio) return 0;
            // <0 menor
            return -1;
        }
    }
}
