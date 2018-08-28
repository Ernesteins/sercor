using System.Windows.Forms;

namespace sercor
{
    public partial class detalleForm : Form
    {
        Cliente _cliente = new Cliente();
        Pago _pago = new Pago();
        public detalleForm(Factura _factura)
        {
            InitializeComponent();
            _cliente = ClienteDBM.ObtenerCliente(_factura.ID_CLIENTE, null);
            _pago = PagoDBM.ConsultarUnicoPago(_factura.ID_CUENTA);

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
        }
    }
}
