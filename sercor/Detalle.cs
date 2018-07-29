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
        public int ID_FACTURA { get; set; }
        public int ID_USUARIO { get; set; }
        public decimal IVA { get; set; }
        public decimal TOTAL { get; set; }
        public string FECHA { get; set; }
        public decimal FACTOR_DESCUENTO { get; set; }
        public decimal VALOR_DESCONTADO { get; set; }
        public int TIPO { get; set; }
        public int INDICE { get; set; }
    }
}
