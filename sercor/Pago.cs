using System;

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
        public string TARJETA { get; set; }
        public string TIPO { get; set; }
        public string REF { get; set; }
        public string BANCO { get; set; }
        public string CHEQUE { get; set; }

        public Pago() { }

        //pago con tarjeta
        public Pago(int pID_PAGO, int pID_CUENTA, string pFECHA_ABONO, int pTIPO_PAGO, Decimal pMONTO, string pDESCRIPCION, string pTARJETA, string pTIPO, string pREF)
        {
            this.ID_PAGO = pID_PAGO;
            this.ID_CUENTA = pID_CUENTA;
            this.FECHA_ABONO = pFECHA_ABONO;
            this.TIPO_PAGO = pTIPO_PAGO;
            this.MONTO = pMONTO;
            this.DESCRIPCION = pDESCRIPCION;
            this.TARJETA = pTARJETA;
            this.TIPO = pTIPO;
            this.REF = pREF;
            this.BANCO = null;
            this.CHEQUE = null;
        }

        //pago con efectivo
        public Pago(int pID_PAGO, int pID_CUENTA, string pFECHA_ABONO, int pTIPO_PAGO, Decimal pMONTO, string pDESCRIPCION)
        {
            this.ID_PAGO = pID_PAGO;
            this.ID_CUENTA = pID_CUENTA;
            this.FECHA_ABONO = pFECHA_ABONO;
            this.TIPO_PAGO = pTIPO_PAGO;
            this.MONTO = pMONTO;
            this.DESCRIPCION = pDESCRIPCION;
            this.TARJETA = null;
            this.TIPO = null;
            this.REF = null;
            this.BANCO = null;
            this.CHEQUE = null;
        }
        //pago con cheque
        public Pago(int pID_PAGO, int pID_CUENTA, string pFECHA_ABONO, int pTIPO_PAGO, Decimal pMONTO, string pDESCRIPCION, string pBANCO, string pCHEQUE)
        {
            this.ID_PAGO = pID_PAGO;
            this.ID_CUENTA = pID_CUENTA;
            this.FECHA_ABONO = pFECHA_ABONO;
            this.TIPO_PAGO = pTIPO_PAGO;
            this.MONTO = pMONTO;
            this.DESCRIPCION = pDESCRIPCION;
            this.TARJETA = null;
            this.TIPO = null;
            this.REF = null;
            this.BANCO = pBANCO;
            this.CHEQUE = pCHEQUE;
        }

    }
    class PagoReporte
    {
        public string FECHA_ABONO { get; set; }
        public Decimal MONTO { get; set; }
        public string DESCRIPCION { get; set; }

        public PagoReporte() { }

        //pago con tarjeta
        public PagoReporte(string pFECHA_ABONO, Decimal pMONTO, string pDESCRIPCION)
        {
            this.FECHA_ABONO = pFECHA_ABONO;
            this.MONTO = pMONTO;
            this.DESCRIPCION = pDESCRIPCION;
        }
    }
}
