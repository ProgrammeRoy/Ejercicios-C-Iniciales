using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            EstudianteBecaCompleta EC = new EstudianteBecaCompleta("Doe", 20, 2000);
            Console.WriteLine(EC);
            EC.Saludar();
            EC.becado();

            EstudianteMediaBeca EM = new EstudianteMediaBeca("Joe", 22, 1500);
            Console.WriteLine(EM);
            EM.Saludar();
            EM.becado();
        }
    }
}
