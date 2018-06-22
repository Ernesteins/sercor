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
    public partial class sercormain : Form
    {
        private void toogleError(bool show, string mensaje, int tipo)
        {
            lblErrors.Visible = true;
            ptcError.Visible = true;
            switch (tipo)
            {
                case 1://TIPO ERROR
                    lblErrors.ForeColor = Color.Maroon;
                    ptcError.BackgroundImage = sercor.Properties.Resources.error16;
                    break;

                case 2://TIPO AVISO
                    lblErrors.ForeColor = Color.FromArgb(255, 128, 0);
                    ptcError.BackgroundImage = sercor.Properties.Resources.alarm16;
                    break;

                case 3:
                    lblErrors.Visible = false;
                    ptcError.Visible = false;
                    break;
            }
            if (show == false)
            {
                lblErrors.Text = "Salida";
            }
            else
            {
                lblErrors.Text = mensaje;
            }
        }

        public Factura ultimoRegistro { get; set; }
        private void ultimoIdFactura()
        {
            ultimoRegistro = FacturaDBM.UltimoID();
            int idUltimoFactura = ultimoRegistro.ID_FACTURA;
            int nuevoIdFactura = idUltimoFactura + 1;
            lblNumeroFactura.Text = Convert.ToString(nuevoIdFactura);
        }

        Form loginPadre;

        //CARGA DATOS DEL USUARIO ACTUAL EN EL FORMULRIO
        public sercormain(Usuario usuario, Form form)
        {
            InitializeComponent();

            menuToggler(1);

            loginPadre = form;

            ultimoIdFactura();

            toogleError(false, "",3);

            autocompleteRefresh();

            dgvProductos.DataSource = ProductoDBM.ObtenerProductos();

            int tipoUser = usuario.TIPO;
            string usuarioUser = usuario.USUARIO;
            string nombreUser = usuario.NOMBRE;
            string apellidoUser = usuario.APELLIDO;
            string cedulaUser = usuario.CEDULA;
            string direccionUser = usuario.DIRECCION;
            string telefonoUser = usuario.TELEFONO;
            int privilegio1User = usuario.PRIVILEGIO1;
            int privilegio2User = usuario.PRIVILEGIO2;

            btnUser.Text = nombreUser + " " + apellidoUser;

            //CARACTERISTICAS SEGUN TIPO DE USUARIO
            switch (tipoUser)
            {
                case 1:
                    btnUser.BackColor = Color.FromArgb(255, 128, 128);
                    break;

                case 2:
                    btnUser.BackColor = Color.FromArgb(255, 192, 128);
                    break;

                case 3:
                    btnUser.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case 4:
                    btnUser.BackColor = Color.FromArgb(128, 128, 255);
                    break;
            }
        }

        //CAMBIO DE MENU
        private void menuToggler(int pnNumber)
        {

            pnVentas.Visible = false;
            pnCxc.Visible = false;
            pnInventario.Visible = false;
            pnReportes.Visible = false;
            pnTrabajos.Visible = false;
            pnMovCaja.Visible = false;

            btnVentas.BackColor = Color.White;
            btnCxc.BackColor = Color.White;
            btnInventario.BackColor = Color.White;
            btnReportes.BackColor = Color.White;
            btnTrabajos.BackColor = Color.White;
            btnMovimientos.BackColor = Color.White;

            btnVentas.ForeColor = Color.FromArgb(64, 64, 64);
            btnCxc.ForeColor = Color.FromArgb(64, 64, 64);
            btnInventario.ForeColor = Color.FromArgb(64, 64, 64);
            btnReportes.ForeColor = Color.FromArgb(64, 64, 64);
            btnMovimientos.ForeColor = Color.FromArgb(64, 64, 64);
            btnTrabajos.ForeColor = Color.FromArgb(64, 64, 64);

            switch (pnNumber)
            {
                case 1: //VENTAS
                    pnVentas.Visible = true;
                    pnVentas.Dock = DockStyle.Fill;

                    btnVentas.BackColor = Color.WhiteSmoke;
                    break;

                case 2: //CXC
                    pnCxc.Visible = true;
                    pnCxc.Dock = DockStyle.Fill;

                    btnCxc.BackColor = Color.WhiteSmoke;
                    break;

                case 3:
                    pnInventario.Visible = true;
                    pnInventario.Dock = DockStyle.Fill;

                    btnInventario.BackColor = Color.WhiteSmoke;
                    break;

                case 4:
                    pnReportes.Visible = true;
                    pnReportes.Dock = DockStyle.Fill;

                    btnReportes.BackColor = Color.WhiteSmoke;
                    break;

                case 5:
                    pnTrabajos.Visible = true;
                    pnTrabajos.Dock = DockStyle.Fill;

                    btnTrabajos.BackColor = Color.WhiteSmoke;
                    break;

                case 6:
                    pnMovCaja.Visible = true;
                    pnMovCaja.Dock = DockStyle.Fill;

                    btnMovimientos.BackColor = Color.WhiteSmoke;
                    break;

                default:
                    break;
            }
        }

        //REFRESCA EL AUTOCOMPLETE DEL CLIENTE
        private void autocompleteRefresh()
        {
            //CARGA EN AUTOCOMPLETE DE ID DESDE BASE DE DATOS
            var clienteNombres = new AutoCompleteStringCollection();
            var clienteId = new AutoCompleteStringCollection();
            
            int j = 0;
            for (int i = 0; i <= ClienteDBM.ObtenerNombres().Count; i++)
            {
                if (j != ClienteDBM.ObtenerNombres().Count)
                {
                    clienteNombres.Add(ClienteDBM.ObtenerNombres()[j].NOMBRE);
                    clienteId.Add(Convert.ToString(ClienteDBM.ObtenerNombres()[j].ID_CLIENTE));
                    j++;
                }
            }
            
            txtId.AutoCompleteCustomSource = clienteId;
        }

        public Cliente clienteNombres { get; set; }

        private void btnVentas_Click(object sender, EventArgs e) {
            menuToggler(1);
        }

        private void btnCxc_Click(object sender, EventArgs e)
        {
            menuToggler(2);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            menuToggler(3);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            menuToggler(4);
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            menuToggler(5);
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            menuToggler(6);
        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

            if (txtId.Text == Convert.ToString(ClienteDBM.ObtenerCliente(txtId.Text, null).ID_CLIENTE))
            {
                txtName.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).NOMBRE;
                txtTelefono.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).TELEFONO;
                txtDireccion.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).DIRECCION;
            }
            else
            {
                txtName.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
            }
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ProductoDBM.ObtenerProductos();

            DataGridViewColumn column = dgvProductos.Columns[0];
            column.Width = 50;

            cmbFiltro.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            vistaFactura.Rows.Clear();

            txtId.Focus();

            restaurador();
            aplicarDescuento();
            toogleError(true,"Nueva factura",2);
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);
            Producto productoSeleccionado = ProductoDBM.ObtenerProductoCod(codigo);

            int filas = vistaFactura.RowCount;
            bool modif = false;
            int k = 0;

            for (int j = 0; j <= filas - 1; j++)
            {
                if (codigo == Convert.ToString(vistaFactura.Rows[j].Cells[0].Value))
                {
                    k = j;
                    modif = true;
                }
            }
            if (modif == false)
            {
                vistaFactura.Rows.Insert(0, productoSeleccionado.COD, productoSeleccionado.DESCRIPCION,
                1, productoSeleccionado.PRECIO, productoSeleccionado.PRECIO);
            }
            else
            {
                ImprimirFactura(k,0,productoSeleccionado);
            }
            subtotal();

        }

        private void ImprimirFactura(int k, int cantidad, Producto productoSeleccionado)
        {
            vistaFactura.Rows[k].Cells[1].Value = productoSeleccionado.DESCRIPCION;
            if (cantidad==0)
            {
                vistaFactura.Rows[k].Cells[2].Value = Convert.ToInt32(vistaFactura.Rows[k].Cells[2].Value) + 1;
            }
            else
            {
                vistaFactura.Rows[k].Cells[2].Value = cantidad;
            }
            vistaFactura.Rows[k].Cells[3].Value = productoSeleccionado.PRECIO;
            vistaFactura.Rows[k].Cells[4].Value = productoSeleccionado.PRECIO * Convert.ToInt32(vistaFactura.Rows[k].Cells[2].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            toogleError(false, "",3);
            try
            {
                if (txtAdd.Text == "")
                {
                    txtAdd.Text = "0";
                }
                if (Convert.ToInt32(txtAdd.Text) <= 0)
                {
                    toogleError(true, "Debe ingresar un número mayor a 0",1);
                }
                else
                {
                    string codigo = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);
                    Producto productoSeleccionado = ProductoDBM.ObtenerProductoCod(codigo);
                    int cantidad = Convert.ToInt32(txtAdd.Text);

                    int filas = vistaFactura.RowCount;
                    bool modif = false;
                    int k = 0;

                    for (int j = 0; j <= filas - 1; j++)
                    {
                        if (codigo == Convert.ToString(vistaFactura.Rows[j].Cells[0].Value))
                        {
                            k = j;
                            modif = true;
                        }
                    }
                    if (modif == false)
                    {
                        vistaFactura.Rows.Insert(0, productoSeleccionado.COD, productoSeleccionado.DESCRIPCION,
                        cantidad, productoSeleccionado.PRECIO, productoSeleccionado.PRECIO);
                    }
                    ImprimirFactura(k, cantidad, productoSeleccionado);
                }
                
            }
            catch (System.FormatException)
            {
                toogleError(true, "Debe ingresar un número",1);
            }
            subtotal();
        }
        
        //FUNCION RESTAURADORA DE PRECIOS
        private void restaurador()
        {

            int filas = vistaFactura.RowCount;

            for (int j = 0; j <= filas - 1; j++)
            {

                vistaFactura.Rows[j].Cells[3].Value = ((float.Parse(Convert.ToString(vistaFactura.Rows[j].Cells[3].Value))) / (1-factorDescuento));
                vistaFactura.Rows[j].Cells[4].Value = float.Parse(vistaFactura.Rows[j].Cells[3].Value.ToString()) * float.Parse(vistaFactura.Rows[j].Cells[2].Value.ToString());
            }
            subtotal();
            factorDescuento = 0;
        }

        float factorDescuento;

        private void Multiplicador()
        {
                    int filas = vistaFactura.RowCount;

                    subtotal();
                    factorDescuento = Calculo_FactorDescuento(float.Parse(txtDescuento.Text), float.Parse(txtTotal.Text)
                        , float.Parse(txtSubtotal.Text), ivaConst);

                    for (int j = 0; j <= filas - 1; j++)
                    {

                        vistaFactura.Rows[j].Cells[3].Value = ((float.Parse(Convert.ToString(vistaFactura.Rows[j].Cells[3].Value))) - (float.Parse(Convert.ToString(vistaFactura.Rows[j].Cells[3].Value)) * (factorDescuento)));
                        vistaFactura.Rows[j].Cells[4].Value = float.Parse(vistaFactura.Rows[j].Cells[3].Value.ToString()) * float.Parse(vistaFactura.Rows[j].Cells[2].Value.ToString());
                    }

                    subtotal();
        }

        bool togDescuento = true;//Habilita el boton de descuento True = habilitar

        private void aplicarDescuento() {
            toogleError(false, "", 3);
            try
            {
                if (txtDescuento.Text == "")
                {
                    txtDescuento.Text = "0";
                    toogleError(true, "Ingrese un número mayor a 0", 1);
                }

                string descuentito = txtDescuento.Text;
                txtDescuento.Text = descuentito.Replace(".", ",");

                if (float.Parse(txtDescuento.Text) >= float.Parse(txtTotal.Text) * 0.9)
                {
                    toogleError(true, "El descuento no debe ser mayor al 90% del total actual", 1);
                }
                else
                {
                    if (togDescuento == true)
                    {
                        Multiplicador();

                        btnDescuento.Text = "Cancelar";
                        btnDescuento.ForeColor = Color.Maroon;

                        //UNA VEZ APLICADO EL DESCUENTO, NO SE PUEDE AGREGAR PRODUCTOS A MENOS UE CANCELE
                        txtDescuento.Enabled = false;
                        btnAdd.Enabled = false;
                        txtAdd.Enabled = false;
                        dgvProductos.Enabled = false;
                        vistaFactura.Enabled = false;

                        togDescuento = false;
                        toogleError(true, "Descuento aplicado", 2);
                    }
                    else
                    {
                        btnDescuento.Text = "Descontar";
                        btnDescuento.ForeColor = Color.FromArgb(64, 64, 64);

                        txtDescuento.Enabled = true;
                        btnAdd.Enabled = true;
                        txtAdd.Enabled = true;
                        dgvProductos.Enabled = true;
                        vistaFactura.Enabled = true;

                        togDescuento = true;

                        restaurador();
                    }
                }
            }
            catch (System.FormatException)
            {
                toogleError(true, "Debe ingresar un número", 1);
            }
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            aplicarDescuento();
        }

        float ivaConst = 0.12F;

        private void subtotal()
        {
            string codigo = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);

            int filas = vistaFactura.RowCount;

            float subtotal = 0;
           
            float iva;
            float total;

            for (int j = 0; j <= filas - 1; j++)
            {
                subtotal = subtotal + float.Parse(Convert.ToString(vistaFactura.Rows[j].Cells[4].Value));
            }

            txtSubtotal.Text = Decimal.Round(Convert.ToDecimal(subtotal), 2).ToString("0.00");
            iva = ivaConst * subtotal;
            txtIva.Text = Decimal.Round(Convert.ToDecimal(iva), 2).ToString("0.00");
            total = subtotal + iva;

            //trocito clave
            //decimal total2 = Decimal.Round(Convert.ToDecimal(total), 2) ;

            txtTotal.Text = Decimal.Round(Convert.ToDecimal(total), 2).ToString("0.00");

        }

        private float  Calculo_FactorDescuento(float descuento,float total_inicial,float subtotal_inicial,float iva)
        {
            float factorDescuento = 0;
            factorDescuento = 1 + (((descuento - total_inicial) / (1 + iva)) / subtotal_inicial);
            return (factorDescuento);
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductosFiltro(cmbFiltro.SelectedIndex);
        }

        private void ProductosFiltro(int filtroIndex)
        {
            var pFiltroCod = new AutoCompleteStringCollection();
            var pFiltroName = new AutoCompleteStringCollection();
            var pFiltroDes = new AutoCompleteStringCollection();
            var pFiltroCat = new AutoCompleteStringCollection();
            var pFiltroSubCat = new AutoCompleteStringCollection();

            int j = 0;

            for (int i = 0; i <= ProductoDBM.ObtenerProductos().Count; i++)
            {
                if (j != ProductoDBM.ObtenerProductos().Count)
                {
                    pFiltroCod.Add(ProductoDBM.ObtenerProductos()[j].COD);
                    pFiltroName.Add(ProductoDBM.ObtenerProductos()[j].NOMBRE);
                    pFiltroDes.Add(ProductoDBM.ObtenerProductos()[j].DESCRIPCION);
                    pFiltroCat.Add(ProductoDBM.ObtenerProductos()[j].CATEGORIA);
                    pFiltroSubCat.Add(ProductoDBM.ObtenerProductos()[j].SUBCATEGORIA);

                    j++;
                }
            }


            switch (filtroIndex)
            {
                case 0://POR CODIGO
                    txtProducto.Enabled = true;
                    txtProducto.AutoCompleteCustomSource = pFiltroCod;
                    break;

                case 1://POR NOMBRE
                    txtProducto.Enabled = true;
                    txtProducto.AutoCompleteCustomSource = pFiltroName;
                    break;

                case 2://POR DESCRIPCION
                    txtProducto.Enabled = true;
                    txtProducto.AutoCompleteCustomSource = pFiltroDes;
                    break;

                case 3://POR CATEGORIA
                    txtProducto.Enabled = true;
                    txtProducto.AutoCompleteCustomSource = pFiltroCat;
                    break;

                case 4://POR SUBCATEGORIA
                    txtProducto.Enabled = true;
                    txtProducto.AutoCompleteCustomSource = pFiltroSubCat;
                    break;
            }
        }

        private void sercormain_FormClosed(object sender, FormClosedEventArgs e)

        {
            loginPadre.Enabled = true;
        }

        //PONER AQUI TODO LO RELACIONADO CON CUENTAS POR COBRAR

    }
}