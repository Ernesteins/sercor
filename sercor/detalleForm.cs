using System.Windows.Forms;

namespace sercor
{
    public partial class detalleForm : Form
    {
        Cliente _cliente = new Cliente();
        Pago _pago = new Pago();
        Cuenta _cuenta = new Cuenta();
        Detalle _detalle = new Detalle();
        Trabajo _trabajo = new Trabajo();
        Usuario _usuario = new Usuario();
        
        public detalleForm(Factura _factura,bool admin)
        {
            InitializeComponent();

            if (admin == false)
            {
                btnAnular.Enabled = false;
            }

            _cliente = ClienteDBM.ObtenerCliente(_factura.ID_CLIENTE, null);
            _pago = PagoDBM.ConsultarUnicoPago(_factura.ID_CUENTA);
            _cuenta = CuentaDBM.ObtenerCuentaporID_cuenta(_factura.ID_CUENTA);
            _detalle = DetalleDBM.ObtenerDetalle(_factura.ID_DETALLE);
            _trabajo = TrabajoDBM.TrabajoFecha(_factura.ID_FACTURA);
            _usuario = UsuarioDBM.ObtenerUsuario(_factura.ID_USUARIO);

            vistaFactura.DataSource = ProductoVendidoDBM.ObtenerProductosDetalle(_factura.ID_DETALLE);

            txtId.Text = _factura.ID_CLIENTE;
            txtName.Text = _cliente.NOMBRE;
            txtTelefono.Text = _cliente.TELEFONO;
            txtDireccion.Text = _cliente.DIRECCION;
            txtDescuento.Text = _factura.FACTOR_DESCUENTO.ToString();
            txtDate.Text = _factura.FECHA;
            ordenTipo.SelectedIndex = _factura.TIPO;
            lblNumeroFactura.Text = _factura.INDICE.ToString();

            metodoPago.SelectedIndex = _pago.TIPO_PAGO;

            txtTarjeta.Text = _pago.TARJETA;
            txtTipo.Text = _pago.TIPO;
            txtREF.Text = _pago.REF;
            txtBanco.Text = _pago.BANCO;
            txtChque.Text = _pago.CHEQUE;

            decimal a = _detalle.SUBTOTAL * 0.12m;
            txtIva.Text = a.ToString();

            txtTotal.Text = _cuenta.TOTAL.ToString();
            txtSaldo.Text = _cuenta.SALDO.ToString();
            txtSubtotal.Text = _detalle.SUBTOTAL.ToString();

            txtFechaEntrega.Text = _trabajo.FECHA_ENTREGA;
            txtResponsable.Text = _usuario.NOMBRE + " " + _usuario.APELLIDO;

            if (_cuenta.TOTAL == 0){
                txtId.ForeColor = System.Drawing.Color.Red;
                txtName.ForeColor = System.Drawing.Color.Red;
                txtTelefono.ForeColor = System.Drawing.Color.Red;
                txtDireccion.ForeColor = System.Drawing.Color.Red;
                txtDate.ForeColor = System.Drawing.Color.Red;
                txtTotal.ForeColor = System.Drawing.Color.Red;

                txtId.Text = "ANULADO";
                txtName.Text = "ANULADO";
                txtTelefono.Text = "ANULADO";
                txtDireccion.Text = "ANULADO";
                txtDate.Text = "ANULADO";

                btnAnular.Enabled = false;
            }
        }

        private void btnAnular_Click(object sender, System.EventArgs e)
        {
           DialogResult result = MessageBox.Show("¿Está seguro de anular esta factura?","Sercor",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CuentaDBM.actualizarcuenta(_cuenta.ID_CUENTA, 0, 0);
                MessageBox.Show("Anulación exitosa","Sercor",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}