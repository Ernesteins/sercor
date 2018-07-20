using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Cuenta
    {
        public int      ID_CUENTA   { get; set; }
        public string   ID_CLIENTE  { get; set; }
        public int      ID_FACTURA  { get; set; }
        public decimal  TOTAL       { get; set; }
        public int      FORMA_P     { get; set; }
        public decimal  SALDO       { get; set; }
        public int      ESTADO_P    { get; set; }
        
        public Cuenta() { }

        public Cuenta(int ID_CUENTA, string ID_CLIENTE, int ID_FACTURA, decimal TOTAL, int FORMA_PAGO, decimal SALDO, int ESTADO_P)
        {
            this.ID_CUENTA = ID_CUENTA;
            this.ID_CLIENTE = ID_CLIENTE;
            this.ID_FACTURA = ID_FACTURA;
            this.TOTAL = TOTAL;
            this.FORMA_P = FORMA_PAGO;
            this.SALDO = SALDO;
            this.ESTADO_P = ESTADO_P;
        }
    }
}
