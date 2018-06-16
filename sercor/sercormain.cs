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
        public Factura ultimoRegistro { get; set; }

        private void toogleError(bool show, string mensaje)
        {
            if (show == false)
            {
                lblErrors.Text = "Salida";
            }
            else
            {
                lblErrors.Text = mensaje;
            }
        }  
        
        private void ultimoIdFactura()
        {
            ultimoRegistro = FacturaDBM.UltimoID();
            int idUltimoFactura = ultimoRegistro.ID_FACTURA;
            int nuevoIdFactura = idUltimoFactura + 1;
            lblNumeroFactura.Text = Convert.ToString(nuevoIdFactura);
        }
        //CARGA DATOS DEL USUARIO ACTUAL EN EL FORMULRIO
        public  sercormain(Usuario usuario)
        {
            InitializeComponent();

            menuToggler(1);

            ultimoIdFactura();

            toogleError(false,"");

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
                    btnUser.BackColor=Color.FromArgb(255, 128, 128);
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

            btnVentas.BackColor = Color.LightSkyBlue;
            btnCxc.BackColor = Color.LightSkyBlue;
            btnInventario.BackColor = Color.LightSkyBlue;
            btnReportes.BackColor = Color.LightSkyBlue;
            btnTrabajos.BackColor = Color.LightSkyBlue; 
            btnMovimientos.BackColor = Color.LightSkyBlue;

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

                    btnVentas.BackColor = Color.DodgerBlue;
                    btnVentas.ForeColor = Color.White;
                    break;

                case 2: //CXC
                    pnCxc.Visible = true;
                    pnCxc.Dock = DockStyle.Fill;

                    btnCxc.BackColor = Color.DodgerBlue;
                    btnCxc.ForeColor = Color.White;
                    break;

                case 3:
                    pnInventario.Visible = true;
                    pnInventario.Dock = DockStyle.Fill;

                    btnInventario.BackColor = Color.DodgerBlue;
                    btnInventario.ForeColor = Color.White;
                    break;

                case 4:
                    pnReportes.Visible = true;
                    pnReportes.Dock = DockStyle.Fill;

                    btnReportes.BackColor = Color.DodgerBlue;
                    btnReportes.ForeColor = Color.White;
                    break;

                case 5:
                    pnTrabajos.Visible = true;
                    pnTrabajos.Dock = DockStyle.Fill;

                    btnTrabajos.BackColor = Color.DodgerBlue;
                    btnTrabajos.ForeColor = Color.White;
                    break;

                case 6:
                    pnMovCaja.Visible = true;
                    pnMovCaja.Dock = DockStyle.Fill;

                    btnMovimientos.BackColor = Color.DodgerBlue;
                    btnMovimientos.ForeColor = Color.White;
                    break;

                default:
                    break;
            }
        }

        //REFRESCA EL AUTOCOMPLETE DEL CLIENTE
        private void autocompleteRefresh()
        {
            //CARGA EN AUTOCOMPLETE DE NOMBRE DESDE BASE DE DATOS
            var clienteNombres = new AutoCompleteStringCollection();
            var clienteId = new AutoCompleteStringCollection();
            //MessageBox.Show(Convert.ToString(ClienteDBM.ObtenerNombres().Count));
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
            //txtName.AutoCompleteCustomSource = clienteNombres;
            txtId.AutoCompleteCustomSource = clienteId;
        }

        //public sercormain(){
        //    InitializeComponent();
        //    menuToggler(1);

        //    autocompleteRefresh();
        //}

        public Cliente clienteNombres { get; set; }

        private void btnVentas_Click(object sender, EventArgs e){
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //if (ocupado2 != true)
            //{
            //    Ocupado(1);
            //    if (txtName.Text == ClienteDBM.ObtenerCliente(null, txtName.Text).NOMBRE)
            //    {
            //        txtTelefono.Text = ClienteDBM.ObtenerCliente(null, txtName.Text).TELEFONO;
            //        txtDireccion.Text = ClienteDBM.ObtenerCliente(null, txtName.Text).DIRECCION;
            //        txtId.Text = Convert.ToString(ClienteDBM.ObtenerCliente(null, txtName.Text).ID_CLIENTE);
            //        ocupado = false;
            //    }
            //    else
            //    {
            //        txtTelefono.Text = "";
            //        txtDireccion.Text = "";
            //        txtId.Text = "";
            //        ocupado = false;
            //    }
            //}
        }

        //bool ocupado;
        //bool ocupado2;
        //private void Ocupado(int e)
        //{
        //    switch (e)
        //    {
        //        case 1:
        //            ocupado = true;
        //            break;
        //        case 2:
        //            ocupado2 = true;
        //            break;
        //    }
        //}


        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //if (ocupado!=true)
            //{
            //    Ocupado(2);
                if (txtId.Text == Convert.ToString(ClienteDBM.ObtenerCliente(txtId.Text, null).ID_CLIENTE))
                {
                    txtName.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).NOMBRE;
                    txtTelefono.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).TELEFONO;
                    txtDireccion.Text = ClienteDBM.ObtenerCliente(txtId.Text, null).DIRECCION;
                    //ocupado2 = false;
                }
                else
                {
                    txtName.Text = "";
                    txtTelefono.Text = "";
                    txtDireccion.Text = "";
                    //ocupado2 = false;
                }
            //}
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ProductoDBM.ObtenerProductos();

            //DataGridViewColumn column = dgvProductos.Columns[0];
            //column.Width = 50;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            vistaFactura.Rows.Clear();

            txtId.Focus();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            Producto productoSeleccionado = ProductoDBM.ObtenerProductoCod(codigo);

            int filas = vistaFactura.RowCount;
            bool modif = false;
            int k = 0;

            for (int j = 0; j <= filas - 1; j++)
            {
                if (codigo == Convert.ToInt32(vistaFactura.Rows[j].Cells[0].Value))
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
                vistaFactura.Rows[k].Cells[1].Value = productoSeleccionado.DESCRIPCION;
                vistaFactura.Rows[k].Cells[2].Value = Convert.ToInt32(vistaFactura.Rows[k].Cells[2].Value) + 1;
                vistaFactura.Rows[k].Cells[3].Value = productoSeleccionado.PRECIO;
                vistaFactura.Rows[k].Cells[4].Value = productoSeleccionado.PRECIO * Convert.ToInt32(vistaFactura.Rows[k].Cells[2].Value);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            toogleError(false,"");
            try
            {
                if (txtAdd.Text == "")
                {
                    txtAdd.Text = "0";
                }
                if (Convert.ToInt32(txtAdd.Text) <= 0)
                {
                    toogleError(true,"Debe ingresar un número mayor a 0");
                }
                else
                {
                    int codigo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                    Producto productoSeleccionado = ProductoDBM.ObtenerProductoCod(codigo);
                    int cantidad = Convert.ToInt32(txtAdd.Text);

                    int filas = vistaFactura.RowCount;
                    bool modif = false;
                    int k = 0;

                    for (int j = 0; j <= filas - 1; j++)
                    {
                        if (codigo == Convert.ToInt32(vistaFactura.Rows[j].Cells[0].Value))
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
                    else
                    {
                        vistaFactura.Rows[k].Cells[1].Value = productoSeleccionado.DESCRIPCION;
                        vistaFactura.Rows[k].Cells[2].Value = cantidad;
                        vistaFactura.Rows[k].Cells[3].Value = productoSeleccionado.PRECIO;
                        vistaFactura.Rows[k].Cells[4].Value = productoSeleccionado.PRECIO * Convert.ToInt32(vistaFactura.Rows[k].Cells[2].Value);
                    }
                }
            }
            catch(System.FormatException)
            {
                toogleError(true,"Debe ingresar un número");
            }
        }
    }
}
