using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    public class Trabajo
    {
        public int ID { get; set; }
        public int CUENTA { get; set; }
        public int FACTURA { get; set; }
        public string FECHA_INICIO { get; set; }
        public string FECHA_ENTREGA { get; set; }
        public string NOMBRE { get; set; }
        public string ARMAZON { get; set; }
        public string LUNA { get; set; }
        public int ESTADO { get; set; }

        public Trabajo() { }

        public Trabajo(int trID, int trCUENTA, int trFACTURA, string trFECHA_INICIO,
            string trFECHA_ENTREGA, string trNOMBRE, string trARMAZON, string trLUNA, int trESTADO)
        {
            this.ID = trID;
            this.CUENTA = trCUENTA;
            this.FACTURA = trFACTURA;
            this.FECHA_INICIO = trFECHA_INICIO;
            this.FECHA_ENTREGA = trFECHA_ENTREGA;
            this.NOMBRE = trNOMBRE;
            this.ARMAZON = trARMAZON;
            this.LUNA = trLUNA;
            this.ESTADO = trESTADO;
        }
    }
}
