﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Factura
    {
        public int ID_FACTURA { get; set; }
        public string ID_CLIENTE { get; set; }
        public int ID_USUARIO { get; set; }
        public decimal IVA { get; set; }
        public decimal TOTAL { get; set; }
        public string FECHA { get; set; }


        //Constructor de objeto
        public Factura() { }

        public Factura(int pIdFactura, string pIdCliente, int pIdUsuario, decimal pIva, decimal pTotal, string pFecha)
        {
            this.ID_FACTURA = pIdFactura;
            this.ID_CLIENTE = pIdCliente;
            this.ID_USUARIO = pIdUsuario;
            this.IVA = pIva;
            this.TOTAL = pTotal;
            this.FECHA = pFecha;

        }
    }
}
