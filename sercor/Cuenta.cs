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
        public decimal  TOTAL       { get; set; }        
        public decimal  SALDO       { get; set; }
        public int      ESTADO_P    { get; set; }
        
        public Cuenta() { }

        public Cuenta(int ID_CUENTA, string ID_CLIENTE, decimal TOTAL, decimal SALDO, int ESTADO_P)
        {
            this.ID_CUENTA = ID_CUENTA;
            this.ID_CLIENTE = ID_CLIENTE;
            this.TOTAL = TOTAL;
            this.SALDO = SALDO;
            this.ESTADO_P = ESTADO_P;
        }
    }
}
