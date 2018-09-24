using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sercor
{
    public partial class DetallePago : Form
    {
        int idPago;
        Pago pago;
        Cuenta cuentaAnterior;
        public DetallePago(Pago _pago)
        {
            InitializeComponent();
            FormInstance.puntoDecimal();
            pago = _pago;

            cuentaAnterior=CuentaDBM.ObtenerCuentaporID_cuenta(pago.ID_CUENTA);

            txtFecha.Text = _pago.FECHA_ABONO;
            txtMonto.Text = _pago.MONTO.ToString();
            txtDescripcion.Text = _pago.DESCRIPCION;
            txtTarjeta.Text = _pago.TARJETA;
            txtBanco.Text = _pago.BANCO;
            txtCheque.Text = _pago.CHEQUE;

            idPago = _pago.ID_PAGO;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de anular este pago?", "Sercor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Pago anularPago = pago;
                anularPago.MONTO = 0;

                CuentaDBM.actualizarcuenta(pago.ID_CUENTA, cuentaAnterior.SALDO + pago.MONTO, cuentaAnterior.TOTAL);

                PagoDBM.Modificar(anularPago, idPago);
                MessageBox.Show("Anulación exitosa", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
