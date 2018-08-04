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
        public decimal  SALDO       { get; set; }
        public int      ESTADO_P    { get; set; }
        
        public Cuenta() { }

        public Cuenta(int ID_CUENTA, string ID_CLIENTE, int ID_FACTURA, decimal TOTAL, decimal SALDO, int ESTADO_P)
        {
            this.ID_CUENTA = ID_CUENTA;
            this.ID_CLIENTE = ID_CLIENTE;
            this.ID_FACTURA = ID_FACTURA;
            this.TOTAL = TOTAL;
            this.SALDO = SALDO;
            this.ESTADO_P = ESTADO_P;
        }
    }
    public class CuentaN
    {
        public int ID_CUENTA { get; set; }
        public string ID_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public int ID_DOCUMENTO { get; set; }
        public int TIPO { get; set; }
        public decimal TOTAL { get; set; }
        public decimal SALDO { get; set; }
        public int ESTADO_P { get; set; }

        public CuentaN() { }

        public CuentaN(int ID_CUENTA, string ID_CLIENTE, string NOMBRE_CLIENTE, int ID_DOCUMENTO, int TIPO, decimal TOTAL, decimal SALDO, int ESTADO_P)
        {
            this.ID_CUENTA = ID_CUENTA;
            this.ID_CLIENTE = ID_CLIENTE;
            this.NOMBRE_CLIENTE = NOMBRE_CLIENTE; 
            this.ID_DOCUMENTO = ID_DOCUMENTO;
            this.TIPO = TIPO;
            this.TOTAL = TOTAL;
            this.SALDO = SALDO;
            this.ESTADO_P = ESTADO_P;
        }
    }
}
