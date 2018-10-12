using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class Egreso
    {
        public int ID_CAJA { get; set; }
        public string FECHA_EGRESO { get; set; }
        public string TIPO_EGRESO { get; set; }
        public decimal MONTO { get; set; }
        public string BENEFICIARIO { get; set; }
        public string DESCRIPCION { get; set; }

        public Egreso() { }

        public Egreso(int iD_CAJA, string fECHA_EGRESO, string tIPO_EGRESO, decimal mONTO, string bENEFICIARIO, string dESCRIPCION)
        {
            ID_CAJA = iD_CAJA;
            FECHA_EGRESO = fECHA_EGRESO;
            TIPO_EGRESO = tIPO_EGRESO;
            MONTO = mONTO;
            BENEFICIARIO = bENEFICIARIO;
            DESCRIPCION = dESCRIPCION;
        }
    }
}
