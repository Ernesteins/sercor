using System;
using System.Windows.Forms;
namespace sercor
{
    public partial class agregar_producto : Form
    {
        public agregar_producto()
        {
            InitializeComponent();
            Autocomplete();

            //SUPER IMPORTANTE D:
            FormInstance.puntoDecimal();
        }
        private void Autocomplete(){
            var pFiltroCat = new AutoCompleteStringCollection();
            var pFiltroSubCat = new AutoCompleteStringCollection();

            int j = 0;

            for (int i = 0; i <= ProductoDBM.ObtenerProductos().Count; i++)
            {
                if (j != ProductoDBM.ObtenerProductos().Count)
                {
                    pFiltroCat.Add(ProductoDBM.ObtenerProductos()[j].CATEGORIA);
                    pFiltroSubCat.Add(ProductoDBM.ObtenerProductos()[j].SUBCATEGORIA);

                    j++;
                }
            }
            txtCategoria.AutoCompleteCustomSource = pFiltroCat;
            txtSubcategoria.AutoCompleteCustomSource = pFiltroSubCat;
        }

        public string mensaje;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" | txtNombre.Text=="" | txtDescripcion.Text=="" | txtCategoria.Text=="" | txtSubcategoria.Text=="" | txtExistencia.Text==""|txtPrecio.Text=="")
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                
                
                try
                {
                    Producto pProducto = new Producto();
                    pProducto.COD = txtCodigo.Text.Trim();
                    pProducto.NOMBRE = txtNombre.Text.Trim();

                    string concat;
                    if (rd3.Checked == true)
                    {
                        concat = "ARMA|";
                    }
                    else if (rd4.Checked == true)
                    {
                        concat = "LUNA|";
                    }
                    else
                    {
                        concat = "";
                    }

                    pProducto.DESCRIPCION = concat+txtDescripcion.Text.Trim();


                    pProducto.CATEGORIA = txtCategoria.Text.Trim();
                    pProducto.SUBCATEGORIA = txtSubcategoria.Text.Trim();
                    pProducto.EXISTENCIA = Convert.ToInt32(txtExistencia.Text);

                    txtPrecio.Text = txtPrecio.Text.Replace(",", ".");

                    pProducto.PRECIO = Decimal.Round(Convert.ToDecimal(txtPrecio.Text), 2);
                    //MessageBox.Show(pProducto.PRECIO.ToString());

                    int estado;
                    if (rd1.Checked == true)
                    {
                        estado = 1;
                    }
                    else
                    {
                        estado = 0;
                    }

                    pProducto.ESTADO = estado;
                    //pCliente.Fecha_Nac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;

                    int resultado = ProductoDBM.Agregar(pProducto);
                    if (resultado > 0)
                    {
                        Registro nregistro = new Registro();
                        nregistro.ID_PRODUCTO = pProducto.COD;
                        nregistro.FECHA = FacturaDBM.obtenerFechaSistema();
                        nregistro.CANTIDAD = pProducto.EXISTENCIA;
                        nregistro.IDREGISTRO = RegistroDBM.UltimoRegistro() + 1;
                        RegistroDBM.Agregar(nregistro);

                        //MessageBox.Show("Producto guardado con exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mensaje = "Producto guardado con exito";
                        this.Close();
                    }
                    else
                    {
                        //MessageBox.Show("No se pudo guardar el producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        mensaje = "No es posible guardar el producto";
                        this.Close();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Valores incorrectos");
                }
                catch (MySql.Data.MySqlClient.MySqlException) {
                    MessageBox.Show("Producto existente");
                }              
            }   
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esNumero(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public bool esNumero(Char c)
        {
            if (Char.IsDigit(c) || Char.IsControl(c))
            {
                return false;
            }
            return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (esDinero(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public bool esDinero(Char c)
        {
            if (Char.IsDigit(c) || Char.IsControl(c) || c == '.' || c == ',')
            {
                return false;
            }
            return true;
        }
    }
}