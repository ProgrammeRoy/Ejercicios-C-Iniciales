using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            // Usando el contructor con un argumento
            CuentaBancaria cuenta1 = new CuentaBancaria("000001");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta1.NoCuenta,
                cuenta1.Usuario, cuenta1.Saldo);

            // Usando el contructor con dos argumentos
            CuentaBancaria cuenta2 = new CuentaBancaria("000002", "John Doe");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta2.NoCuenta,
                cuenta2.Usuario, cuenta2.Saldo);

            // Usando el contructor con tres argumentos
            CuentaBancaria cuenta3 = new CuentaBancaria("000003", "Jane Doe", 10000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta3.NoCuenta,
                cuenta3.Usuario, cuenta3.Saldo);

            CuentaBancaria cuenta4 = new CuentaBancaria();
            */
            #endregion

            CuentaBancaria Cuenta1 = new CuentaBancaria("001");
            CuentaBancaria Cuenta2 = new CuentaBancaria("002","Roy");
            CuentaBancaria Cuenta3 = new CuentaBancaria("003","Alex",100);
            CuentaBancaria Cuenta4 = new CuentaBancaria("004","Juan",300);
            CuentaBancaria Cuenta5 = new CuentaBancaria("005","Pedro",500);
            CuentaBancaria Cuenta6 = new CuentaBancaria("006","Luis",800);

            Console.WriteLine("No Cuenta: {0}, Usuario: {1}, Saldo: {2}",Cuenta1.NoCuenta,Cuenta1.Usuario,Cuenta1.Saldo);
            Console.WriteLine("No Cuenta: {0}, Usuario: {1}, Saldo: {2}",Cuenta2.NoCuenta,Cuenta2.Usuario,Cuenta2.Saldo);
            Console.WriteLine("No Cuenta: {0}, Usuario: {1}, Saldo: {2}",Cuenta3.NoCuenta,Cuenta3.Usuario,Cuenta3.Saldo);
            Console.WriteLine("No Cuenta: {0}, Usuario: {1}, Saldo: {2}",Cuenta4.NoCuenta,Cuenta4.Usuario,Cuenta4.Saldo);
            Console.WriteLine("No Cuenta: {0}, Usuario: {1}, Saldo: {2}",Cuenta5.NoCuenta,Cuenta5.Usuario,Cuenta5.Saldo);
            Console.WriteLine("No Cuenta: {0}, Usuario: {1}, Saldo: {2}",Cuenta6.NoCuenta,Cuenta6.Usuario,Cuenta6.Saldo);
        }
    }
}
