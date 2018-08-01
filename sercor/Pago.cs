using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercor
{
    class Pago
    {
        public int ID_PAGO { get; set; }
        public int ID_CUENTA { get; set; }
        public string FECHA_ABONO { get; set; }
        public int TIPO_PAGO { get; set; }
        public Decimal MONTO { get; set; }
        public string DESCRIPCION { get; set; }

        public Pago() { }
        
        //pago con descripcion
        public Pago(int pID_PAGO, int pID_CUENTA, string FECHA_ABONO, int TIPO_PAGO, Decimal MONTO, string DESCRIPCION)
        {
            this.ID_PAGO = ID_PAGO;
            this.ID_CUENTA = ID_CUENTA;
            this.FECHA_ABONO = FECHA_ABONO;
            this.TIPO_PAGO = TIPO_PAGO;
            this.MONTO = MONTO;
            this.DESCRIPCION = DESCRIPCION;
        }
        //pago sin descripcion, generalmente efectivo
        public Pago(int pID_PAGO, int pID_CUENTA, string FECHA_ABONO, int TIPO_PAGO, Decimal MONTO)
        {
            this.ID_PAGO = ID_PAGO;
            this.ID_CUENTA = ID_CUENTA;
            this.FECHA_ABONO = FECHA_ABONO;
            this.TIPO_PAGO = TIPO_PAGO;
            this.MONTO = MONTO;
        }

    }
}
