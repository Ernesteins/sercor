using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace sercor
{
    public partial class sercormain : Form
    {
        //MUESTRA MENSAJES DES ERROR O NOTIFICACIONES
        private void toogleError(bool show, string mensaje, int tipo)//mostrar|mensaje a mostrar|1=error 2=aviso
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

        private int ultimoIdFactura()//ultimo id de factura
        {
            ultimoRegistro = FacturaDBM.UltimoID();
            return ultimoRegistro.ID_FACTURA;
        }

        Form loginPadre;
        int IDUser;

        //CARGA DATOS DEL USUARIO ACTUAL EN EL FORMULRIO
        public sercormain(Usuario usuario, Form form, bool[] _privilegio1, bool[] _privilegio2)
        {
            InitializeComponent();

            //IMPORTANTE
            FormInstance.puntoDecimal();

            dtpEntrega.MinDate = DateTime.Today;

            menuToggler(1);

            loginPadre = form;

            toogleError(false, "", 3);

            autocompleteRefresh();

            metodoDePago(0);

            ordenTipo.SelectedIndex = 0;
            metodoPago.SelectedIndex = 0;

            btnAllProducts_Click(null, null);

            reporteElementos();

            IDUser = usuario.ID_USUARIO;
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

            //0 Adminitracion
            //1 Inventario
            //2 Movimiento
            //3 Reportes

            //0 Ventas 
            //1 Cuentas
            //2 Trabajos
            //3 Fecha factura

            if (_privilegio1[0] == false)
            {
                btnAdmin.Enabled = false;
            }
            if (_privilegio1[1] == false)
            {
                pnInventario.Enabled = false;
            }
            if (_privilegio1[2] == false)
            {
                pnMovCaja.Enabled = false;
            }
            if (_privilegio1[3] == false)
            {
                pnReportes.Enabled = false;
            }

            if (_privilegio2[0] == false)
            {
                pnVentas.Enabled = false;
            }
            if (_privilegio2[1] == false)
            {
                pnCxc.Enabled = false;
            }
            if (_privilegio2[2] == false)
            {
                pnTrabajos.Enabled = false;
            }
            if (_privilegio2[3] == false)
            {
                dateTime.Enabled = false;
            }


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
            cmbTipo.SelectedIndex = 0;
            cmbTipocxc.SelectedIndex = 0;
            cmbEstadocxc.SelectedIndex = 0;
            metodoPagocxc.SelectedIndex = 0;
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
            llenarcxc();

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            menuToggler(3);
            btnTodosInventario_Click(null, null);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            menuToggler(4);
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            menuToggler(5);
            btnTodosTrabajo_Click(null, null);
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            menuToggler(6);
            llenareportes();
        }

        //Funcion de llenado de reportes
        private void llenareportes()
        {
            dtpReporte.Value = System.DateTime.Today;
            dtpReportefin.Value = System.DateTime.Now;
            String inicio = dtpReporte.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String fin = dtpReportefin.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dgvEgresos.DataSource = EgresoDBM.ReporteEgresosFecha(inicio, fin);
            dgvIngresos.DataSource = PagoDBM.ObtenerPagosFecha(inicio, fin);
        }

        //FUNCION RESTAURADORA DE PRECIOS
        private void restaurador()
        {

            int filas = vistaFactura.RowCount;

            for (int j = 0; j <= filas - 1; j++)
            {

                vistaFactura.Rows[j].Cells[3].Value = ((float.Parse(Convert.ToString(vistaFactura.Rows[j].Cells[3].Value))) / (1 - factorDescuento));
                vistaFactura.Rows[j].Cells[4].Value = float.Parse(vistaFactura.Rows[j].Cells[3].Value.ToString()) * float.Parse(vistaFactura.Rows[j].Cells[2].Value.ToString());
            }
            subtotal();
            factorDescuento = 0;
        }

        float factorDescuento;

        private void Multiplicador()//aplica descuento
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

        //IVA
        //-------------------------------------
        float ivaConst = 0.12F;//constante iva

        //-------------------------------------


        private void subtotal()//calculo de subtotal
        {
            try
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
                calculaSaldo();
            }
            catch (System.NullReferenceException) {
                MessageBox.Show("No existen productos", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void calculaSaldo()
        {
            string abonito = txtAbono.Text;
            txtAbono.Text = abonito.Replace(",", ".");
            decimal Dtotal = Convert.ToDecimal(txtTotal.Text);
            decimal Dabono = 0;
            Dabono = Convert.ToDecimal(txtAbono.Text);
            decimal DSaldo = Dtotal - Dabono;
            txtSaldo.Text = Decimal.Round(DSaldo, 2).ToString("0.00");
        }

        protected float Calculo_FactorDescuento(float descuento, float total_inicial, float subtotal_inicial, float iva)//calcula el factor de descuento
        {
            float factorDescuento = 0;
            factorDescuento = 1 + (((descuento - total_inicial) / (1 + iva)) / subtotal_inicial);
            return (factorDescuento);
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductosFiltro(cmbFiltro.SelectedIndex, txtProducto);
        }

        //FILTRO DE BUSQUEDA
        private void ProductosFiltro(int filtroIndex, TextBox txtBusqueda)
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
                    txtBusqueda.Enabled = true;
                    txtBusqueda.AutoCompleteCustomSource = pFiltroCod;
                    break;

                case 1://POR NOMBRE
                    txtBusqueda.Enabled = true;
                    txtBusqueda.AutoCompleteCustomSource = pFiltroName;
                    break;

                case 2://POR DESCRIPCION
                    txtBusqueda.Enabled = true;
                    txtBusqueda.AutoCompleteCustomSource = pFiltroDes;
                    break;

                case 3://POR CATEGORIA
                    txtBusqueda.Enabled = true;
                    txtBusqueda.AutoCompleteCustomSource = pFiltroCat;
                    break;

                case 4://POR SUBCATEGORIA
                    txtBusqueda.Enabled = true;
                    txtBusqueda.AutoCompleteCustomSource = pFiltroSubCat;
                    break;

                case 5://ARMAZONES

                    break;

                case 6://LUNAS

                    break;
            }
        }

        private void sercormain_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPadre.Enabled = true;
        }

        private List<Producto> buscarFiltro(int index, TextBox _busqueda) {
            List<Producto> filtrado = null;
            switch (index)
            {
                case 0://CODIGO
                    filtrado = ProductoDBM.ObtenerPorFiltro(_busqueda.Text, null, null, null, null);
                    break;

                case 1:
                    filtrado = ProductoDBM.ObtenerPorFiltro(null, _busqueda.Text, null, null, null);
                    break;

                case 2:
                    filtrado = ProductoDBM.ObtenerPorFiltro(null, null, _busqueda.Text, null, null);
                    break;

                case 3:
                    filtrado = ProductoDBM.ObtenerPorFiltro(null, null, null, _busqueda.Text, null);
                    break;

                case 4:
                    filtrado = ProductoDBM.ObtenerPorFiltro(null, null, null, null, _busqueda.Text);
                    break;
            }
            return filtrado;
        }
        /////////////////
        //MODULO VENTAS//
        ////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = buscarFiltro(cmbFiltro.SelectedIndex, txtProducto);
        }



        private void metodoDePago(int index)//Para metodo de pago
        {

            txtTarjeta.Enabled = false;
            txtTarjetacxc.Enabled = false;
            txtRef.Enabled = false;
            txtRefcxc.Enabled = false;
            cmbTipo.Enabled = false;
            cmbTipocxc.Enabled = false;
            txtCheque.Enabled = false;
            txtChequecxc.Enabled = false;
            txtBanco.Enabled = false;
            txtBancocxc.Enabled = false;

            switch (index)
            {
                case 0:
                    //nada
                    break;

                case 1:
                    txtTarjeta.Enabled = true;
                    txtTarjetacxc.Enabled = true;
                    txtRef.Enabled = true;
                    txtRefcxc.Enabled = true;
                    cmbTipo.Enabled = true;
                    cmbTipocxc.Enabled = true;
                    break;

                case 2:
                    txtCheque.Enabled = true;
                    txtChequecxc.Enabled = true;
                    txtBanco.Enabled = true;
                    txtBancocxc.Enabled = true;
                    break;
            }
        }

        private void metodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodoDePago(metodoPago.SelectedIndex);
        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

            if (txtId.Text == Convert.ToString(ClienteDBM.ObtenerCliente(txtId.Text, null).ID_CLIENTE))
            {
                txtName.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).NOMBRE;
                txtTelefono.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).TELEFONO;
                txtDireccion.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).DIRECCION;

                dgvHistorial.DataSource = FacturaDBM.Historial(txtId.Text);
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
            metodoDePago(0);

            txtId.Text = "";
            txtName.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            vistaFactura.Rows.Clear();

            txtId.Focus();

            restaurador();
            aplicarDescuento();
            toogleError(true, "Nueva factura", 2);
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                    if (productoSeleccionado.EXISTENCIA==0)
                    {
                        toogleError(true, "Producto agotado", 2);
                    }
                    else
                    {
                        vistaFactura.Rows.Insert(0, productoSeleccionado.COD, productoSeleccionado.DESCRIPCION,1, productoSeleccionado.PRECIO, productoSeleccionado.PRECIO);
                    }
                }
                else
                {
                    ImprimirFactura(k, 0, productoSeleccionado);
                }
                subtotal();
            }
            catch (System.NullReferenceException)
            {
                toogleError(true, "No hay productos para agregar", 2);
            }
        }

        private void ImprimirFactura(int k, int cantidad, Producto productoSeleccionado)
        {
            vistaFactura.Rows[k].Cells[1].Value = productoSeleccionado.DESCRIPCION;
            if (cantidad == 0)
            {
                if (productoSeleccionado.EXISTENCIA==Convert.ToInt32(vistaFactura.Rows[k].Cells[2].Value))
                {
                    toogleError(true, "No hay suficiente stock", 2);
                }
                else
                {
                    vistaFactura.Rows[k].Cells[2].Value = Convert.ToInt32(vistaFactura.Rows[k].Cells[2].Value) + 1;
                }
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
            toogleError(false, "", 3);
            try
            {
                if (txtAdd.Text == "")
                {
                    txtAdd.Text = "0";
                }
                if (Convert.ToInt32(txtAdd.Text) <= 0)
                {
                    toogleError(true, "Debe ingresar un número mayor a 0", 1);
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
                        if (cantidad>productoSeleccionado.EXISTENCIA)
                        {
                            toogleError(true, "No hay suficiente stock", 2);
                        }
                        else
                        {
                            vistaFactura.Rows.Insert(0, productoSeleccionado.COD, productoSeleccionado.DESCRIPCION,
                            cantidad, productoSeleccionado.PRECIO, productoSeleccionado.PRECIO);
                        }
                    }
                    if (cantidad>productoSeleccionado.EXISTENCIA)
                    {
                        toogleError(true, "No hay suficiente stock", 2);
                    }
                    else
                    {
                        ImprimirFactura(k, cantidad, productoSeleccionado);
                    }

                    
                }

            }
            catch (System.FormatException)
            {
                toogleError(true, "Debe ingresar un número", 1);
            }
            subtotal();
        }

        bool togDescuento = true;//Habilita el boton de descuento True = habilitar

        //DESCUENTO
        //-----------------
        float desc = 0.9F;
        //-----------------

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
                txtDescuento.Text = descuentito.Replace(",", ".");


                if (togDescuento == true)
                {
                    if (float.Parse(txtDescuento.Text) >= float.Parse(txtTotal.Text) * desc)
                    {
                        toogleError(true, "El descuento no debe ser mayor al 90% del total actual", 1);
                    }
                    else
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
            catch (System.FormatException)
            {
                toogleError(true, "Debe ingresar un número", 1);
            }
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            aplicarDescuento();
        }

        //////////////////////
        //CUENTAS POR COBRAR//
        //////////////////////


        /////////////////////
        //MODULO INVENTARIO//
        /////////////////////
        private void btnTodosInventario_Click(object sender, EventArgs e)
        {
            dgvInventario.DataSource = ProductoDBM.ObtenerProductos();
            cbmFiltroInventario.SelectedIndex = 0;
        }

        private void cbmFiltroInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductosFiltro(cbmFiltroInventario.SelectedIndex, txtBusquedaInventario);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            agregar_producto agregarProducto = new agregar_producto();
            agregarProducto.ShowDialog();

            toogleError(true, agregarProducto.mensaje, 2);

            btnTodosInventario_Click(null, null);
            btnAllProducts_Click(null, null);
        }

        private void btnBusquedaInventario_Click(object sender, EventArgs e)
        {
            dgvInventario.DataSource = buscarFiltro(cbmFiltroInventario.SelectedIndex, txtBusquedaInventario);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modificarProducto();
        }

        private void modificarProducto()
        {
            try
            {
                string codigo = Convert.ToString(dgvInventario.CurrentRow.Cells[0].Value);
                Producto productoSeleccionado = ProductoDBM.ObtenerProductoCod(codigo);

                editar_producto editarProducto = new editar_producto(productoSeleccionado);
                editarProducto.ShowDialog();

                toogleError(true, editarProducto.mensaje, 2);

                btnTodosInventario_Click(null, null);
                btnAllProducts_Click(null, null);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No existen productos para modificar", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modificarProducto();
        }

        /////////////////////
        ///MODULO TRABAJOS///
        /////////////////////

        private void btnTodosTrabajo_Click(object sender, EventArgs e)
        {
            dgvTrabajos.DataSource = TrabajoDBM.ObtenerTrabajos();
            cbmFiltroInventario.SelectedIndex = 0;
        }

        private void cmbFiltroTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrabajosFiltro(cbmFiltroInventario.SelectedIndex, txtBusquedaTrabajo);
            btnBusquedaTrabajo.Enabled = true;
        }
        //FILTRO DE TRABAJOS

        private void TrabajosFiltro(int filtroIndex, TextBox txtBusqueda)
        {
            var tFiltroFactura = new AutoCompleteStringCollection();
            var tFiltroEstado = new AutoCompleteStringCollection();

            int j = 0;

            for (int i = 0; i <= TrabajoDBM.ObtenerTrabajos().Count; i++)
            {
                if (j != TrabajoDBM.ObtenerTrabajos().Count)
                {
                    tFiltroFactura.Add(TrabajoDBM.ObtenerTrabajos()[j].ID.ToString());
                    tFiltroEstado.Add(TrabajoDBM.ObtenerTrabajos()[j].ESTADO.ToString());

                    j++;
                }
            }

            switch (filtroIndex)
            {
                case 0://POR FACTURA
                    txtBusqueda.Enabled = true;
                    txtBusqueda.AutoCompleteCustomSource = tFiltroFactura;
                    break;
                case 1://POR ESTADO 
                    txtBusqueda.Enabled = true;
                    txtBusqueda.AutoCompleteCustomSource = tFiltroEstado;
                    break;

            }
        }

        private void btnBusquedaTrabajo_Click(object sender, EventArgs e)
        {
            try { dgvTrabajos.DataSource = buscarFiltrotr(cmbFiltroTrabajo.SelectedIndex, txtBusquedaTrabajo);
                toogleError(false, null, 1);
            } catch (FormatException) { toogleError(true, "NO HAY VALORES QUE BUSCAR", 2); }

        }

        private List<Trabajo> buscarFiltrotr(int index, TextBox _busqueda)
        {
            List<Trabajo> filtrado = null;
            switch (index)
            {
                case 0://ID
                    //MessageBox.Show(string.Format ("ID de búsqueda = {0}",_busqueda.Text));
                    filtrado = TrabajoDBM.ObtenerPorFiltro(0, 0, Convert.ToInt32(_busqueda.Text), null, null, null, null, null, 1);
                    break;

                case 1://ESTADO
                    //MessageBox.Show(string.Format ("Estado de busqueda = {0}", _busqueda.Text));
                    filtrado = TrabajoDBM.ObtenerPorFiltro(0, 0, 0, null, null, null, null, null, Convert.ToInt32(_busqueda.Text));
                    break;
            }
            return filtrado;
        }

        private void txtBusquedaTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esNumero(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void cambiarEstadoTr()
        {
            try
            {
                int codigo = Convert.ToInt32(dgvTrabajos.CurrentRow.Cells[0].Value);
                Trabajo productoSeleccionado = TrabajoDBM.TrabajoID(codigo);

                cambiar_estado cambiarEstadoTrabajo = new cambiar_estado(productoSeleccionado);
                cambiarEstadoTrabajo.ShowDialog();
                toogleError(true, cambiarEstadoTrabajo.mensaje, 2);

                btnTodosTrabajo_Click(null, null);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No existen trabajos para modificar", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnModificarTrabajo_Click(object sender, EventArgs e)
        {
            cambiarEstadoTr();
        }
        ///////////////
        ///CONTROLES///
        ///////////////

        //FUNCION DE ACEPTAR SOLO NUMEROS
        public bool esNumero(Char c)
        {
            if (Char.IsDigit(c) || Char.IsControl(c))
            {
                return false;
            }
            return true;
        }
        //FIN FUNCION
        //FUNCION DE ACEPTAR DINERO
        public bool esDinero(Char c)
        {
            if (Char.IsDigit(c) || Char.IsControl(c) || c == '.' || c == ',')
            {
                return false;
            }
            return true;
        }
        //FIN FUNCION

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esNumero(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esNumero(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esDinero(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esDinero(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public Factura ultimoIndex { get; set; }

        private int ultimoIndice(int tipo)
        {
            ultimoIndex = FacturaDBM.UltimoIndice(tipo);
            return ultimoIndex.INDICE;
        }

        private void limpiaformfactura()
        {
            vistaFactura.Rows.Clear();
            txtId.Text = "";
            txtName.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            ordenTipo.SelectedIndex = 0;
            metodoPago.SelectedIndex = 0;
            txtSubtotal.Text = "0.00";
            txtIva.Text = "0.00";
            txtTotal.Text = "0.00";
            txtAbono.Text = "0.00";
            txtSaldo.Text = "0.00";
            txtDescuento.Text = "0.00";
            aplicarDescuento();
        }

        //primero se crea el CLiente 
        //luego la cuenta 
        //luego el detalle (con sus productos) 
        //y finalmente la factura.

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                //Variable de cliente
                Cliente nCliente = new Cliente();
                nCliente.ID_CLIENTE = txtId.Text;
                nCliente.NOMBRE = txtName.Text;
                nCliente.DIRECCION = txtDireccion.Text;
                nCliente.TELEFONO = txtTelefono.Text;

                if (nCliente.ID_CLIENTE != null)
                {
                    if (!ClienteDBM.ExisteCliente(txtId.Text))
                    {
                        ClienteDBM.Agregar(nCliente);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no especificado", "sercor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Variable de Detalle
                Detalle nDetalle = new Detalle();
                nDetalle.ID_DETALLE = DetalleDBM.UltimoDetalle() + 1;
                nDetalle.SUBTOTAL = Convert.ToDecimal(txtSubtotal.Text);
                DetalleDBM.Agregar(nDetalle);

                //Variable de cuenta
                Cuenta nCuenta = new Cuenta();
                nCuenta.ID_CUENTA = CuentaDBM.ultimacuenta() + 1;
                nCuenta.ID_CLIENTE = txtId.Text;
                
                nCuenta.TOTAL = Convert.ToDecimal(txtTotal.Text);
                nCuenta.SALDO = nCuenta.TOTAL;
                if(decimal.Parse(txtAbono.Text)== decimal.Parse(txtTotal.Text))
                {
                    nCuenta.ESTADO_P = 1;
                }
                else
                {
                    nCuenta.ESTADO_P = 0;
                }

                /*nCuenta.TOTAL = nCuenta.TOTAL + CuentaDBM.ultimototal(nCuenta.ID_CUENTA);
                nCuenta.SALDO = nCuenta.SALDO + CuentaDBM.consultarsaldo(nCuenta.ID_CUENTA);
                CuentaDBM.actualizarcuenta(nCuenta.ID_CUENTA, nCuenta.SALDO, nCuenta.TOTAL);*/

                //Variable de Factura y fin creacion de cuenta
                Factura nFactura = new Factura();
                nFactura.ID_FACTURA = Convert.ToInt32(ultimoIdFactura() + 1);
                nFactura.ID_CLIENTE = txtId.Text;
                nFactura.ID_USUARIO = Convert.ToInt32(IDUser);
                nFactura.ID_DETALLE = nDetalle.ID_DETALLE;

                nCuenta.ID_FACTURA = nFactura.ID_FACTURA;
                CuentaDBM.Agregar(nCuenta);

                nFactura.ID_CUENTA = nCuenta.ID_CUENTA;
                nFactura.IVA = Convert.ToDecimal(txtIva.Text);
                nFactura.TOTAL = Convert.ToDecimal(txtTotal.Text);
                nFactura.FECHA = dateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                nFactura.FACTOR_DESCUENTO = Convert.ToDecimal(factorDescuento);
                nFactura.VALOR_DESCONTADO = Convert.ToDecimal(txtDescuento.Text);
                nFactura.TIPO = ordenTipo.SelectedIndex;
                nFactura.INDICE = ultimoIndice(ordenTipo.SelectedIndex) + 1;
                FacturaDBM.Agregar(nFactura);

                //variable de Producto vendido (repetir)             
                for (int i = 0; i < vistaFactura.Rows.Count; i++)
                {
                    ProductoVendido nProducto = new ProductoVendido();

                    string codigoInventario = vistaFactura.Rows[i].Cells[0].Value.ToString();

                    Producto productoInventario = new Producto();
                    productoInventario = ProductoDBM.ObtenerProductoCod(codigoInventario);
                    nProducto.COD = ProductoVendidoDBM.ObtenerUltimoProducto().COD + 1;
                    nProducto.ID_DETALLE = nDetalle.ID_DETALLE;
                    nProducto.ID_PRODUCTOINVENTARIO = codigoInventario;
                    nProducto.NOMBRE = ProductoDBM.ObtenerProductoCod(nProducto.ID_PRODUCTOINVENTARIO.ToString()).NOMBRE;
                    nProducto.DESCRIPCION = vistaFactura.Rows[i].Cells[1].Value.ToString();
                    nProducto.CATEGORIA = productoInventario.CATEGORIA;
                    nProducto.SUBCATEGORIA = productoInventario.SUBCATEGORIA;
                    nProducto.PRECIO = Convert.ToDecimal(vistaFactura.Rows[i].Cells[3].Value);
                    nProducto.CANTIDAD = Convert.ToInt32(vistaFactura.Rows[i].Cells[2].Value);
                    ProductoVendidoDBM.Agregar(nProducto);

                    Registro nRegistro = new Registro();
                    nRegistro.IDREGISTRO = RegistroDBM.UltimoRegistro() + 1;
                    nRegistro.FECHA = FacturaDBM.obtenerFechaSistema();
                    nRegistro.ID_PRODUCTO_V = nProducto.COD.ToString();
                    nRegistro.CANTIDAD = nProducto.CANTIDAD;
                    RegistroDBM.Agregar(nRegistro);
                    ProductoDBM.ActualizarStock(ProductoDBM.ObtenerProductoCod(codigoInventario).EXISTENCIA-nProducto.CANTIDAD, codigoInventario);
                }

                //variable de Trabajo (repetir)
                Boolean analizartrabajo = false;
                int cantidadluna = 0;
                int cantidadarmazon = 0;
                int cantidadlunainterna = 0;
                int cantidadarmazoninterna = 0;
                while (analizartrabajo!=true)
                {
                    Trabajo nTrabajo = new Trabajo();
                    int contador = 0;
                    nTrabajo.ID = TrabajoDBM.ultimoTrabajo() + 1;
                    nTrabajo.FACTURA = nFactura.ID_FACTURA;
                    nTrabajo.CUENTA = nCuenta.ID_CUENTA;
                    nTrabajo.FECHA_INICIO = nFactura.FECHA;
                    nTrabajo.NOMBRE = txtName.Text;
                    nTrabajo.ESTADO = 0;
                    nTrabajo.FECHA_ENTREGA = dtpEntrega.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    for (int i = contador; i < vistaFactura.Rows.Count; i++)
                    {
                        string codigoInventario = vistaFactura.Rows[i].Cells[0].Value.ToString();
                        
                        if (ProductoVendidoDBM.productoArmazon(codigoInventario) == true && nTrabajo.ARMAZON == null)
                        {
                            cantidadarmazoninterna = Convert.ToInt32(vistaFactura.Rows[i].Cells[2].Value.ToString());
                            if (cantidadarmazon < cantidadarmazoninterna)
                            {
                                nTrabajo.ARMAZON = codigoInventario;
                                contador = i;
                                cantidadarmazon++;
                            }
                        }
                        else if (ProductoVendidoDBM.productoLuna(codigoInventario) == true && nTrabajo.LUNA == null)
                        {
                            cantidadlunainterna = Convert.ToInt32(vistaFactura.Rows[i].Cells[2].Value.ToString());
                            if (cantidadluna < cantidadlunainterna)
                            {
                                nTrabajo.LUNA = codigoInventario;
                                contador = i;
                                cantidadluna++;
                            }
                                
                        }
                        if (nTrabajo.ARMAZON != null && nTrabajo.LUNA != null)
                        {
                            contador = i;
                            break;
                        }
                        contador = i;
                    }
                    if (nTrabajo.ARMAZON != null || nTrabajo.LUNA != null)
                    {                        
                        TrabajoDBM.Nuevo(nTrabajo);
                    }
                    if (contador == vistaFactura.Rows.Count - 1 && cantidadluna==cantidadlunainterna && cantidadarmazon==cantidadarmazoninterna)
                    {
                        analizartrabajo = true;
                    }
                    else if (contador == vistaFactura.Rows.Count - 1 && cantidadluna != cantidadlunainterna && cantidadarmazon != cantidadarmazoninterna)
                    {
                        contador = 0;
                    }
                }
                
                //en caso de un abono en el momento de crear la factura
                if (Convert.ToDecimal(txtAbono.Text) > 0)
                {
                    if (metodoPago.SelectedIndex >= 0|| metodoPago.SelectedIndex < 2)
                    {
                        Pago nPago = new Pago();
                        nPago.ID_PAGO = PagoDBM.UltimoPagoID() + 1;
                        nPago.ID_CUENTA = nCuenta.ID_CUENTA;
                        nPago.FECHA_ABONO = FacturaDBM.obtenerFechaSistema();
                        nPago.TIPO_PAGO = metodoPago.SelectedIndex;
                        nPago.MONTO = Convert.ToDecimal(txtAbono.Text);
                        if (nPago.TIPO_PAGO == 0) nPago.DESCRIPCION = "PAGO EN EFECTIVO";//usar la descripcion de la zona de pago
                        else if (nPago.TIPO_PAGO == 1)
                        {
                            nPago.TARJETA = txtTarjeta.Text;
                            nPago.REF = txtRef.Text;
                            nPago.DESCRIPCION = "PAGO CON TARJETA DE CREDITO";
                            switch (cmbTipo.SelectedIndex)
                            {
                                case 0: nPago.TIPO = "Corriente";break;
                                case 1: nPago.TIPO = "Diferido";break;
                                default: MessageBox.Show("Tipo de Pago con tarjeta no seleccionado", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                            }
                                
                        }
                        else if (nPago.TIPO_PAGO == 2)
                        {
                            nPago.BANCO = txtBanco.Text;
                            nPago.CHEQUE = txtCheque.Text;
                            nPago.DESCRIPCION = "PAGO CON CHEQUE";
                        }
                        CuentaDBM.abono(nCuenta.ID_CUENTA, nPago.MONTO);
                        PagoDBM.Pagar(nPago);
                    }
                    else
                    {
                        MessageBox.Show("Modo de Pago no seleccionado", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Campos incorrectos en la factura", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Cambiar éste mensaje de error
            }

            
            List<FacturaImpresion> recibo = new List<FacturaImpresion>();

            for (int i=0; i<vistaFactura.Rows.Count; i++)
            {
                FacturaImpresion elemento = new FacturaImpresion();
                elemento.Codigo = vistaFactura.Rows[i].Cells[0].Value.ToString();
                elemento.Descripcion= vistaFactura.Rows[i].Cells[1].Value.ToString();
                elemento.Cantidad = Convert.ToInt32(vistaFactura.Rows[i].Cells[2].Value);
                elemento.ValorUnitario = Convert.ToDecimal(vistaFactura.Rows[i].Cells[3].Value);
                elemento.ValorTotal = Convert.ToDecimal(vistaFactura.Rows[i].Cells[4].Value);

                recibo.Add(elemento);

                //MessageBox.Show(elemento.Codigo.ToString());
            }


            try{
                Form impresion = new imprimir(recibo, ordenTipo.SelectedIndex, txtName.Text, txtId.Text, dateTime.Value, txtDireccion.Text, txtTelefono.Text,
                Convert.ToDecimal(txtSubtotal.Text), 0, Convert.ToDecimal(txtIva.Text),
                Convert.ToDecimal(txtTotal.Text), Convert.ToDecimal(txtAbono.Text), Convert.ToDecimal(txtSaldo.Text), dtpEntrega.Value);
                impresion.Show();
            }
            catch(System.FormatException er)
            {
                MessageBox.Show(er.Message,"Sercor",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            recibo.Clear();

            btnAllProducts_Click(null, null);
            limpiaformfactura(); 
        }

  
        private void CrearTrabajo()
        {

        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            //if (txtAbono.Text == "")
            //{
            //    txtAbono.Text = "0";
            //}
            //if (Convert.ToDecimal(txtAdd.Text) <= 0)
            //{
            //    toogleError(true, "Debe ingresar un número mayor a 0", 1);

            //}
            //else
            //{
            //    toogleError(false, "", 3);
            //}
            try
            {
                if (Convert.ToDecimal(txtAbono.Text) > Convert.ToDecimal(txtTotal.Text))
                {
                    toogleError(true, "El abono no puede ser mayor al total", 1);
                    txtAbono.Text = "0";
                }
            }
            catch (System.FormatException)
            {
                toogleError(true, "El abono debe ser mayor o igual a 0", 2);
                txtAbono.Text = "0";
            }
            //try
            //{

            //}

            //catch (System.FormatException)
            //{
            //    toogleError(true, "Debe ingresar un número", 1);
            //}
            calculaSaldo();
        }


        //////////////////////////
        ////CUENTAS POR COBRAR////
        //////////////////////////
        private void llenarcxc()
        {
            dgvCXC.DataSource = CuentaDBM.ObtenerCuentasN();
        }
        private void llenarcxcdetalle(string idcliente)
        {
            dgvCXCdetalle.DataSource = FacturaDBM.Historial(idcliente);
        }

        //////////////////////////
        ////      FIN CXC     ////
        //////////////////////////

        private void txtAbono_Enter(object sender, EventArgs e)
        {
            txtAbono.SelectAll();
        }

        private void dgvTrabajos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cambiarEstadoTr();
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            SDL _sdl = new SDL();
            _sdl.ShowDialog();
            toogleError(true, _sdl.mensaje,2);
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administrativo adminform = new Administrativo();
            adminform.ShowDialog();
        }

        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Factura _factura = new Factura();

            _factura.ID_FACTURA = Convert.ToInt32(dgvHistorial.SelectedRows[0].Cells[0].Value);
            _factura.ID_CLIENTE= dgvHistorial.SelectedRows[0].Cells[1].Value.ToString();
            _factura.ID_USUARIO= Convert.ToInt32(dgvHistorial.SelectedRows[0].Cells[2].Value);
            _factura.ID_DETALLE= Convert.ToInt32(dgvHistorial.SelectedRows[0].Cells[3].Value);
            _factura.ID_CUENTA = Convert.ToInt32(dgvHistorial.SelectedRows[0].Cells[4].Value);
            _factura.IVA = Convert.ToDecimal(dgvHistorial.SelectedRows[0].Cells[5].Value);
            _factura.TOTAL = Convert.ToDecimal(dgvHistorial.SelectedRows[0].Cells[6].Value);
            _factura.FECHA =dgvHistorial.SelectedRows[0].Cells[7].Value.ToString();
            _factura.FACTOR_DESCUENTO = Convert.ToDecimal(dgvHistorial.SelectedRows[0].Cells[8].Value);
            _factura.VALOR_DESCONTADO = Convert.ToDecimal(dgvHistorial.SelectedRows[0].Cells[9].Value);
            _factura.TIPO = Convert.ToInt32(dgvHistorial.SelectedRows[0].Cells[10].Value);
            _factura.INDICE = Convert.ToInt32(dgvHistorial.SelectedRows[0].Cells[11].Value);

            detalleForm _detalle = new detalleForm(_factura);
            _detalle.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void ordenTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblNumeroFactura.Text = Convert.ToString(ultimoIndice(ordenTipo.SelectedIndex)+1);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cxcCuenta = new Cuenta();
                cxcCuenta.ID_CUENTA = Convert.ToInt32(label_idcuenta.Text);
                cxcCuenta = CuentaDBM.ObtenerCuentaporID_cuenta(cxcCuenta.ID_CUENTA);
                Pago nPago = new Pago();
                nPago.ID_PAGO = PagoDBM.UltimoPagoID() + 1;
                nPago.ID_CUENTA = cxcCuenta.ID_CUENTA;
                nPago.FECHA_ABONO = dtAbono.Value.ToString("yyyy-MM-dd HH-mm-ss");
                nPago.TIPO_PAGO = metodoPagocxc.SelectedIndex;
                nPago.MONTO = Convert.ToDecimal(txt_Abonocxc.Text);
                if (nPago.TIPO_PAGO == 0) nPago.DESCRIPCION = "PAGO EN EFECTIVO";//usar la descripcion de la zona de pago
                else if (nPago.TIPO_PAGO == 1)
                {
                    nPago.TARJETA = txtTarjetacxc.Text;
                    nPago.REF = txtRefcxc.Text;
                    nPago.DESCRIPCION = "PAGO CON TARJETA DE CREDITO";
                    switch (cmbTipocxc.SelectedIndex)
                    {
                        case 0: nPago.TIPO = "Corriente"; break;
                        case 1: nPago.TIPO = "Diferido"; break;
                        default: MessageBox.Show("Tipo de Pago con tarjeta no seleccionado", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                    }

                }
                else if (nPago.TIPO_PAGO == 2)
                {
                    nPago.BANCO = txtBancocxc.Text;
                    nPago.CHEQUE = txtChequecxc.Text;
                    nPago.DESCRIPCION = "PAGO CON CHEQUE";
                }

                CuentaDBM.abono(cxcCuenta.ID_CUENTA, nPago.MONTO);
                PagoDBM.Pagar(nPago);
                dgvCXCdetalle.DataSource = PagoDBM.ObtenerPagos(cxcCuenta.ID_CUENTA);
                llenarcxc();
                vaciarcxc();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Seleccione una cuenta por cobrar", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void vaciarcxc()
        {
            txt_Abonocxc.Text = "0";
            txtTarjetacxc.Text = "";
            txtRefcxc.Text = "";
            txtBancocxc.Text = "";
            txtChequecxc.Text = "";
            label_Nombre.Text = "Nombre Del Cliente";
            label_TipoDoc.Text = "-----";
            label_iddoc.Text = "####";
            label_idcliente.Text = "#Id cliente";
            label_idcuenta.Text = "#Id cuenta";
            dtAbono.Value = System.DateTime.Now; ;
        }

        private void dgvCXCdetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Pago _pago = new Pago();

            
            _pago.ID_PAGO = Convert.ToInt32(dgvCXCdetalle.SelectedRows[0].Cells[0].Value);
            _pago.ID_CUENTA = int.Parse(dgvCXCdetalle.SelectedRows[0].Cells[1].Value.ToString());
            _pago.FECHA_ABONO = dgvCXCdetalle.SelectedRows[0].Cells[2].Value.ToString();
            _pago.TIPO_PAGO = Convert.ToInt32(dgvCXCdetalle.SelectedRows[0].Cells[3].Value);
            _pago.MONTO = Convert.ToDecimal(dgvCXCdetalle.SelectedRows[0].Cells[4].Value);

            //_pago.DESCRIPCION =dgvCXCdetalle.SelectedRows[0].Cells[5].Value.ToString();
            _pago.DESCRIPCION = (dgvCXCdetalle.SelectedRows[0].Cells[5].Value==null)? "": dgvCXCdetalle.SelectedRows[0].Cells[5].Value.ToString();

           // _pago.TARJETA = dgvCXCdetalle.SelectedRows[0].Cells[6].Value.ToString();
            _pago.TARJETA = (dgvCXCdetalle.SelectedRows[0].Cells[6].Value == null) ?"": dgvCXCdetalle.SelectedRows[0].Cells[6].Value.ToString();

            //_pago.TIPO = dgvCXCdetalle.SelectedRows[0].Cells[7].Value.ToString();
            _pago.TIPO = (dgvCXCdetalle.SelectedRows[0].Cells[7].Value == null) ? "":dgvCXCdetalle.SelectedRows[0].Cells[7].Value.ToString();

            //_pago.REF = dgvCXCdetalle.SelectedRows[0].Cells[8].Value.ToString();
            _pago.REF = (dgvCXCdetalle.SelectedRows[0].Cells[8].Value == null) ?"": dgvCXCdetalle.SelectedRows[0].Cells[8].Value.ToString();

            //_pago.BANCO = dgvCXCdetalle.SelectedRows[0].Cells[9].Value.ToString();
            _pago.BANCO = (dgvCXCdetalle.SelectedRows[0].Cells[9].Value == null) ? "":dgvCXCdetalle.SelectedRows[0].Cells[9].Value.ToString();

           // _pago.CHEQUE = dgvCXCdetalle.SelectedRows[0].Cells[10].Value.ToString();
            _pago.CHEQUE = (dgvCXCdetalle.SelectedRows[0].Cells[10].Value == null) ? "":dgvCXCdetalle.SelectedRows[0].Cells[10].Value.ToString();

            DetallePago _detalle = new DetallePago(_pago);

            if (CuentaDBM.ObtenerCuentaporID_cuenta(_pago.ID_CUENTA).TOTAL == 0)
            {
                MessageBox.Show("Factura anulada", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if(_pago.MONTO==0){
                MessageBox.Show("Pago completo o anulado", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _detalle.Show();
            }
        }

        private void dgvCXC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cuenta cxcCuenta = new Cuenta();
            try
            {
                int codigo = Convert.ToInt32(dgvCXC.CurrentRow.Cells[0].Value);
                CuentaN cuentaseleccionada = CuentaDBM.ObtenerCuentaNporID_cuenta(codigo);
                dgvCXCdetalle.DataSource = PagoDBM.ObtenerPagos(cuentaseleccionada.ID_CUENTA);
                label_idcuenta.Text = cuentaseleccionada.ID_CUENTA.ToString();
                label_idcliente.Text = cuentaseleccionada.ID_CLIENTE;
                label_Nombre.Text = cuentaseleccionada.NOMBRE_CLIENTE;

                switch (cuentaseleccionada.TIPO)
                {
                    case 0:
                        label_TipoDoc.Text = "Orden";break;
                    case 1:
                        label_TipoDoc.Text = "Factura"; break;
                    case 2:
                        label_TipoDoc.Text = "Nota"; break;
                    default:
                        label_TipoDoc.Text = "Doc-I"; break;
                }
                label_iddoc.Text = cuentaseleccionada.ID_DOCUMENTO.ToString();
                txtTotalcxc.Text = cuentaseleccionada.TOTAL.ToString();
                txtSaldocxc.Text = cuentaseleccionada.SALDO.ToString();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No existen Cuentas para agregar", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Abonocxc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_Abonocxc.Text) > Convert.ToDecimal(txtSaldocxc.Text))
                {
                    toogleError(true, "El abono no puede ser mayor al saldo", 1);
                    txt_Abonocxc.Text = "0";
                }
            }
            catch (System.FormatException)
            {
                toogleError(true, "El abono debe ser mayor o igual a 0", 2);
                txt_Abonocxc.Text = "0";
            }
        }

        private void txt_Abonocxc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esDinero(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Abonocxc_Enter(object sender, EventArgs e)
        {
            txtAbono.SelectAll();
        }

        private List<CuentaN> buscarCXC(int index)
        {
            List<CuentaN> filtrado = null;
            switch (index)
            {
                case 0://TODOS
                    filtrado = CuentaDBM.ObtenerFiltro(index);
                    break;
                case 1://NO PAGADOS
                    filtrado = CuentaDBM.ObtenerFiltro(index);
                    break;
                case 2://PAGADOS
                    filtrado = CuentaDBM.ObtenerFiltro(index);
                    break;
            }
            return filtrado;
        }

        private void cmbEstadocxc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCXC.DataSource = buscarCXC(cmbEstadocxc.SelectedIndex);
                toogleError(false, null, 1);
            }
            catch (FormatException) { toogleError(true, "NO HAY VALORES QUE BUSCAR", 2); }
        }

        private void metodoPagocxc_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodoDePago(metodoPagocxc.SelectedIndex);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Añadir_egreso añadirEgreso = new Añadir_egreso();
            añadirEgreso.ShowDialog();
            toogleError(true, añadirEgreso.mensaje, 2);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            String inicio = dtpReporte.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String fin = dtpReportefin.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dgvIngresos.DataSource = PagoDBM.ObtenerPagosFecha(inicio, fin);
            dgvEgresos.DataSource = EgresoDBM.ReporteEgresosFecha(inicio, fin);
        }

        private void dtpReportefin_ValueChanged(object sender, EventArgs e)
        {
            String inicio = dtpReporte.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String fin = dtpReportefin.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dgvIngresos.DataSource = PagoDBM.ObtenerPagosFecha(inicio, fin);
            dgvEgresos.DataSource = EgresoDBM.ReporteEgresosFecha(inicio, fin);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            llenareportes();
        }

        private void reporteElementos()
        {
            dtpReporteInicial.Visible = false;
            dtpReporteFinal.Visible = false;
            btnOkReporte.Visible = false;

            btnTodoInventarioReporte.Visible = false;
            btnDisponibleInventario.Visible = false;
            btnAgotadoInventario.Visible = false;
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            reporteElementos();

            switch (cmbReporte.SelectedIndex)
            {
                case 0:
                    btnTodoInventarioReporte.Visible = true;
                    btnDisponibleInventario.Visible = true;
                    btnAgotadoInventario.Visible = true;
                    break;

                case 1:
                    dtpReporteInicial.Visible = true;
                    dtpReporteFinal.Visible = true;
                    btnOkReporte.Visible = true;
                    break;

                case 2:
                    //Facturacion del día
                    dtpReporteInicial.Visible = true;
                    dtpReporteFinal.Visible = true;
                    btnOkReporte.Visible = true;
                    break;
            }
        }

        private void btnTodoInventarioReporte_Click(object sender, EventArgs e)
        {
            List < Producto > _list;

            _list = ProductoDBM.ObtenerProductos();

            inventarioReporte1.SetDataSource(_list);
            inventarioReporte1.SetParameterValue(1, "de todos los productos");
            crystalReportViewer1.ReportSource = inventarioReporte1;
            crystalReportViewer1.Refresh();
        }

        private void btnDisponibleInventario_Click(object sender, EventArgs e)
        {
            List<Producto> _list;

            _list = ProductoDBM.ObtenerProductosAgotados();

            inventarioReporte1.SetDataSource(_list);
            inventarioReporte1.SetParameterValue(1, "de productos adotados");
            crystalReportViewer1.ReportSource = inventarioReporte1;
            crystalReportViewer1.Refresh();
        }

        private void btnAgotadoInventario_Click(object sender, EventArgs e)
        {
            List<Producto> _list;

            _list = ProductoDBM.ObtenerProductosDisponibles();

            inventarioReporte1.SetDataSource(_list);
            inventarioReporte1.SetParameterValue(1, "de productos disponibles");
            crystalReportViewer1.ReportSource = inventarioReporte1;
            crystalReportViewer1.Refresh();
        }

        private void btnOkReporte_Click(object sender, EventArgs e)
        {
            

            switch (cmbReporte.SelectedIndex)
            {
                case 1:
                    string fecha1 = dtpReporteInicial.Value.ToString("yyyy-MM-dd");
                    string fecha2 = dtpReporteFinal.Value.ToString("yyyy-MM-dd");
                    List<PagoReporte> _list;


                    decimal totalEfectivo = PagoDBM.suma(0, fecha1, fecha2);
                    decimal totalTarjeta = PagoDBM.suma(1, fecha1, fecha2);
                    decimal totalCheque = PagoDBM.suma(2, fecha1, fecha2);
                    decimal totalEgreso = PagoDBM.sumaEgreso(fecha1, fecha2);
                    decimal totalNeto = totalEfectivo + totalTarjeta + totalCheque - totalEgreso;

                    _list = PagoDBM.ObtenerPagosReporte(fecha1, fecha2);

                    movimientos1.SetDataSource(_list);
                    //movimientos1.Database.Tables[1].SetDataSource(_list2);

                    movimientos1.SetParameterValue(1, "movimiento de caja");
                    movimientos1.SetParameterValue(2, totalNeto);
                    movimientos1.SetParameterValue(6, totalEfectivo);
                    movimientos1.SetParameterValue(7, totalTarjeta);
                    movimientos1.SetParameterValue(8, totalCheque);
                    movimientos1.SetParameterValue(9, totalEgreso * -1);


                    crystalReportViewer1.ReportSource = movimientos1;
                    crystalReportViewer1.Refresh();
                    break;

                case 2:
                    fecha1 = dtpReporteInicial.Value.ToString("yyyy-MM-dd");
                    fecha2 = dtpReporteFinal.Value.ToString("yyyy-MM-dd");


                    totalEfectivo = PagoDBM.suma(0, fecha1, fecha2);
                    totalTarjeta = PagoDBM.suma(1, fecha1, fecha2);
                    totalCheque = PagoDBM.suma(2, fecha1, fecha2);
                    totalEgreso = 0;

                    totalNeto = totalEfectivo + totalTarjeta + totalCheque - totalEgreso;
                    _list = PagoDBM.ObtenerPagosReporteFactura(fecha1, fecha2);

                    movimientos1.SetDataSource(_list);
                    //movimientos1.Database.Tables[1].SetDataSource(_list2);

                    movimientos1.SetParameterValue(1, "movimiento de caja");
                    movimientos1.SetParameterValue(2, totalNeto);
                    movimientos1.SetParameterValue(6, totalEfectivo);
                    movimientos1.SetParameterValue(7, totalTarjeta);
                    movimientos1.SetParameterValue(8, totalCheque);
                    movimientos1.SetParameterValue(9, 0);


                    crystalReportViewer1.ReportSource = movimientos1;
                    crystalReportViewer1.Refresh();
                    break;

            }

            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void dgvCXC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambiarEstadoTr();
        }

        private void dgvTrabajos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int estado = Convert.ToInt32(dgvTrabajos.CurrentRow.Cells[8].Value);
            switch (estado)
            {
                case 1: 
                    label_estado.Text = "Separado";
                    label_estado.ForeColor = Color.Gold;
                    break;
                case 2:
                    label_estado.Text = "Laboratorio";
                    label_estado.ForeColor = Color.Red;
                    break;
                case 3:
                    label_estado.Text = "Recibido";
                    label_estado.ForeColor = Color.Green;
                    break;
                case 4:
                    label_estado.Text = "Entregado";
                    label_estado.ForeColor = Color.Blue;
                    break;
                default:
                    label_estado.Text = "----------------";
                    break;
            }
        }
    }
}