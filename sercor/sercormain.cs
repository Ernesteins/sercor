﻿using System;
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
        public sercormain(Usuario usuario, Form form)
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

            ordenTipo.SelectedIndex=0;
            metodoPago.SelectedIndex = 0;

            btnAllProducts_Click(null,null);

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
            btnTodosInventario_Click(null, null);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            menuToggler(4);
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            menuToggler(5);
            btnTodosTrabajo_Click(null,null);
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            menuToggler(6);
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

        float ivaConst = 0.12F;//constante iva

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
            }
        }

        private void sercormain_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPadre.Enabled = true;
        }

        private List<Producto> buscarFiltro(int index, TextBox _busqueda){
            List<Producto> filtrado=null;
            switch (index)
            {
                case 0://CODIGO
                    filtrado = ProductoDBM.ObtenerPorFiltro(_busqueda.Text,null,null,null,null);
                    break;

                case 1:
                    filtrado = ProductoDBM.ObtenerPorFiltro(null, _busqueda.Text, null, null, null);
                    break;

                case 2:
                    filtrado = ProductoDBM.ObtenerPorFiltro(null, null, _busqueda.Text, null, null);
                    break;

                case 3:
                    filtrado = ProductoDBM.ObtenerPorFiltro(null, null, null,_busqueda.Text, null);
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
            dgvProductos.DataSource = buscarFiltro(cmbFiltro.SelectedIndex,txtProducto);
        }

       

        private void metodoDePago(int index)//Para metodo de pago
        {
            cmbTipo.SelectedIndex = 0;

            txtTarjeta.Enabled = false;
            txtRef.Enabled = false;
            cmbTipo.Enabled = false;
            txtCheque.Enabled = false;
            txtBanco.Enabled = false;

            switch (index)
            {
                case 0:
                    //nada
                    break;

                case 1:
                    txtTarjeta.Enabled = true;
                    txtRef.Enabled = true;
                    cmbTipo.Enabled = true;
                    break;
                    
                case 2:
                    txtCheque.Enabled = true;
                    txtBanco.Enabled = true;
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
            dgvProductos.DataSource = ProductoDBM.ObtenerProductosEstado();

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
            toogleError(true,"Nueva factura",2);
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
                    vistaFactura.Rows.Insert(0, productoSeleccionado.COD, productoSeleccionado.DESCRIPCION,
                    1, productoSeleccionado.PRECIO, productoSeleccionado.PRECIO);
                }
                else
                {
                    ImprimirFactura(k, 0, productoSeleccionado);
                }
                subtotal();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No existen productos para agregar", "Sercor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                txtDescuento.Text = descuentito.Replace(",", ".");


                if (togDescuento == true)
                {
                    if (float.Parse(txtDescuento.Text) >= float.Parse(txtTotal.Text) * 0.9)
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
            ProductosFiltro(cbmFiltroInventario.SelectedIndex,txtBusquedaInventario);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            agregar_producto agregarProducto = new agregar_producto();
            agregarProducto.ShowDialog();

            toogleError(true,agregarProducto.mensaje,2);

            btnTodosInventario_Click(null, null);
            btnAllProducts_Click(null,null);
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
                MessageBox.Show("No existen productos para modificar","Sercor",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
                toogleError(false,null,1);
                }catch (FormatException ) { toogleError(true , "NO HAY VALORES QUE BUSCAR" , 2 ); }
            
        }

        private List<Trabajo> buscarFiltrotr(int index, TextBox _busqueda)
        {
            List<Trabajo> filtrado = null;
            switch (index)
            {
                case 0://ID
                    //MessageBox.Show(string.Format ("ID de búsqueda = {0}",_busqueda.Text));
                    filtrado = TrabajoDBM.ObtenerPorFiltro(0, 0, Convert.ToInt32(_busqueda.Text), null, null,null,null,null,1);
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
        //FUNCION DE ACEPTAR NUMEROS
        public bool esDinero(Char c)
        {
            if (Char.IsDigit(c)||Char.IsControl(c)||c=='.'||c==',')
            {
                return false;
            }
            return true;
        }

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


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Factura nFactura = new Factura();
                nFactura.ID_FACTURA = Convert.ToInt32(ultimoIdFactura()+1);
                nFactura.ID_CLIENTE = txtId.Text;
                nFactura.ID_USUARIO = Convert.ToInt32(IDUser);
                nFactura.IVA = Convert.ToDecimal(ivaConst);
                nFactura.TOTAL = Convert.ToDecimal(txtTotal.Text);
                nFactura.FECHA = FacturaDBM.obtenerFechaSistema();
                nFactura.FACTOR_DESCUENTO = Convert.ToDecimal(factorDescuento);
                nFactura.VALOR_DESCONTADO = Convert.ToDecimal(txtDescuento.Text);
                nFactura.TIPO = ordenTipo.SelectedIndex;
                nFactura.INDICE = ultimoIndice(ordenTipo.SelectedIndex)+1;

                Cuenta nCuenta = new Cuenta();
                nCuenta.ID_CUENTA = CuentaDBM.ultimacuenta() + 1;
                nCuenta.ID_CLIENTE = txtId.Text;
                nCuenta.ID_FACTURA = Convert.ToInt32(ultimoIdFactura()+1);
                nCuenta.TOTAL = Convert.ToDecimal(txtTotal.Text);
                nCuenta.FORMA_P = metodoPago.SelectedIndex;
                nCuenta.SALDO = Convert.ToDecimal(txtSaldo.Text);

                /*
                Trabajo nTrabajo = new Trabajo();
                nTrabajo.ID = TrabajoDBM.ultimoTrabajo() + 1;
                nTrabajo.CUENTA = CuentaDBM.ultimacuenta() + 1;
                nTrabajo.FACTURA = Convert.ToInt32(lblNumeroFactura.Text);
                nTrabajo.FECHA_INICIO = null;
                nTrabajo.NOMBRE = txtName.Text;
                nTrabajo.ARMAZON = null;
                nTrabajo.LUNA = null;
                nTrabajo.ESTADO = 0;
                nTrabajo.FECHA_ENTREGA = null;*/

                FacturaDBM.Agregar(nFactura);
                CuentaDBM.Agregar(nCuenta);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Formato incorrecto");
            }
            
            
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
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administrativo adminform = new Administrativo();
            adminform.ShowDialog();
        }

        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            detalleForm _detalle = new detalleForm();
            _detalle.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void ordenTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblNumeroFactura.Text = Convert.ToString(ultimoIndice(ordenTipo.SelectedIndex)+1);
        }
    }
}