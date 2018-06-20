using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosDeInstancia
{
    /// <summary>
    /// Métodos de instancia
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria Cuenta1 = new CuentaBancaria { NoCuenta = "001", Usuario = "Roy", Saldo = 20000 };
            CuentaBancaria Cuenta2 = new CuentaBancaria { NoCuenta = "002", Usuario = "Ernesto", Saldo = 50000 };

            Console.WriteLine(Cuenta1.ToString());
            Console.WriteLine(Cuenta2.ToString());

            Cuenta1.Depositar(20000);
            Cuenta2.Retirar(10000);

            Console.WriteLine(Cuenta1.ToString());
            Console.WriteLine(Cuenta2.ToString());

        }
    }
}
