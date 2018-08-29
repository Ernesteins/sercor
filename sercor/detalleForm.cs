﻿using System.Windows.Forms;

namespace sercor
{
    public partial class detalleForm : Form
    {
        Cliente _cliente = new Cliente();
        Pago _pago = new Pago();
        Cuenta _cuenta = new Cuenta();
        Detalle _detalle = new Detalle();
        Trabajo _trabajo = new Trabajo();
        
        public detalleForm(Factura _factura)
        {
            InitializeComponent();
            _cliente = ClienteDBM.ObtenerCliente(_factura.ID_CLIENTE, null);
            _pago = PagoDBM.ConsultarUnicoPago(_factura.ID_CUENTA);
            _cuenta = CuentaDBM.ObtenerCuentaporID_cuenta(_factura.ID_CUENTA);
            _detalle = DetalleDBM.ObtenerDetalle(_factura.ID_DETALLE);
            _trabajo = TrabajoDBM.TrabajoFecha(_factura.ID_FACTURA);

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
        }
    }
}
