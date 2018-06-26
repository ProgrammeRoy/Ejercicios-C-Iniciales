using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class CuentaBancaria
    {
        #region
        /*public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        public decimal Saldo { get; set; }

        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta)
        {            
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : this(noCuenta, usuario)
        {            
            Saldo = saldo;
        }

        // Constructor Vacío
        public CuentaBancaria() { }
        */
        #endregion

        public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        public decimal Saldo { get; set; }

        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta,string usuario) : this(noCuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta,string usuario, decimal saldo) : this(noCuenta,usuario)
        {
            Saldo = saldo;   
        }
        public CuentaBancaria()
        {
            
        }
    }
}
