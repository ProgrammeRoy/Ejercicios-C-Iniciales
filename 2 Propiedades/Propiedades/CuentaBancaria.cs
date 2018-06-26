using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Propiedades
{
    public class CuentaBancaria
    {
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }

        private decimal _saldo;

        //Propiedades Full
        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                }
                
                //Set Abreviado
                //_saldo = value < 0 ? 0 : value;
            }
            
        }


        #region 
        /*constructores
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta, string usuario)
            : this(noCuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo)
            : this(noCuenta, usuario)
        {
            Saldo = saldo;
        }

        public CuentaBancaria() { }
        */
        #endregion
    }
}
