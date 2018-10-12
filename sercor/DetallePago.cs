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
        Pago pago;
        decimal monto;


        public DetallePago(int idPago, bool admin)
        {
            InitializeComponent();

            if (admin == false)
            {
                btnAnular.Enabled = false;
            }

            FormInstance.puntoDecimal();
            pago = PagoDBM.ObtenerPagoIdPago(idPago);

            txtFecha.Text = pago.FECHA_ABONO;
            txtMonto.Text = pago.MONTO.ToString();
            txtDescripcion.Text = pago.DESCRIPCION;
            txtTarjeta.Text = pago.TARJETA;
            txtBanco.Text = pago.BANCO;
            txtCheque.Text = pago.CHEQUE;

            idPago = pago.ID_PAGO;

            if (pago.MONTO == 0)
            {
                btnAnular.Enabled = false;
                txtDescripcion.Text = "ANULADO";
                txtDescripcion.ForeColor = Color.Red;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de anular este pago?", "Sercor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                monto = pago.MONTO;

                PagoDBM.Anular(pago.ID_PAGO);

                CuentaDBM.CuentaAnulacion(pago.ID_CUENTA, CuentaDBM.ObtenerCuentaNporID_cuenta(pago.ID_CUENTA).SALDO+monto);

                MessageBox.Show("Anulación exitosa", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else {
                this.Close();
            }
        }
    }
}
