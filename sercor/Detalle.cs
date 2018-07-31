using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class Detalle
    {
        public int ID_DETALLE { get; set; }
        public decimal SUBTOTAL { get; set; }

        public Detalle() { }

        public Detalle(int pIdDetalle, decimal pSubtotal)
        {
            this.ID_DETALLE = pIdDetalle;
            this.SUBTOTAL = pSubtotal;
        }

    }
    
}
