using System;
using System.Windows.Forms;

namespace sercor
{
    public partial class editar_producto : Form
    {
        public string mensaje;
        string codigo;
        public editar_producto(Producto producto)
        {
            InitializeComponent();

            FormInstance.puntoDecimal();

            codigo = producto.COD;

            string[] armaLuna;
            armaLuna = producto.DESCRIPCION.Split('|');
            if (armaLuna.Length == 2)
            {
                txtDescripcion.Text = armaLuna[1];
                if (armaLuna[0] == "ARMA")
                {
                    rd3.Checked = true;
                }
                else
                {
                    rd4.Checked = true;
                }
            }
            else
            {
                txtDescripcion.Text = armaLuna[0];
                rd5.Checked = true;
            }


            txtCodigo.Text = producto.COD;
            txtNombre.Text = producto.NOMBRE;
            //txtDescripcion.Text = producto.DESCRIPCION;
            txtCategoria.Text = producto.CATEGORIA;
            txtSubcategoria.Text = producto.SUBCATEGORIA;
            txtExistencia.Text = Convert.ToString(producto.EXISTENCIA);
            txtPrecio.Text = Convert.ToString(producto.PRECIO);

            //MessageBox.Show(Convert.ToString(producto.ESTADO));
            if (producto.ESTADO == 1)
            {
                rd2.Checked = true;
            }
            else
            {
                rd1.Checked = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" | txtNombre.Text == "" | txtDescripcion.Text == "" | txtCategoria.Text == "" | txtSubcategoria.Text == "" | txtExistencia.Text == "" | txtPrecio.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else
            {
                try{
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

                    int estado;
                    if (rd1.Checked == true)
                    {
                        estado = 0;
                    }
                    else
                    {
                        estado = 1;
                    }


                    pProducto.ESTADO = estado;

                    int resultado = ProductoDBM.Modificar(pProducto, codigo);
                    if (resultado > 0)
                    {
                        Registro nregistro = new Registro();
                        nregistro.ID_PRODUCTO = pProducto.COD;
                        nregistro.FECHA = FacturaDBM.obtenerFechaSistema();
                        nregistro.CANTIDAD = pProducto.EXISTENCIA;
                        nregistro.IDREGISTRO = RegistroDBM.UltimoRegistro() + 1;
                        RegistroDBM.Agregar(nregistro);
                        mensaje = "Producto modificado con exito";
                        this.Close();
                    }
                    else
                    {
                        mensaje = "No es posible modificar el producto";
                        this.Close();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Valores incorrecto");
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Producto existente");
                }

            }
        }

    }
}
