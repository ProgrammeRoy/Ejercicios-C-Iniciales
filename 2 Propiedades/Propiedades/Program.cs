using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Propiedades
{
    /// <summary>
    /// Propiedades
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria Cuenta1 = new CuentaBancaria();
            Cuenta1.Saldo = 1550000000;
            Console.WriteLine("Saldo: {0}",Cuenta1.Saldo);
        }
    }
}
